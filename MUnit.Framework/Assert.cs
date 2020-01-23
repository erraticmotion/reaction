namespace MUnit.Framework
{
    using System;

    public static class Assert
    {
        public static void AreEqual(object expected, object actual)
        {
            if (expected == null && expected == actual) 
                return;

            if (expected == null || !expected.Equals(actual)) 
                Fail("Expected: \"" + expected + "\", Actual: \"" + actual + "\".");
        }

        public static void Fail(string message)
        {
            throw new AssertException(message);
        }

        public static void Throws(ThrowsAction action, Type exceptionType)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                if (ex.GetType() == exceptionType)
                {
                    return;
                }

                throw;
            }

            Fail("Expected exception of type " + exceptionType.Name + " was not thrown.");
        }

        public static void DoesNotThrow(ThrowsAction action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Fail(ex.Message);
            }
        }

        public delegate void ThrowsAction();
    }
}
