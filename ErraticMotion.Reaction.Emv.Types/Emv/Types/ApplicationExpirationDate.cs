namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ApplicationExpirationDate : ApplicationDateBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ApplicationExpirationDate Parse(byte[] value)
        {
            return new ApplicationExpirationDate(value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool TryParse(byte[] value, out ApplicationExpirationDate item)
        {
            try
            {
                item = new ApplicationExpirationDate(value);
                return true;
            }
            catch (Exception)
            {
                item = null;
                return false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationExpirationDate"/> class.
        /// </summary>
        /// <param name="value">The TLV value</param>
        public ApplicationExpirationDate(byte[] value)
            : base(TagLengthValueType.ApplicationExpirationDate, value)
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
