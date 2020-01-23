namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    internal class CvmResultsQuery : EmvQuery<CvmResults>
    {
        public override void Visit(CvmResults item)
        {
            Result = item;
        }
    }
}
