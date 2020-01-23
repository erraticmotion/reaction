namespace ErraticMotion.Reaction.Net
{
    using System.IO.Ports;

    public interface ISerialPortConnectionConfiguration
    {
        /// <summary>
        /// The com port.
        /// </summary>
        string ComPort { get; }

        /// <summary>
        /// The baud rate.
        /// </summary>
        int BaudRate { get; }

        /// <summary>
        /// The parity.
        /// </summary>
        Parity Parity { get; }

        /// <summary>
        /// The data bits.
        /// </summary>
        int DataBits { get; }

        /// <summary>
        /// The stop bits.
        /// </summary>
        StopBits StopBits { get; }

        /// <summary>
        /// The handshake.
        /// </summary>
        Handshake Handshake { get; }
    }
}