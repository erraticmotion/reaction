namespace ErraticMotion.Reaction.Net
{
    using System;
    using System.IO;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EmvPedConnection : IEmvPedConnection
    {
        /// <summary>
        /// 
        /// </summary>
        public static IEmvPedConnectionFactory Factory { get { return EmvPedConnectionFactory.Instance; } }

        private readonly INativeConnection connection;
        private bool disposed;
        private Thread monitor;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmvPedConnection"/> class.
        /// </summary>
        internal EmvPedConnection(ISerialPortConnectionConfiguration configuration)
            : this(new NativeSerialPortWrapper(configuration))
        {
        }

        internal EmvPedConnection(ITcpConnectionConfiguration configuration)
            : this(new NativeTcpClientWrapper(configuration))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmvPedConnection"/> class.
        /// </summary>
        /// <param name="connection"></param>
        internal EmvPedConnection(INativeConnection connection)
        {
            this.connection = connection;
        }

        /// <summary>
        /// Opens the connection to the device.
        /// </summary>
        public void Open()
        {
            if (disposed)
                throw new ObjectDisposedException("port");

            if (IsOpen) return;

            if (!connection.IsOpen)
            {
                try
                {
                    OnDiagnostics("Opening connection " + connection.Configuration);
                    connection.Open();
                }
                catch (Exception ex)
                {
                    OnDiagnostics("Connection exception: " + ex.Message);
                    return;
                }
            }

            monitor = new Thread(MonitorDevice);
            monitor.Start();
            IsOpen = true;
        }

        /// <summary>
        /// Returns <c>true</c> if the connection to the device is open; otherwise <c>false</c>.
        /// </summary>
        public bool IsOpen { get; private set; }

        /// <summary>
        /// Sends a command to the device.
        /// </summary>
        /// <remarks>
        /// Will throw an <see cref="InvalidOperationException"/> if the object is in a faulted state.
        /// </remarks>
        public void Send(byte[] command)
        {
            Open();
            OnDiagnostics("Sending on connection " + connection.Configuration);
            OnDataSent(command);
            connection.Write(command);
        }

        /// <summary>
        /// 
        /// </summary>
        public event MemoryStreamHandler DataReceived;

        private void OnDataReceived(MemoryStream item)
        {
            var ev = DataReceived;
            if (ev != null)
            {
                ev(this, item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public event MemoryStreamHandler DataSent;

        private void OnDataSent(byte[] item)
        {
            var ev = DataSent;
            if (ev != null)
            {
                ev(this, new MemoryStream(item));
            }
        }

        /// <summary>
        /// Is raised when the object has diagnostic information to broadcast
        /// </summary>
        public event DiagnosticsHandler Diagnostics;

        private void OnDiagnostics(string value)
        {
            var ev = Diagnostics;
            if (ev != null)
            {
                ev(this, value);
            }
        }

        private void MonitorDevice()
        {
            var stream = new EmvMemoryStream();

            Thread.Sleep(200);
            while (!disposed)
            {
                if (connection.IsOpen && connection.BytesToRead > 0)
                {
                    var btr = connection.BytesToRead;
                    var buffer = new byte[btr];
                    connection.Read(buffer, 0, btr);

                    foreach (var b in buffer)
                    {
                        stream.WriteByte(b);
                        if (!stream.IsComplete)
                        {
                            continue;
                        }

                        OnDataReceived(stream);
                        stream = new EmvMemoryStream();
                    }

                }
                Thread.Sleep(1000);
            }
        }

        #region Implementation of IDisposable

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (connection.IsOpen)
                    {
                        connection.Close();
                    }
                    connection.Dispose();
                    disposed = true;
                    IsOpen = false;
                }
            }
        }

        #endregion
    }
}
