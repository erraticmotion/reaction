namespace MUnit.Framework.FluentAssertions
{
    public interface IShouldInt64 : IShouldObject
    {
        void Be(long expected);

        void NotBe(long expected);
    }
}
