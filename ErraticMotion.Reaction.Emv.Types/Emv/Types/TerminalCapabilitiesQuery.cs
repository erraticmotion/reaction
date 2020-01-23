namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    internal class TerminalCapabilitiesQuery : EmvQuery<TerminalCapabilities>
    {
        public override void Visit(TerminalCapabilities item)
        {
            Result = item;
        }
    }
}
