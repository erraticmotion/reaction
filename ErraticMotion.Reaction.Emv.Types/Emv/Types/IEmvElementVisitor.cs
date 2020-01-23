namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// Visitor for <see cref="EmvElement"/> types.
    /// </summary>
    public interface IEmvElementVisitor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(GenericEmvType item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(AmountAuthorisedNumeric item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(ApplicationEffectiveDate item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(ApplicationCryptogram item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(ApplicationExpirationDate item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(ApplicationIdentifier item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(ApplicationInterchangeProfile item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(ApplicationLabel item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(CvmList item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(CvmResults item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(AuthorisationResponseCode item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(ApplicationUsageControl item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(CryptogramInformationData item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(IssuerCountryCode item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(IssuerCountryCodeAlpha3 item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(PanSequenceNumber item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(PrimaryAccountNumber item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(TerminalCountryCode item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(TerminalVerificationResult item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(TerminalCapabilities item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(TransactionStatusInformation item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(OnlinePinCipherBlock item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(Ksn item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(LanguagePreference item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        void Visit(PinResult item);
    }
}
