namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEmvElementDiagnostics
    {
        /// <summary>
        /// Returns a string representation of the object with no obfuscation of sensitive information.
        /// </summary>
        string InClear { get; }
    }
}
