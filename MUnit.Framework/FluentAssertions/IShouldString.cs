namespace MUnit.Framework.FluentAssertions
{
    public interface IShouldString : IShouldObject
    {
        void Be(string expected);

        void NotBe(string expected);
    }
}
