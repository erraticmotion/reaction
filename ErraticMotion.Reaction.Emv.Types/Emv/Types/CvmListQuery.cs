namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    internal class CvmListQuery : EmvQuery<CvmList>
    {
        public override void Visit(CvmList item)
        {
            Result = item;
        }
    }
}
