namespace ErraticMotion.Reaction.Net
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    internal interface INativeConnection : IDisposable
    {
        /// <summary>
        /// Writes the command to the connection object.
        /// </summary>
        /// <param name="command"></param>
        void Write(byte[] command);

        /// <summary>
        /// Opens the connection
        /// </summary>
        void Open();

        /// <summary>
        /// Indicates whether this connection is open.
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// Closes the connection
        /// </summary>
        void Close();

        /// <summary>
        /// Indicates the number of bytes to read from the connection.
        /// </summary>
        int BytesToRead { get; }

        /// <summary>
        /// Reads the bytes from the connection into the buffer
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        int Read(byte[] buffer, int offset, int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        byte[] Read(int count);

        /// <summary>
        /// 
        /// </summary>
        string Configuration { get; }
    }
}