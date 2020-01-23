namespace MUnit.Framework.FluentAssertions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IShouldByte : IShouldObject
    {
        void Be(byte expected);

        void NotBe(byte expected);
    }
}
