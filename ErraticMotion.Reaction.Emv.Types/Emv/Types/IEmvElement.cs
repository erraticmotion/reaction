namespace Servebase.Pceft.Ped.Emv
{
    using Command;

    /// <summary>
    /// 
    /// </summary>
    public interface IEmvElement : ILanguageCommand
    {
        /// <summary>
        /// 
        /// </summary>
        TagLengthValueType Tag { get; }

        /// <summary>
        /// 
        /// </summary>
        byte[] Value { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        void Accept(IEmvElementVisitor visitor);
    }
}
