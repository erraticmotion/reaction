namespace ErraticMotion.Reaction.Net
{
    public interface IPedEndpointAddress
    {
        /// <summary>
        /// 
        /// </summary>
        PedEndpointAddressType AddressType { get; }

        /// <summary>
        /// 
        /// </summary>
        ISerialPortConnectionConfiguration SerialPortConnectionConfiguration { get; }

        /// <summary>
        /// 
        /// </summary>
        ITcpConnectionConfiguration TcpConnectionConfiguration { get; }
    }
}