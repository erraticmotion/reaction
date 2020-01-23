namespace Servebase.Pceft.Ped.Emv
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface IIssuerScripts
    {
        /// <summary>
        /// 
        /// </summary>
        bool BeforeSecondGenerate { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<IssuerScriptCommand> Scripts { get; }
    }
}
