namespace System.Drivers
{
    using System;
    using System.Collections;
    using System.Threading;
    using Microsoft.SPOT;
    using Microsoft.SPOT.Hardware;
    using GHI.Premium.USBHost;

    /// <summary>
    /// 
    /// </summary>
    public class ShuttlePro
    {
        // Events
        public delegate void jogButtonDown(int button);
        public delegate void jogButtonUp(int button);
        public delegate void shuttlePosition_Changed(int value);
        public delegate void jogPosition_Changed(int value);

        public event jogButtonDown JogButtonDown;
        public event jogButtonUp JogButtonUp;
        public event shuttlePosition_Changed ShuttlePosition_Changed;
        public event jogPosition_Changed JogPosition_Changed;

        // USB handles to the device
        USBH_RawDevice jogWheel;
        USBH_RawDevice.Pipe jogWheel_Pipe;

        // Listener Thread
        Thread jogWheel_Thread;

        // Positions for current read
        BitArray buttons = new BitArray(16, false);
        int shuttlePosition = 0;
        int jogPosition = 0;

        // Positions at last read
        BitArray buttons_Last;
        int shuttlePosition_Last;
        int jogPosition_Last;
    }
}
