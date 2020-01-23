namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// EMV 5F245
    /// </summary>
    public sealed class ApplicationEffectiveDate : ApplicationDateBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ApplicationEffectiveDate Parse(byte[] value)
        {
            return new ApplicationEffectiveDate(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool TryParse(byte[] value, out ApplicationEffectiveDate item)
        {
            try
            {
                item = new ApplicationEffectiveDate(value);
                return true;
            }
            catch(Exception)
            {
                item = null;
                return false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationEffectiveDate"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ApplicationEffectiveDate(byte[] value)
            : base(TagLengthValueType.ApplicationEffectiveDate, value)
        {
            
        }

        /// <summary>
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
