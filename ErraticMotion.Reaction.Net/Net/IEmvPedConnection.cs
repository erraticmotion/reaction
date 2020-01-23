namespace ErraticMotion.Reaction.Net
{
    using System;

    public interface IEmvPedConnection : IDisposable
    {
        /// <summary>
        /// Opens the connection to the attached device and optionally, starts monitoring the device for responses
        /// </summary>
        void Open();

        /// <summary>
        /// Returns <c>true</c> if the connection to the device is open; otherwise <c>false</c>.
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// Sends a command to the device.
        /// </summary>
        /// <remarks>
        /// Will throw an <see cref="InvalidOperationException"/> if the object is in a faulted state.
        /// </remarks>
        void Send(byte[] command);

        /// <summary>
        /// Is raised when the object receives a command to send to the device.
        /// </summary>
        event MemoryStreamHandler DataSent;

        /// <summary>
        /// Is raised when a connected device returns information.
        /// </summary>
        event MemoryStreamHandler DataReceived;

        /// <summary>
        /// Is raised when diagnostic information is available.
        /// </summary>
        event DiagnosticsHandler Diagnostics;
    }
}