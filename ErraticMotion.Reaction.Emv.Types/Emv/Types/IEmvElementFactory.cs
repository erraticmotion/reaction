namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// Factory for <see cref="IEmvElement"/>
    /// </summary>
    public interface IEmvElementFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        IEmvElement New(TagLengthValueType tag, byte[] value);
    }
}
