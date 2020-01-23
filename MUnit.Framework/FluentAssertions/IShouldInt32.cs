namespace MUnit.Framework.FluentAssertions
{
    public interface IShouldInt32 : IShouldObject
    {
        void Be(int expected);

        void NotBe(int expected);
    }
}
