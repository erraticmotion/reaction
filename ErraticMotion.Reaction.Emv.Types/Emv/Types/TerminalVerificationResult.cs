namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// EMV Tag 95
    /// </summary>
    public sealed class TerminalVerificationResult : EmvElement
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly TerminalVerificationResult OfflineApproval 
            = new TerminalVerificationResult(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00 });

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalVerificationResult"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public TerminalVerificationResult(byte[] value) 
            : base(TagLengthValueType.TerminalVerificationResults, value)
        {
            if (value.Length != 5)
            {
                throw new ArgumentOutOfRangeException("value", "TVR values was not 5 in length");
            }

            ByteOne = value[0];
            var bits = new BitArray(new [] { ByteOne });
            if (bits[7]) Meaning |= TerminalVerificationResultMeaning.OfflineDataAuthenticationWasNotPerformed;
            if (bits[6]) Meaning |= TerminalVerificationResultMeaning.SdaFailed;
            if (bits[5]) Meaning |= TerminalVerificationResultMeaning.IccDataMissing;
            if (bits[4]) Meaning |= TerminalVerificationResultMeaning.CardAppearsOnTerminalExceptionFile;
            if (bits[3]) Meaning |= TerminalVerificationResultMeaning.DdaFailed;
            if (bits[2]) Meaning |= TerminalVerificationResultMeaning.CdaFailed;

            ByteTwo = value[1];
            bits = new BitArray(new[] { ByteTwo });
            if (bits[7]) Meaning |= TerminalVerificationResultMeaning.IccAndTerminalHaveDifferentApplicationVersions;
            if (bits[6]) Meaning |= TerminalVerificationResultMeaning.ExpiredApplication;
            if (bits[5]) Meaning |= TerminalVerificationResultMeaning.ApplicationNotYetEffective;
            if (bits[4]) Meaning |= TerminalVerificationResultMeaning.RequestedServiceNotAllowedForCardProduct;
            if (bits[3]) Meaning |= TerminalVerificationResultMeaning.NewCard;

            ByteThree = value[2];
            bits = new BitArray(new[] { ByteThree });
            if (bits[7]) Meaning |= TerminalVerificationResultMeaning.CardholderVerificationWasNotSuccessful;
            if (bits[6]) Meaning |= TerminalVerificationResultMeaning.UnrecognisedCvm;
            if (bits[5]) Meaning |= TerminalVerificationResultMeaning.PinTryLimitExceeded;
            if (bits[4]) Meaning |= TerminalVerificationResultMeaning.PinEntryRequiredAndPinPadNotPresentOrNotWorking;
            if (bits[3]) Meaning |= TerminalVerificationResultMeaning.PinEntryRequiredPinPadPresentButPinWasNotEntered;
            if (bits[2]) Meaning |= TerminalVerificationResultMeaning.OnlinePinEntered;

            ByteFour = value[3];
            bits = new BitArray(new[] { ByteFour });
            if (bits[7]) Meaning |= TerminalVerificationResultMeaning.TransactionExceedsFloorLimit;
            if (bits[6]) Meaning |= TerminalVerificationResultMeaning.LowerConsecutiveOfflineLimitExceeded;
            if (bits[5]) Meaning |= TerminalVerificationResultMeaning.UpperConsecutiveOfflineLimitExceeded;
            if (bits[4]) Meaning |= TerminalVerificationResultMeaning.TransactionSelectedRandomlyForOnlineProcessing;
            if (bits[3]) Meaning |= TerminalVerificationResultMeaning.MerchantForcedTransactionOnline;

            ByteFive = value[4];
            bits = new BitArray(new[] { ByteFive });
            if (bits[7]) Meaning |= TerminalVerificationResultMeaning.DefaultTdolUsed;
            if (bits[6]) Meaning |= TerminalVerificationResultMeaning.IssuerAuthenticationFailed;
            if (bits[5]) Meaning |= TerminalVerificationResultMeaning.ScriptProcessingFailedBeforeFinalGenerateAc;
            if (bits[4]) Meaning |= TerminalVerificationResultMeaning.ScriptProcessingFailedAfterFinalGenerateAc;
        }

        /// <summary>
        /// Gets the results of the TVR
        /// </summary>
        public TerminalVerificationResultMeaning Meaning { get; private set; }

        /// <summary>
        /// EMV provider specific on enter PIN stage
        /// </summary>
        public bool OfflineApproved { get { return ByteFour == 0x00; } }

        /// <summary>
        /// Gets the TVR byte one.
        /// </summary>
        /// <value>The byte one.</value>
        public byte ByteOne { get; private set; }

        /// <summary>
        /// Gets the TVR byte two.
        /// </summary>
        /// <value>The byte two.</value>
        public byte ByteTwo { get; private set; }

        /// <summary>
        /// Gets the TVR byte three.
        /// </summary>
        /// <value>The byte three.</value>
        public byte ByteThree { get; private set; }

        /// <summary>
        /// Gets the TVR byte four.
        /// </summary>
        /// <value>The byte four.</value>
        public byte ByteFour { get; private set; }

        /// <summary>
        /// Gets the TVR byte five.
        /// </summary>
        /// <value>The byte five.</value>
        public byte ByteFive { get; private set; }

        /// <summary>
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            Func<string, object, string> f = (n, o) => string.Format(CultureInfo.InvariantCulture, 
                "{0,40}: " + (o is byte ? "0x{1:X2}" : "{1}"), n, o);

            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0}", GetType().Name));
            builder.AppendLine(f("TVR[0]", ByteOne));
            builder.AppendLine(f("TVR[1]", ByteTwo));
            builder.AppendLine(f("TVR[2]", ByteThree));
            builder.AppendLine(f("TVR[3]", ByteFour));
            builder.AppendLine(f("TVR[4]", ByteFive));
            Meaning.ToString().Split(',').ForEach(x => builder.AppendLine(f("TVR", x.Trim())));
            builder.AppendLine(f("Offline Approved", OfflineApproved));
            return builder.ToString();
        }
    }
}
