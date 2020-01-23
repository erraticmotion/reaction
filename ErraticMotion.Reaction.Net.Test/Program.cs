namespace ErraticMotion.Reaction.Net.Test
{
    using System;
    using System.IO.Ports;
    using System.Threading;
    using System.Usb;

    using GHIElectronics.NETMF.USBHost;

    public class Program
    {
        static UsbShuttlePro jogger;
        static UsbDrive usbDrive;
        static IEmvPedConnection port;

        public static void Main()
        {
            usbDrive = UsbDrive.Instance;
            usbDrive.MediaInserted += (sender, e) =>
                { 
                    Console.WriteLine("Storage \"" + e.Result.Name + "\" inserted");
                    Console.WriteLine("Root directory " + e.Result.RootDirectory);
                    Console.WriteLine("Total size: " + e.Result.TotalSize + " bytes");
                    Console.WriteLine("Total free space: " + e.Result.TotalFreeSpace + " bytes");
                };

            usbDrive.MediaEjected += (sender, e) => Console.WriteLine("Storage \"" + e.Result.Name + "\" ejected");

            USBHostController.DeviceConnectedEvent += UsbHostControllerDeviceConnectedEvent;

            try
            {
                const byte i = 255;
                var d1 = Base16(i / 16);
                var d2 = Base16(i % 16);
                Console.WriteLine("0x" + d1 + d2);
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message); 
            }

            Thread.Sleep(Timeout.Infinite);
        }

        static string Base16(byte value)
        {
            switch (value)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return value.ToString();
            }
        }

        // USB Device Connected Event
        static void UsbHostControllerDeviceConnectedEvent(USBH_Device device)
        {
            Console.WriteLine("Device connected...");
            Console.WriteLine("ID: " + device.ID + ", Interface: " + device.INTERFACE_INDEX + ", Type: " + device.TYPE);

            if (device.TYPE == USBH_DeviceType.MassStorage)
            {
                Console.WriteLine("USB Mass Storage detected...");
                Console.WriteLine("Mounting file system");
                usbDrive.Mount(device);
            }

            if (device.TYPE == USBH_DeviceType.HID)
            {
                Console.WriteLine("New USB HID Connected");
                if (device.VENDOR_ID == 2867 && device.PRODUCT_ID == 16)
                {
                    Console.WriteLine("Jog wheel connected.");
                    jogger = new UsbShuttlePro(device);
                    jogger.JogButtonDown += b =>
                    {
                        Console.WriteLine("Button+ " + b);
                        if (b == 0)
                        {
                            Console.WriteLine("Creating and opening port to device");
                            port = EmvPedConnection.Factory.Create(new PedEndpointAddress());
                            port.Diagnostics += (sender, e) => Console.WriteLine(e);
                            port.DataReceived += (sender, e) => Console.WriteLine(e.Length);
                            port.DataSent += (sender, e) => Console.WriteLine(e.Length);
                            port.Open();
                        }

                        if (b == 1)
                        {
                            Console.WriteLine("Sending in a reset command");
                            try
                            {
                                var reset = new byte[] { 0x01, 0x00, 0x04, 0xD0, 0x00, 0x00, 0x01, 0xD4 };
                                port.Send(reset);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

                        if (b == 2)
                        {
                            Console.WriteLine("Disposing of port to device");
                            port.Dispose();
                        }
                    };

                    jogger.JogButtonUp += e => Console.WriteLine("Button- " + e);
                    jogger.JogPositionChanged += e => Console.WriteLine("Jog: " + e);
                    jogger.ShuttlePositionChanged += e => Console.WriteLine("Shuttle: " + e);
                }
            }
        }
    }

    public class PedEndpointAddress : IPedEndpointAddress
    {
        public PedEndpointAddress()
        {
            AddressType = PedEndpointAddressType.Tcp;
            SerialPortConnectionConfiguration = new SerialPortConnectionConfiguration();
            TcpConnectionConfiguration = new TcpConnectionConfiguration();
        }

        #region Implementation of IPedEndpointAddress

        /// <summary>
        /// 
        /// </summary>
        public PedEndpointAddressType AddressType { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ISerialPortConnectionConfiguration SerialPortConnectionConfiguration { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ITcpConnectionConfiguration TcpConnectionConfiguration { get; private set; }

        #endregion
    }

    public class TcpConnectionConfiguration : ITcpConnectionConfiguration
    {
        public TcpConnectionConfiguration()
        {
            HostName = "192.168.0.50";
            Port = 16107;
        }

        #region Implementation of ITcpConnectionConfiguration

        /// <summary>
        /// 
        /// </summary>
        public string HostName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int Port { get; private set; }

        #endregion
    }

    public class SerialPortConnectionConfiguration : ISerialPortConnectionConfiguration
    {
        public SerialPortConnectionConfiguration()
        {
            ComPort = "COM3";
            BaudRate = 57600;
            Parity = Parity.None;
            DataBits = 8;
            StopBits = StopBits.One;
            Handshake = Handshake.None;
        }

        #region Implementation of ISerialPortConnectionConfiguration

        /// <summary>
        /// The com port.
        /// </summary>
        public string ComPort { get; private set; }

        /// <summary>
        /// The baud rate.
        /// </summary>
        public int BaudRate { get; private set; }

        /// <summary>
        /// The parity.
        /// </summary>
        public Parity Parity { get; private set; }

        /// <summary>
        /// The data bits.
        /// </summary>
        public int DataBits { get; private set; }

        /// <summary>
        /// The stop bits.
        /// </summary>
        public StopBits StopBits { get; private set; }

        /// <summary>
        /// The handshake.
        /// </summary>
        public Handshake Handshake { get; private set; }

        #endregion
    }
}
