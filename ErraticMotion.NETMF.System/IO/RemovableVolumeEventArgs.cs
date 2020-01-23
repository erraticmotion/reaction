namespace System.IO
{
    using Microsoft.SPOT;
    using Microsoft.SPOT.IO;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RemovableVolumeEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovableVolumeEventArgs"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        public RemovableVolumeEventArgs(VolumeInfo item)
        {
            Result = item;
        }

        /// <summary>
        /// 
        /// </summary>
        public VolumeInfo Result { get; private set; }
    }
}
