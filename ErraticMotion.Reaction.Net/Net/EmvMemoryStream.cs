namespace ErraticMotion.Reaction.Net
{
    using System;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    internal class EmvMemoryStream : MemoryStream
    {
        private byte currentLrc;
        private bool hasMoreMessages;

        private delegate void NextActionHandler(byte e);
        private NextActionHandler nextAction;

        private int remainingBodyLength;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmvMemoryStream"/> class.
        /// </summary>
        public EmvMemoryStream()
        {
            nextAction = OnNad;
        }

        /// <summary>
        ///   Determines whether the specified stream is complete.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the specified stream is complete; otherwise, <c>false</c>.
        /// </returns>
        public bool IsComplete { get; private set; }

        public override void WriteByte(byte value)
        {
            nextAction(value);
            currentLrc ^= value;
            base.WriteByte(value);
        }

        private void OnNad(byte nad)
        {
            nextAction = OnPcb;
        }

        private void OnPcb(byte pcb)
        {
            hasMoreMessages = (pcb & 0x01) == 0x01;
            nextAction = OnLen;
        }

        private void OnLen(byte length)
        {
            remainingBodyLength = length;
            if (remainingBodyLength == 0)
            {
                nextAction = OnLrc;
            }
            else
            {
                nextAction = OnBody;
            }
        }

        private void OnBody(byte b)
        {
            remainingBodyLength--;
            if (remainingBodyLength == 0)
            {
                nextAction = OnLrc;
            }
        }

        private void OnLrc(byte lrc)
        {
            if (lrc != currentLrc)
            {
                throw new InvalidOperationException("LRC byte expected!");
            }

            IsComplete = !hasMoreMessages;
            nextAction = OnNad;
        }
    }
}
