namespace ErraticMotion.Reaction.Net
{
    using System;

    internal class EmvPedConnectionFactory : IEmvPedConnectionFactory
    {
        public static readonly IEmvPedConnectionFactory Instance = new EmvPedConnectionFactory();

        #region Implementation of IEmvPedConnectionFactory

        /// <summary>
        /// Creates a <see cref="IEmvPedConnection"/> object based on the <paramref name="address"/>
        /// </summary>
        /// <param name="address">The address information to the device</param>
        /// <returns>An object that supports the <see cref="IEmvPedConnection"/> interface.</returns>
        public IEmvPedConnection Create(IPedEndpointAddress address)
        {
            IEmvPedConnection result = null;

            if (address.AddressType == PedEndpointAddressType.Serial)
            {
                var serialPortConfiguration = address.SerialPortConnectionConfiguration;
                if (serialPortConfiguration == null)
                {
                    throw new Exception("No serial port connection configuration.");
                }

                result = new EmvPedConnection(serialPortConfiguration);
            }

            if (address.AddressType == PedEndpointAddressType.Tcp)
            {
                var tcpConfiguration = address.TcpConnectionConfiguration;
                if (tcpConfiguration == null)
                {
                    throw new Exception("No TCP connection configuration.");
                }

                result = new EmvPedConnection(tcpConfiguration);
            }

            if (result == null)
            {
                throw new InvalidOperationException("No PED connection can be created out of the endpoint address settings.");
            }

            return result;
        }

        #endregion
    }
}
