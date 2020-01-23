namespace ErraticMotion.Reaction.Net
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEmvPedConnectionFactory
    {
        /// <summary>
        /// Creates a <see cref="IEmvPedConnection"/> object based on the <paramref name="address"/>
        /// </summary>
        /// <param name="address">The address information to the device</param>
        /// <returns>An object that supports the <see cref="IEmvPedConnection"/> interface.</returns>
        IEmvPedConnection Create(IPedEndpointAddress address);
    }
}