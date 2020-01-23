namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections;

    /// <summary>
    /// EMV Tag 9F27. Retuned on either 1st GENERATE or 2nd GENERATE
    /// The CCD-compliant application shall respond to the first GENERATE AC with any of the following cryptogram types:
    /// TC, ARQC, AAC
    /// The CCD-compliant application shall respond to the second GENERATE AC (if applicable) with either of the following cryptogram types:
    /// TC, AAC
    /// </summary>
    /// <remarks>
    /// The first 2 bits of the byte indicate the following:
    /// <list type="bullet">
    /// <item><description>0, 0  is AAC</description></item>
    /// <item><description>0, 1  isTC</description></item>
    /// <item><description>1, 0  is ARQC</description></item>
    /// </list>
    /// where
    /// <list type="table">
    /// <listheader>
    /// <term>Type</term>
    /// <term>Abbreviation</term>
    /// <term>Meaning</term>
    /// </listheader>
    /// <item>
    /// <description>Application Authentication Cryptogram</description>
    /// <description>AAC</description>
    /// <description>Transaction declined</description>
    /// </item>
    /// <item>
    /// <description>Authorisation Request Cryptogram</description>
    /// <description>ARQC</description>
    /// <description>Online authorisation requested </description>
    /// </item>
    /// <item>
    /// <description>Transaction Certificate</description>
    /// <description>TC</description>
    /// <description>Transaction approved</description>
    /// </item>
    /// </list>
    /// </remarks>
    public sealed class CryptogramInformationData : EmvElement, IEquatable<CryptogramInformationData>
    {
        /// <summary>
        /// AAC
        /// </summary>
        public static CryptogramInformationData TransactionDeclined = new CryptogramInformationData(0x00);

        /// <summary>
        /// ARQC
        /// </summary>
        public static CryptogramInformationData OnlineAuthorisationRequested = new CryptogramInformationData(0x80);

        /// <summary>
        /// TC
        /// </summary>
        public static CryptogramInformationData TransactionApproved = new CryptogramInformationData(0x40);

        /// <summary>
        /// Initializes a new instance of the <see cref="CryptogramInformationData"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public CryptogramInformationData(byte value)
            : base(TagLengthValueType.CryptogramInformationData, new [] {value})
        {
            var ba = new BitArray(new [] {value});
            if (!ba[7] && !ba[6])
            {
                Result = GenerateCryptogramType.TransactionDeclined;
            }

            if (ba[7] && !ba[6])
            {
                Result = GenerateCryptogramType.OnlineAuthorizationRequested;
            }

            if (!ba[7] && ba[6])
            {
                Result = GenerateCryptogramType.TransactionApproved;
            }

            if (ba[7] && ba[6])
            {
                throw new ArgumentOutOfRangeException("value", @"value bit 7 and 6 was set.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateCryptogramType Result { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        #region IEquatable<CryptogramInformationData>

        /// <summary>
        /// Determines whether the specified <see cref="CryptogramInformationData"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="CryptogramInformationData"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="CryptogramInformationData"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="other"/> parameter is null.
        /// </exception>
        public bool Equals(CryptogramInformationData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.Result, Result);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">
        /// The <paramref name="obj"/> parameter is null.
        /// </exception>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof (CryptogramInformationData)) return false;
            return Equals((CryptogramInformationData) obj);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return Result.GetHashCode();
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(CryptogramInformationData left, CryptogramInformationData right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(CryptogramInformationData left, CryptogramInformationData right)
        {
            return !Equals(left, right);
        }

        #endregion

        protected override void OnToString(System.Text.StringBuilder builder)
        {
            builder.AppendLine(Format("Result", Result));
        }
    }
}
