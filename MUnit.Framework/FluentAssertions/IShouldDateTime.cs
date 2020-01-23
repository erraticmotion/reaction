namespace MUnit.Framework.FluentAssertions
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public interface IShouldDateTime : IShouldObject
    {
        void Be(DateTime expected);

        void NotBe(DateTime expected);
    }
}
