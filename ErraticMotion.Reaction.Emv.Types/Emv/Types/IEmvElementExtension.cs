namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// Contains extension interfaces for the <see cref="IEmvElement"/> interface.
    /// </summary>
// ReSharper disable InconsistentNaming
    public static class IEmvElementExtension
// ReSharper restore InconsistentNaming
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static IEmvElementDiagnostics Diagnostics(this IEmvElement item)
        {
            return new EmvElementDiagnostics(item);
        }
    }
}
