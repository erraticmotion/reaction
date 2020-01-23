namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// EMV 9B
    /// </summary>
    public sealed class TransactionStatusInformation : EmvElement
    {
        /// <summary>
        /// 
        /// </summary>
        public static EmvQuery<TransactionStatusInformation> Query()
        {
            return new TransactionStatusInformationQuery();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionStatusInformation"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public TransactionStatusInformation(byte[] value)
            : base(TagLengthValueType.TransactionStatusInformation, value)
        {
            if (value.Length != 2)
            {
                throw new ArgumentOutOfRangeException("value", "TSI value was not 2 in length");
            }

            var bits = new BitArray(new[] { value[0] });
            if (bits[7]) Results |= TransactionStatusInformationMeaning.OfflineDataAuthenticationWasPerformed;
            if (bits[6]) Results |= TransactionStatusInformationMeaning.CardholderVerificationWasPerformed;
            if (bits[5]) Results |= TransactionStatusInformationMeaning.CardRiskManagementWasPerformed;
            if (bits[4]) Results |= TransactionStatusInformationMeaning.IssuerAuthenticationWasPerformed;
            if (bits[3]) Results |= TransactionStatusInformationMeaning.TerminalRiskManagementWasPerformed;
            if (bits[2]) Results |= TransactionStatusInformationMeaning.ScriptProcessingWasPerformed;
        }

        /// <summary>
        /// Gets the TSI results
        /// </summary>
        public TransactionStatusInformationMeaning Results { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public TransactionStatusInformation SetOn(TransactionStatusInformationMeaning value)
        {
            if ((Results & value) == value)
            {
                return new TransactionStatusInformation(Value);
            }

            var b = new byte[2];
            Array.Copy(Value, b, 2);
            var bits = new BitArray(new[] { b[0] });
            switch (value)
            {
                case TransactionStatusInformationMeaning.ScriptProcessingWasPerformed:
                    bits.Set(2, true);
                    break;
                case TransactionStatusInformationMeaning.TerminalRiskManagementWasPerformed:
                    bits.Set(3, true);
                    break;
                case TransactionStatusInformationMeaning.IssuerAuthenticationWasPerformed:
                    bits.Set(4, true);
                    break;
                case TransactionStatusInformationMeaning.CardRiskManagementWasPerformed:
                    bits.Set(5, true);
                    break;
                case TransactionStatusInformationMeaning.CardholderVerificationWasPerformed:
                    bits.Set(6, true);
                    break;
                case TransactionStatusInformationMeaning.OfflineDataAuthenticationWasPerformed:
                    bits.Set(7, true);
                    break;
            }

            b[0] = bits.ToByte();
            return new TransactionStatusInformation(b);
        }

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
            var builder = new StringBuilder();
            Results.ToString().Split(',').ForEach(x => builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "TSI -> {0}", x.Trim())));
            return builder.ToString();
        }
    }
}
