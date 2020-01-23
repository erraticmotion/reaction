namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// EMV Tag 82
    /// </summary>
    public sealed class ApplicationInterchangeProfile : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInterchangeProfile"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ApplicationInterchangeProfile(byte[] value)
            : base(TagLengthValueType.ApplicationInterchangeProfile, value)
        {
            if (value.Length != 2)
            {
                throw new ArgumentOutOfRangeException("value", "AIP values was not 2 in length");
            }

            var bits = new BitArray(new[] { value[0] });
            if (bits[6]) Results |= ApplicationInterchangeProfileMeaning.SdaSupported;
            if (bits[5]) Results |= ApplicationInterchangeProfileMeaning.DdaSupported;
            if (bits[4]) Results |= ApplicationInterchangeProfileMeaning.CardholderVerificationSupported;
            if (bits[3]) Results |= ApplicationInterchangeProfileMeaning.TerminalRiskManagementToBePerformed;
            if (bits[2]) Results |= ApplicationInterchangeProfileMeaning.IssuerAuthenticationIsSupported;
            if (bits[0]) Results |= ApplicationInterchangeProfileMeaning.CdaSupported;
        }

        /// <summary>
        /// Gets the results of the AIP
        /// </summary>
        public ApplicationInterchangeProfileMeaning Results { get; private set; }

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
            Results.ToString().Split(',').ForEach(x => builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "AIP -> {0}", x.Trim())));
            return builder.ToString();
        }
    }
}
