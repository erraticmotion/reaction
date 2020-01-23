namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Text;

    /// <summary>
    /// EMV tag 8A
    /// </summary>
    public sealed class AuthorisationResponseCode : EmvElement
    {
        /// <summary>
        /// Offline approved
        /// </summary>
        public static readonly AuthorisationResponseCode Y1 = new AuthorisationResponseCode(new byte[] { 0x59, 0x31 });

        /// <summary>
        /// Approval after  card initiate referral
        /// </summary>
        public static readonly AuthorisationResponseCode Y2 = new AuthorisationResponseCode(new byte[] { 0x59, 0x32 });

        /// <summary>
        /// Offline approved unable to go online
        /// </summary>
        public static readonly AuthorisationResponseCode Y3 = new AuthorisationResponseCode(new byte[] { 0x59, 0x33 });

        /// <summary>
        /// Offline decline
        /// </summary>
        public static readonly AuthorisationResponseCode Z1 = new AuthorisationResponseCode(new byte[] { 0x5a, 0x31 });

        /// <summary>
        /// Decline after card initiated referral
        /// </summary>
        public static readonly AuthorisationResponseCode Z2 = new AuthorisationResponseCode(new byte[] { 0x5a, 0x32 });

        /// <summary>
        /// Offline decline unable to go online
        /// </summary>
        public static readonly AuthorisationResponseCode Z3 = new AuthorisationResponseCode(new byte[] { 0x5a, 0x33 });

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static AuthorisationResponseCode Parse(byte[] value)
        {
            return new AuthorisationResponseCode(value);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool TryParse(byte[] value, out AuthorisationResponseCode item)
        {
            try
            {
                item = new AuthorisationResponseCode(value);
                return true;
            }
            catch(Exception)
            {
                item = null;
                return false;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorisationResponseCode"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        private AuthorisationResponseCode(byte[] value)
            : base(TagLengthValueType.AuthorisationResponseCode, value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", "ARC value was null.");
            }

            if (value.Length != 2)
            {
               throw new ArgumentOutOfRangeException("value", "ARC value was not 2 in length.");
            }

            Code = Encoding.ASCII.GetString(Value).ToUpper();
            switch (Code)
            {
                case "Y1":
                    Meaning = AuthorisationResponseCodeMeaning.OfflineApproved;
                    break;
                case "Y2":
                    Meaning = AuthorisationResponseCodeMeaning.ApprovalAfterCardInitiatedReferral;
                    break;
                case "Y3":
                    Meaning = AuthorisationResponseCodeMeaning.OfflineApprovedUnableToGoOnline;
                    break;
                case "Z1":
                    Meaning = AuthorisationResponseCodeMeaning.OfflineDecline;
                    break;
                case "Z2":
                    Meaning = AuthorisationResponseCodeMeaning.DeclineAfterCardInitiatedReferral;
                    break;
                case "Z3":
                    Meaning = AuthorisationResponseCodeMeaning.OfflineDeclineUnableToGoOnline;
                    break;
                default:
                    Meaning = AuthorisationResponseCodeMeaning.None;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthorisationResponseCodeMeaning Meaning { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public bool OfflineApproved
        {
            get
            {
                switch (Meaning)
                {
                    case AuthorisationResponseCodeMeaning.OfflineApproved:
                    case AuthorisationResponseCodeMeaning.OfflineApprovedUnableToGoOnline:
                    case AuthorisationResponseCodeMeaning.ApprovalAfterCardInitiatedReferral:
                        return true;
                    default:
                        return false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
