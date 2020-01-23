namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public sealed class LanguagePreferencePriority : IEquatable<LanguagePreferencePriority>
    {
        /// <summary>
        /// 
        /// </summary>
        public static readonly LanguagePreferencePriority First = new LanguagePreferencePriority(1, "1st");

        /// <summary>
        /// 
        /// </summary>
        public static readonly LanguagePreferencePriority Second = new LanguagePreferencePriority(2, "2nd");

        /// <summary>
        /// 
        /// </summary>
        public static readonly LanguagePreferencePriority Third = new LanguagePreferencePriority(3, "3rd");

        /// <summary>
        /// 
        /// </summary>
        public static readonly LanguagePreferencePriority Fourth = new LanguagePreferencePriority(4, "4th");

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePreferencePriority"/> class.
        /// </summary>
        /// <param name="priority">The priority.</param>
        /// <param name="name">The name.</param>
        private LanguagePreferencePriority(int priority, string name)
        {
            Priority = priority;
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Priority { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.
        ///                 </param>
        public bool Equals(LanguagePreferencePriority other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.Priority == Priority;
        }

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. 
        ///                 </param><exception cref="T:System.NullReferenceException">The <paramref name="obj"/> parameter is null.
        ///                 </exception><filterpriority>2</filterpriority>
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
            if (obj.GetType() != typeof(LanguagePreferencePriority))
            {
                return false;
            }
            return Equals((LanguagePreferencePriority)obj);
        }

        /// <summary>
        /// Serves as a hash function for a particular type. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override int GetHashCode()
        {
            return Priority;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(LanguagePreferencePriority left, LanguagePreferencePriority right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(LanguagePreferencePriority left, LanguagePreferencePriority right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return Name;
        }
    }
}
