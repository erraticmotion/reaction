namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CvmResults : EmvElement
    {
        /// <summary>
        /// 
        /// </summary>
        public static EmvQuery<CvmResults> Query()
        {
            return new CvmResultsQuery();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmvElement"/> class.
        /// </summary>
        /// <param name="value">The TLV value</param>
        public CvmResults(byte[] value)
            : base(TagLengthValueType.CvmResults, value)
        {
            if (value.Length != 3)
            {
                throw new ArgumentOutOfRangeException("value", "CVM Results values was not 3 in length.");
            }

            CvmPerformed = new CardholderVerificationRule(value[0]).Meaning;
            if (value[1] == 0x00)
            {
                ConditionCode = CardholderVerificationRuleConditionCode.NoActualCvmWasPerformed;
            }
            else
            {
                ConditionCode = (CardholderVerificationRuleConditionCode)value[1];
            }

            CvmResult = (CvmResult)value[2];
        }

        /// <summary>
        /// Gets the last <see cref="CardholderVerificationRule"/> performed by the terminal.
        /// </summary>
        public CardholderVerificationRuleMeaning CvmPerformed { get; private set; }

        /// <summary>
        /// Gets the CVM Condition Code of the CVM List
        /// </summary>
        public CardholderVerificationRuleConditionCode ConditionCode { get; private set; }

        /// <summary>
        /// Gets the CVM result.
        /// </summary>
        /// <value>The CVM result.</value>
        public CvmResult CvmResult { get; private set; }

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

        #region Overrides of Object

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            Func<string, object, string> f = (n, o) => string.Format(CultureInfo.InvariantCulture,
                "{0,40}: " + (o is byte ? "0x{1:X2}" : "{1}"), n, o);

            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0}", GetType().Name));
            builder.AppendLine(f("CVM[0]", Value[0]));
            builder.AppendLine(f("CVM[1]", Value[1]));
            builder.AppendLine(f("CVM[2]", Value[2]));
            builder.AppendLine(f("CvmPerformed", CvmPerformed));
            builder.AppendLine(f("Condition Code", ConditionCode));
            builder.AppendLine(f("Result", CvmResult));
            return builder.ToString();
        }

        #endregion
    }
}
