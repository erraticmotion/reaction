namespace System.Usb
{
    using System;
    using Collections;
    using Threading;

    using Microsoft.SPOT;
    using Microsoft.SPOT.Hardware;

    using GHIElectronics.NETMF.USBHost;

    /// <summary>
    /// 
    /// </summary>
    public sealed class UsbShuttlePro
    {
        // USB handles to the device
        private readonly USBH_RawDevice jogWheel;
        private readonly USBH_RawDevice.Pipe jogWheelPipe;

        // Listener Thread
        private readonly Thread jogWheelThread;

        // Positions for current read
        private BitArray buttons = new BitArray(16, false);
        private int shuttlePosition;
        private int jogPosition;

        // Positions at last read
        private BitArray buttonsLast;
        private int shuttlePositionLast;
        private int jogPositionLast;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsbShuttlePro"/> class.
        /// </summary>
        /// <param name="device">USB Host RAW Device</param>
        public UsbShuttlePro(USBH_Device device)
        {
            jogWheel = new USBH_RawDevice(device);
            var cd = jogWheel.GetConfigurationDescriptors(0);

            jogWheel.SendSetupTransfer(0x00, 0x09, cd.bConfigurationValue, 0x00);
            var jogWheelEp = cd.interfaces[0].endpoints[0];
            jogWheelPipe = jogWheel.OpenPipe(jogWheelEp);
            jogWheelPipe.TransferTimeout = 0;

            jogWheelThread = ThreadFactory.CreateThread(JogReaderMonitor, ThreadPriority.Highest); 
            jogWheelThread.Start();
        }

        public delegate void UsbShuttleProEvent(int e);

        /// <summary>
        /// Occurs when [jog button down].
        /// </summary>
        public event UsbShuttleProEvent JogButtonDown;

        /// <summary>
        /// Occurs when [jog button up].
        /// </summary>
        public event UsbShuttleProEvent JogButtonUp;

        /// <summary>
        /// Occurs when [shuttle position changed].
        /// </summary>
        public event UsbShuttleProEvent ShuttlePositionChanged;

        /// <summary>
        /// Occurs when [jog position changed].
        /// </summary>
        public event UsbShuttleProEvent JogPositionChanged;

        private void RaiseEvent(UsbShuttleProEvent ev, int e)
        {
            if (ev != null)
            {
                ev(e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void JogReaderMonitor()
        {
            var jogWheelData = new byte[jogWheelPipe.PipeEndpoint.wMaxPacketSize];

            for (; ; )
            {
                // Our sleep time is the device polling interval time
                Thread.Sleep(jogWheelPipe.PipeEndpoint.bInterval);

                // Read the data from the USB pipe
                lock (jogWheelData)
                {
                    try
                    {
                        jogWheelPipe.TransferData(jogWheelData, 0, jogWheelData.Length);
                    }
                    catch
                    {
                        var e = USBHostController.GetLastError();
                        Debug.Print("ERROR" + e);
                        Array.Clear(jogWheelData, 0, jogWheelData.Length);
                    }
                }

                // Sets the last read settings before clearing the current one.
                shuttlePositionLast = shuttlePosition;
                jogPositionLast = jogPosition;

                // Set the current positions
                shuttlePosition = jogWheelData[0];
                jogPosition = jogWheelData[1];

                // Make sense of the counter-clockwise motion
                if (shuttlePosition > 200)
                {
                    shuttlePosition = shuttlePosition - 256;
                }

                // With these two bytes we can read the 15 buttons on the device.
                buttonsLast = buttons;
                buttons = new BitArray(Utility.ExtractRangeFromArray(jogWheelData, 3, 2));

                // Compare the last positions and call an event if needed
                for (var i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i] && buttonsLast[i] == false)
                    {
                        RaiseEvent(JogButtonDown, i);
                    }

                    if (buttons[i] == false && buttonsLast[i])
                    {
                        RaiseEvent(JogButtonUp, i);
                    }
                }

                if (jogPosition != jogPositionLast)
                {
                    RaiseEvent(JogPositionChanged, jogPosition);
                }

                if (shuttlePosition != shuttlePositionLast)
                {
                    RaiseEvent(ShuttlePositionChanged, shuttlePosition);
                }
            }
// ReSharper disable FunctionNeverReturns
        }
// ReSharper restore FunctionNeverReturns
    }
}
