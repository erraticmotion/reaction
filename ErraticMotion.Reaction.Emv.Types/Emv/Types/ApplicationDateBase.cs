namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public abstract class ApplicationDateBase : EmvElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDateBase"/> class.
        /// </summary>
        /// <param name="tag">The TLV.</param>
        /// <param name="value">The TLV value</param>
        protected ApplicationDateBase(TagLengthValueType tag, byte[] value)
            : base(tag, value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "Application date values was null.");
            }

            if (value.Length != 3)
            {
                throw new ArgumentOutOfRangeException("value", "Application date values was not 3 in length.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DateTime ToDateTime()
        {
            var y = Value[0].FromBcd();
            y += (y < 50) ? 2000 : 1900;
            var m = Value[1].FromBcd();
            var d = Value[2].FromBcd();
            return new DateTime(y, m, d);
        }
    }
}
