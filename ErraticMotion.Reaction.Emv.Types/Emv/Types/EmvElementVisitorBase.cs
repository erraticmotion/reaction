namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public abstract class EmvElementVisitorBase : IEmvElementVisitor
    {
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<EventArgs<string>> Diagnostic;

        protected void OnDiagnostic(string value)
        {
            var ev = Diagnostic;
            if (ev != null)
            {
                ev(this, EventArgs<string>.New(value));
            }
        }

        protected void OnDiagnostic(string format, object arg0)
        {
            OnDiagnostic(string.Format(format, arg0));
        }

        #region Implementation of IEmvElementVisitor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(GenericEmvType item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(AmountAuthorisedNumeric item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(ApplicationEffectiveDate item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(ApplicationCryptogram item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(ApplicationExpirationDate item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(ApplicationIdentifier item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(ApplicationInterchangeProfile item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(ApplicationLabel item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(CvmList item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(CvmResults item)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(ApplicationUsageControl item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(AuthorisationResponseCode item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(CryptogramInformationData item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(IssuerCountryCode item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(IssuerCountryCodeAlpha3 item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(PanSequenceNumber item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(PrimaryAccountNumber item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(TerminalCountryCode item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(TerminalCapabilities item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(TerminalVerificationResult item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(TransactionStatusInformation item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(OnlinePinCipherBlock item)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(Ksn item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(LanguagePreference item)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public virtual void Visit(PinResult item)
        {
        }

        #endregion
    }
}
