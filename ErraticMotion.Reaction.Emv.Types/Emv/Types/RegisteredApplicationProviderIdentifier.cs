namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An application identifier (AID) is used to address an application in the card. An AID consists of a 
    /// registered application provider identifier (RID) of five bytes, which is issued by the ISO/IEC 7816-5 
    /// registration authority. This is followed by a proprietary application identifier extension (PIX) which 
    /// enables the application provider to differentiate between the different applications offered.
    /// </summary>
    public sealed class RegisteredApplicationProviderIdentifier : IEquatable<RegisteredApplicationProviderIdentifier>
    {
        /// <summary>
        /// VISA
        /// </summary>
        public static readonly RegisteredApplicationProviderIdentifier Visa;

        /// <summary>
        /// Master Card
        /// </summary>
        public static readonly RegisteredApplicationProviderIdentifier MasterCard;

        /// <summary>
        /// Maestro
        /// </summary>
        public static readonly RegisteredApplicationProviderIdentifier Maestro;

        /// <summary>
        /// American Express
        /// </summary>
        public static readonly RegisteredApplicationProviderIdentifier AmericanExpress;

        /// <summary>
        /// Discover
        /// </summary>
        public static readonly RegisteredApplicationProviderIdentifier Discover;

        /// <summary>
        /// Interac - Canada
        /// </summary>
        public static readonly RegisteredApplicationProviderIdentifier Interac;

        private static readonly Dictionary<string, RidTableEntry> Rids =
            new Dictionary<string, RidTableEntry>();

        static RegisteredApplicationProviderIdentifier()
        {
            Rids["A000000003"] = new RidTableEntry("A000000003", "Visa");
            Visa = new RegisteredApplicationProviderIdentifier("A000000003");

            Rids["A000000004"] = new RidTableEntry("A000000004", "MasterCard");
            MasterCard = new RegisteredApplicationProviderIdentifier("A000000004");

            Rids["A000000005"] = new RidTableEntry("A000000005", "Maestro");
            Maestro = new RegisteredApplicationProviderIdentifier("A000000005");

            Rids["A000000025"] = new RidTableEntry("A000000025", "American Express");
            AmericanExpress = new RegisteredApplicationProviderIdentifier("A000000025");

            Rids["A000000152"] = new RidTableEntry("A000000152", "Discover");
            Discover = new RegisteredApplicationProviderIdentifier("A000000152");

            Rids["A000000277"] = new RidTableEntry("A000000277", "Interac");
            Interac = new RegisteredApplicationProviderIdentifier("A000000277");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static RegisteredApplicationProviderIdentifier From(ApplicationIdentifier item)
        {
            if (item.Aid.Length < 10)
            {
                return new RegisteredApplicationProviderIdentifier(item.Aid);
            }

            return new RegisteredApplicationProviderIdentifier(item.Aid.Substring(0, 10));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisteredApplicationProviderIdentifier"/> class.
        /// </summary>
        /// <param name="rid">The value.</param>
        private RegisteredApplicationProviderIdentifier(string rid)
        {
            if (!Rids.ContainsKey(rid))
            {
                Rid = rid;
                CardScheme = "NotRecognised";
                return;
            }

            var el = Rids[rid];
            Rid = el.Rid;
            CardScheme = el.Name;
        }

        /// <summary>
        /// Gets the card scheme.
        /// </summary>
        /// <value>The card scheme.</value>
        public string CardScheme { get; private set; }

        /// <summary>
        /// Gets the RID.
        /// </summary>
        /// <value>The RID.</value>
        public string Rid { get; private set; }

        #region IEquatable<RegisteredApplicationProviderIdentifier>

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.
        ///                 </param>
        public bool Equals(RegisteredApplicationProviderIdentifier other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            return ReferenceEquals(this, other) || Equals(other.Rid, Rid);
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

            return obj is RegisteredApplicationProviderIdentifier && Equals((RegisteredApplicationProviderIdentifier)obj);
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
            return Rid.GetHashCode();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(RegisteredApplicationProviderIdentifier left, RegisteredApplicationProviderIdentifier right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(RegisteredApplicationProviderIdentifier left, RegisteredApplicationProviderIdentifier right)
        {
            return !Equals(left, right);
        }

        #endregion

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return string.Format("{0}, CardScheme: {1}", Rid, CardScheme);
        }

        #region Private Members

        private struct RidTableEntry
        {
            internal readonly string Rid;

            internal readonly string Name;

            internal RidTableEntry(string rid, string name)
            {
                Rid = rid;
                Name = name;
            }
        }

        #endregion
    }
}
