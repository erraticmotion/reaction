namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CardholderVerificationRule : IEquatable<CardholderVerificationRule>, ICvmSupport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardholderVerificationRule"/> class.
        /// </summary>
        /// <param name="b1">The b1.</param>
        internal CardholderVerificationRule(byte b1)
        {
            Byte1 = b1;

            if (b1 == 0x3f)
            {
                Meaning = CardholderVerificationRuleMeaning.NoCvmHasBeenPerformed;
                return;
            }

            var ba = new BitArray(new[] { Byte1 });
            if (ba[6])
            {
                Meaning |= CardholderVerificationRuleMeaning.ApplySucceeding;
            }
            else
            {
                Meaning |= CardholderVerificationRuleMeaning.FailIfUnsuccessful;
            }

            ba[6] = false;
            switch (ba.ToByte())
            {
                case 0:
                    Meaning |= CardholderVerificationRuleMeaning.FailCvmProcessing;
                    break;
                case 1:
                    Meaning |= CardholderVerificationRuleMeaning.PlaintextPinVerificationPerformedByIcc;
                    break;
                case 2:
                    Meaning |= CardholderVerificationRuleMeaning.EncipheredPinVerifiedOnline;
                    break;
                case 3:
                    Meaning |= CardholderVerificationRuleMeaning.PlaintextPinVerificationPerformedByIccAndSignature;
                    break;
                case 4:
                    Meaning |= CardholderVerificationRuleMeaning.EncipheredPinVerificationPerformedByIcc;
                    break;
                case 5:
                    Meaning |= CardholderVerificationRuleMeaning.EncipheredPinVerificationPerformedByIccAndSignature;
                    break;
                case 30:
                    Meaning |= CardholderVerificationRuleMeaning.Signature;
                    break;
                case 31:
                    Meaning |= CardholderVerificationRuleMeaning.NoCvmRequired;
                    break;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardholderVerificationRule"/> class.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="b2">The b2.</param>
        internal CardholderVerificationRule(byte b1, byte b2)
            : this(new List<byte> { b1, b2 })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardholderVerificationRule"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        internal CardholderVerificationRule(IList<byte> item)
            : this(item[0])
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            if (item.Count != 2)
            {
                throw new ArgumentOutOfRangeException("item", "Cardholder Verification Rule ctor:: item.length was not 2");
            }

            Byte2 = item[1];
            ConditionCode = (CardholderVerificationRuleConditionCode)Byte2;
        }

        /// <summary>
        /// 
        /// </summary>
        public byte Byte1 { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public byte Byte2 { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public CardholderVerificationRuleMeaning Meaning { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public CardholderVerificationRuleConditionCode ConditionCode { get; private set; }

        #region Implementation of ICvmSupport

        /// <summary>
        /// Indicates whether the object supports Online PIN operations
        /// </summary>
        public bool EncipheredPinVerificationOnline
        {
            get
            {
                return ((Meaning & CardholderVerificationRuleMeaning.EncipheredPinVerifiedOnline) 
                    == CardholderVerificationRuleMeaning.EncipheredPinVerifiedOnline);
            }
        }

        /// <summary>
        /// Indicates whether the object supports normal PIN operations.
        /// </summary>
        public bool PlaintextPinVerificationPerformedByIcc
        {
            get
            {
                return ((Meaning & CardholderVerificationRuleMeaning.PlaintextPinVerificationPerformedByIcc)
                    == CardholderVerificationRuleMeaning.PlaintextPinVerificationPerformedByIcc);
            }
        }

        #endregion

        #region IEquatable<CardholderVerificationRule>

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.
        ///                 </param>
        public bool Equals(CardholderVerificationRule other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return other.Byte1 == Byte1 && other.Byte2 == Byte2;
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

            return obj is CardholderVerificationRule && Equals((CardholderVerificationRule)obj);
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
            unchecked
            {
                return (Byte1.GetHashCode() * 397) ^ Byte2.GetHashCode();
            }
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(CardholderVerificationRule left, CardholderVerificationRule right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(CardholderVerificationRule left, CardholderVerificationRule right)
        {
            return !Equals(left, right);
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
            return string.Format(CultureInfo.InvariantCulture, "Meaning {0}, Condition Code {1}", Meaning, ConditionCode);
        }

        #endregion
    }
}
