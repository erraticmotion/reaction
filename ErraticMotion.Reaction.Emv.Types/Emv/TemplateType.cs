namespace ErraticMotion.Reaction.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemplateType : byte
    {
        /// <summary>
        /// Don't add a Template Code to the Data.
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Template E0 - Data Element(s)
        /// </summary>
        DataElements = 0xe0,

        /// <summary>
        /// Template E1 - Requested Data Element(s)
        /// </summary>
        RequestedDataElements = 0xe1,

        /// <summary>
        /// Template E2 - Decision Required
        /// </summary>
        DecisionRequired = 0xe2,

        /// <summary>
        /// Template E3 - Transaction Approved
        /// </summary>
        TransactionApproved = 0xe3,

        /// <summary>
        /// Template E4 - Online Action Required
        /// </summary>
        OnlineActionRequired = 0xe4,

        /// <summary>
        /// Template E5 - Transaction Declined
        /// </summary>
        TransactionDeclined = 0xe5,

        /// <summary>
        /// Template E6 - Status
        /// </summary>
        Status = 0xe6
    }
}