namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthorisationResponseCodeMeaning
    {
        /// <summary>
        /// 
        /// </summary>
        None,

        /// <summary>
        /// Y1
        /// </summary>
        OfflineApproved,

        /// <summary>
        /// Y2
        /// </summary>
        ApprovalAfterCardInitiatedReferral,

        /// <summary>
        /// Y3
        /// </summary>
        OfflineApprovedUnableToGoOnline,

        /// <summary>
        /// Z1
        /// </summary>
        OfflineDecline,

        /// <summary>
        /// Z2
        /// </summary>
        DeclineAfterCardInitiatedReferral,

        /// <summary>
        /// Z3
        /// </summary>
        OfflineDeclineUnableToGoOnline,
    }
}
