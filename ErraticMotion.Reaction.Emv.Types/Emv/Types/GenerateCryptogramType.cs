namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateCryptogramType
    {
        /// <summary>
        /// AAC - Application Authentication Cryptogram
        /// </summary>
        TransactionDeclined,

        /// <summary>
        /// TC - Transaction certificate
        /// </summary>
        TransactionApproved,

        /// <summary>
        /// ARQC - Authorisation Request Cryptogram
        /// </summary>
        OnlineAuthorizationRequested,
    }
}
