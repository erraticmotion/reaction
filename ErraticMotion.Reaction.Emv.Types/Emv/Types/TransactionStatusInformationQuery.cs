namespace Servebase.Pceft.Ped.Emv
{
    internal class TransactionStatusInformationQuery : EmvQuery<TransactionStatusInformation>
    {
        public override void Visit(TransactionStatusInformation item)
        {
            Result = item;
        }
    }
}
