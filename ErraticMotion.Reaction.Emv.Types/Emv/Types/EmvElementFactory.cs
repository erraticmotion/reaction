namespace Servebase.Pceft.Ped.Emv
{
    internal class EmvElementFactory : IEmvElementFactory
    {
        #region Implementation of IEmvTypeFactory

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public IEmvElement New(TagLengthValueType tag, byte[] value)
        {
            switch (tag)
            {
                case TagLengthValueType.ApplicationLabel:
                    return new ApplicationLabel(value);

                case TagLengthValueType.CryptogramInformationData:
                    return new CryptogramInformationData(value[0]);

                case TagLengthValueType.TransactionTotalAmount:
                    return new AmountAuthorisedNumeric(value);

                case TagLengthValueType.TerminalVerificationResults:
                    return new TerminalVerificationResult(value);

                case TagLengthValueType.ApplicationInterchangeProfile:
                    return new ApplicationInterchangeProfile(value);

                case TagLengthValueType.TransactionStatusInformation:
                    return new TransactionStatusInformation(value);

                case TagLengthValueType.TerminalCountryCode:
                    return new TerminalCountryCode(value);

                case TagLengthValueType.IssuerCountryCode:
                    return new IssuerCountryCode(value);

                case TagLengthValueType.IssuerCountryCodeAlpha3:
                    return new IssuerCountryCodeAlpha3(value);

                case TagLengthValueType.PrimaryAccountNumber:
                    return new PrimaryAccountNumber(value);

                case TagLengthValueType.OnlinePinCipherBlock:
                    return new OnlinePinCipherBlock(value);

                case TagLengthValueType.Ksn:
                    return new Ksn(value);

                case TagLengthValueType.ApplicationUsageControl:
                    return new ApplicationUsageControl(value);

                case TagLengthValueType.LanguagePreference:
                    return new LanguagePreference(value);

                case TagLengthValueType.PinResult:
                    return new PinResult(value);

                case TagLengthValueType.ApplicationIdentifier:
                    return new ApplicationIdentifier(value);

                case TagLengthValueType.ApplicationCryptogram:
                    return new ApplicationCryptogram(value);

                case TagLengthValueType.CvmList:
                    return new CvmList(value);

                case TagLengthValueType.CvmResults:
                    return new CvmResults(value);

                case TagLengthValueType.TerminalCapabilities:
                    return new TerminalCapabilities(value);

                default:
                    return new GenericEmvType(tag, value);
            }
        }

        #endregion
    }
}
