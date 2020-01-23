namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 0x8E
    /// </summary>
    /// <remarks>
    /// The CVM List (tag '8E') is a composite data object consisting of the following:
    /// 1. An amount field (4 bytes, binary format), referred to as ‗X‘ in Table 40: CVM Condition Codes. ‗X‘ is expressed 
    /// in the Application Currency Code with implicit decimal point. For example, 123 (hexadecimal '7B') represents £1.23 
    /// when the currency code is '826'.
    /// 2. A second amount field (4 bytes, binary format), referred to as ‗Y‘ in Table 40. ‗Y‘ is expressed in Application 
    /// Currency Code with implicit decimal point. For example, 123 (hexadecimal '7B') represents £1.23 when the currency code is '826'.
    /// 3. A variable-length list of two-byte data elements called Cardholder Verification Rules (CV Rules). Each CV Rule 
    /// describes a CVM and the conditions under which that CVM should be applied (see Annex C3).
    /// </remarks>
    public sealed class CvmList : EmvElement
    {
        /// <summary>
        /// 
        /// </summary>
        public static EmvQuery<CvmList> Query()
        {
            return new CvmListQuery();
        }

        private readonly Dictionary<int, CardholderVerificationRule> cvmMethods;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmvElement"/> class.
        /// </summary>
        /// <param name="value">The TLV value</param>
        public CvmList(byte[] value)
            : base(TagLengthValueType.CvmList, value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            AmountX = new byte[4];
            AmountY = new byte[4];

            if (value.Length > 4)
            {
                Array.Copy(value, 0, AmountX, 0, 4);
            }

            if (value.Length < 8)
                return;
            
            
            Array.Copy(value, 4, AmountY, 0, 4);

            var ruleLength = value.Length - 8;
            if (ruleLength == 0)
                return;

            if (ruleLength.IsOdd())
                return;

            var rules = new byte[ruleLength];
            Array.Copy(value, 8, rules, 0, ruleLength);
            cvmMethods = new Dictionary<int, CardholderVerificationRule>();

            rules.Chunk(2).ForIndex((i,x) => cvmMethods.Add(i, new CardholderVerificationRule(x)));
            CardholderVerificationRules = new ReadOnlyCollection<CardholderVerificationRule>(cvmMethods.Values.ToArray());
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] AmountX { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public byte[] AmountY { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public ReadOnlyCollection<CardholderVerificationRule> CardholderVerificationRules { get; private set; }

        /// <summary>
        /// Indicates whether the object supports Online PIN operations
        /// </summary>
        public bool EncipheredPinVerificationOnlinePreferredIfSupported
        {
            get
            {
                // What we want to know is if 'EncipheredPinVerifiedOnline' is the first supported CVM method.
                // If it does then go for Online PIN. Not technically correct for CVM processing, but will do for now until get time to
                // code it correctly
                var onlinePin = cvmMethods.Where(x => x.Value.EncipheredPinVerificationOnline).ToArray();
                if (!onlinePin.Any())
                {
                    return false;
                }

                var onlinePinPriority = onlinePin.ElementAt(0).Key;

                var normalPin = cvmMethods.Where(x => x.Value.PlaintextPinVerificationPerformedByIcc).ToArray();
                if (!normalPin.Any())
                {
                    return true;
                }

                var normalPinPosition = normalPin.ElementAt(0).Key;

                return onlinePinPriority < normalPinPosition;
            }
        }

        #region Overrides of EmvElement

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0}", GetType().Name));
            builder.AppendLine(Format("Tag", Tag));
            if (Value != null)
            {
                builder.AppendLine(Format("Value", Value.DefaultDecoder()));
                builder.AppendLine(Format("AmountX", AmountX.DefaultDecoder()));
                builder.AppendLine(Format("AmountY", AmountY.DefaultDecoder()));
                builder.AppendLine(Format("CVM Rules", ""));
                CardholderVerificationRules.ForIndex((i, x) => builder.AppendLine(Format(i.ToString(CultureInfo.InvariantCulture), x)));
            }
            
            return builder.ToString();
        }
    }
}
