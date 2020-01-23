namespace MUnit.Framework
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ArrangeActAssert : TestFixture
    {
        protected sealed override void SetUp()
        {
            base.SetUp();
            Arrange();
            Act();
        }

        protected sealed override void TearDown()
        {
            base.TearDown();
            Cleanup();
        }

        /// <summary>
        /// Arrange all necessary preconditions and inputs. 
        /// </summary>
        protected virtual void Arrange()
        {
        }

        /// <summary>
        /// Act on the object or method under test. 
        /// </summary>
        protected virtual void Act()
        {
        }

        /// <summary>
        /// Cleans up the environment after the test is verified.
        /// </summary>
        protected virtual void Cleanup()
        {
        }
    }
}
