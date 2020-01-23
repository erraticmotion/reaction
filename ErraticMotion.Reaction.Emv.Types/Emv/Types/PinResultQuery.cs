namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// Acts as a query object for the PIN result EMV tag
    /// </summary>
    internal class PinResultQuery : EmvQuery<PinResult>
    {
        public override void Visit(PinResult item)
        {
            Result = item;
        }
    }
}
