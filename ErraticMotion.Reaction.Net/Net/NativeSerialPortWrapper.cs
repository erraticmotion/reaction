namespace ErraticMotion.Reaction.Net
{
    using System.IO.Ports;
    using System.Threading;

    /// <summary>
    /// Acts as a wrapper around the <see cref="SerialPort"/> object so that this type implements the <see cref="INativeConnection"/>
    /// interface.
    /// </summary>
    /// <remarks>
    /// This wrapper should do nothing other than delegate to the actual <see cref="SerialPort"/> implementation.
    /// </remarks>
    internal class NativeSerialPortWrapper : INativeConnection
    {
        private readonly SerialPort port;

        /// <summary>
        /// Initializes a new instance of the <see cref="NativeSerialPortWrapper"/> class.
        /// </summary>
        /// <param name="config">The configuration settings.</param>
        public NativeSerialPortWrapper(ISerialPortConnectionConfiguration config)
        {
            Configuration = "Com Port: " + config.ComPort;
            port = new SerialPort(config.ComPort)
            {
                Handshake = config.Handshake,
                BaudRate = config.BaudRate,
                Parity = config.Parity,
                DataBits = config.DataBits,
                StopBits = config.StopBits,
            };
        }

        #region Implementation of IConnection

        public void Write(byte[] command)
        {
            port.Write(command, 0, command.Length);
        }

        public void Open()
        {
            // force a half second delay because a com port handle doesn't go back to the system immediately after released by others
            Thread.Sleep(500);
            port.Open();
        }

        public bool IsOpen
        {
            get { return port.IsOpen; }
        }

        public void Close()
        {
            port.Close();
        }

        public int BytesToRead
        {
            get { return port.BytesToRead; }
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            return port.Read(buffer, offset, count);
        }

        public byte[] Read(int count)
        {
            var buffer = new byte[count];
            port.Read(buffer, 0, count);
            return buffer;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Configuration { get; private set; }

        #endregion

        #region Implementation of IDisposable

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            port.Dispose();
        }

        #endregion
    }
}
