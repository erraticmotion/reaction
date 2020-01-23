namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Acts a s a base class for EMV Types that have a correspondingTag Length Value (TLV).
    /// </summary>
    public abstract class EmvElement : IEmvElement, IEquatable<EmvElement>
    {
        /// <summary>
        /// Gets a Factory to create sub-types of the <see cref="EmvElement"/> type.
        /// </summary>
        public static IEmvElementFactory Factory
        {
            get { return new EmvElementFactory(); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmvElement"/> class.
        /// </summary>
        /// <param name="tag">The TLV.</param>
        /// <param name="value">The TLV value</param>
        protected EmvElement(TagLengthValueType tag, byte[] value)
        {
            Tag = tag;
            Value = value;
        }

        /// <summary>
        /// Gets the <see cref="TagLengthValueType"/>.
        /// </summary>
        /// <value>The tag.</value>
        public TagLengthValueType Tag { get; private set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public byte[] Value { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Accept(IEmvElementVisitor visitor);

        /// <summary>
        /// Reads the language command byte array that is sent to the connected device.
        /// </summary>
        /// <returns></returns>
        public virtual byte[] ReadLanguage()
        {
            var s = new MemoryStream();
            s.Write(Tag.RawValue().ToArray(), 0, Tag.Length());
            s.WriteByte((byte)Value.Length);
            s.Write(Value, 0, Value.Length);
            return s.ToArray();
        }

        #region IEquatable<EmvTypeBase>

        /// <summary>
        /// Determines whether the specified <see cref="EmvElement"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="EmvElement"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="EmvElement"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="other"/> parameter is null.
        /// </exception>
        public bool Equals(EmvElement other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(other.Tag, Tag);
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

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != typeof(EmvElement))
            {
                return false;
            }

            return Equals((EmvElement)obj);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return Tag.GetHashCode();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(EmvElement left, EmvElement right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(EmvElement left, EmvElement right)
        {
            return !Equals(left, right);
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
                builder.AppendLine(Format("Value", Encoding.ASCII.GetString(Value)));
            }
            OnToString(builder);
            return builder.ToString();
        }

        /// <summary>
        /// Common formatter
        /// </summary>
        protected static Func<string, object, string> Format = (n, x) => string.Format(CultureInfo.InvariantCulture, "{0,45}: {1}", n, x);

        /// <summary>
        /// To be overridden by derived types to add any extra properties to the <see cref="ToString"/> method.
        /// </summary>
        /// <param name="builder"></param>
        protected virtual void OnToString(StringBuilder builder)
        {
            
        }
    }
}
