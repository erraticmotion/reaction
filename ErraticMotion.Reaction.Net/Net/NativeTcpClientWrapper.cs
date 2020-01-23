namespace ErraticMotion.Reaction.Net
{
    using System.Net;
    using System.Net.Sockets;

    internal class NativeTcpClientWrapper : INativeConnection
    {
        private Socket socket;
        private bool connected;
        private readonly ITcpConnectionConfiguration configuration;

        public NativeTcpClientWrapper(ITcpConnectionConfiguration configuration)
        {
            Configuration = "Host name: " + configuration.HostName + " Port: " + configuration.Port;
            this.configuration = configuration;
        }

        #region Implementation of IDisposable

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
        }

        #endregion

        #region Implementation of INativeConnection

        /// <summary>
        /// Writes the command to the connection object.
        /// </summary>
        /// <param name="command"></param>
        public void Write(byte[] command)
        {
            socket.Send(command);
        }

        /// <summary>
        /// Opens the connection
        /// </summary>
        public void Open()
        {
            var hostEntry = Dns.GetHostEntry(configuration.HostName);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(new IPEndPoint(hostEntry.AddressList[0], configuration.Port));
            connected = true;
        }

        /// <summary>
        /// Indicates whether this connection is open.
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return connected;
            }
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        public void Close()
        {
            socket.Close();
        }

        /// <summary>
        /// Indicates the number of bytes to read from the connection.
        /// </summary>
        public int BytesToRead
        {
            get
            {
                return socket.Available;
            }
        }

        /// <summary>
        /// Reads the bytes from the connection into the buffer
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public int Read(byte[] buffer, int offset, int count)
        {
            return socket.Receive(buffer, offset, count, SocketFlags.None);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public byte[] Read(int count)
        {
            var buffer = new byte[count];
            Read(buffer, 0, count);
            return buffer;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Configuration { get; private set; }

        #endregion
    }
}
