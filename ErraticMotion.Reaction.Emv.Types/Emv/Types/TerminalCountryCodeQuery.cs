namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    internal class TerminalCountryCodeQuery : EmvQuery<TerminalCountryCode>
    {
        public override void Visit(TerminalCountryCode item)
        {
            Result = item;
        }
    }
}
