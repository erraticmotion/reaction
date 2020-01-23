namespace Servebase.Pceft.Ped.Emv
{
    using System;

    /// <summary>
    /// Represents the results available in the <see cref="ApplicationUsageControl"/> type.
    /// </summary>
    [Flags]
    public enum ApplicationUsageControlMeaning
    {
        /// <summary>
        /// 
        /// </summary>
        ValidForDomesticCashTransactions = 1<< 0,  
 
        /// <summary>
        /// 
        /// </summary>
        ValidForInternationalCashTransactions = 1<<1,

        /// <summary>
        /// 
        /// </summary>
        ValidForDomesticGoods = 1<<2,

        /// <summary>
        /// 
        /// </summary>
        ValidForInternationalGoods = 1<<3,

        /// <summary>
        /// 
        /// </summary>
        ValidForDomesticServices = 1<<4,

        /// <summary>
        /// 
        /// </summary>
        ValidForInternationalServices = 1<<5,

        /// <summary>
        /// 
        /// </summary>
        ValidAtATMs = 1<<6,

        /// <summary>
        /// 
        /// </summary>
        ValidAtTerminalsOtherThanATMs = 1<<7,

        /// <summary>
        /// 
        /// </summary>
        DomesticCashbackAllowed = 1<<8,

        /// <summary>
        /// 
        /// </summary>
        InternationalCashbackAllowed = 1<<9,
    }
}
