namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Text;

    /// <summary>
    /// EMV Tag 0x5F56
    /// </summary>
    public sealed class IssuerCountryCodeAlpha3 : EmvElement, IEquatable<IssuerCountryCodeAlpha3>
    {
        /// <summary>
        /// Specific label required to match Canadian VISA debit cards.
        /// </summary>
        /// 
        public static readonly IssuerCountryCodeAlpha3 Canada 
            = new IssuerCountryCodeAlpha3(new byte[] { 0x43, 0x41, 0x4E });

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuerCountryCodeAlpha3"/> class.
        /// </summary>
        /// <param name="value">The TLV value</param>
        public IssuerCountryCodeAlpha3(byte[] value)
            : base(TagLengthValueType.ApplicationLabel, value)
        {
            if (value != null && value.Length > 0)
            {
                Label = Encoding.ASCII.GetString(value);
            }
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <value>The label.</value>
        public string Label { get; private set; }

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

        #region IEquatable<IssuerCountryCodeAlpha3>

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.
        ///                 </param>
        public bool Equals(IssuerCountryCodeAlpha3 other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return base.Equals(other) && Equals(other.Label, Label);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return ReferenceEquals(this, obj) || Equals(obj as IssuerCountryCodeAlpha3);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ (Label != null ? Label.GetHashCode() : 0);
            }
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(IssuerCountryCodeAlpha3 left, IssuerCountryCodeAlpha3 right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(IssuerCountryCodeAlpha3 left, IssuerCountryCodeAlpha3 right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}
