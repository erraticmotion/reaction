namespace Servebase.Pceft.Ped.Emv
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class EmvTagComparer : IEqualityComparer<IEmvElement>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public bool Equals(IEmvElement b1, IEmvElement b2)
        {
            return b1.Tag == b2.Tag;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public int GetHashCode(IEmvElement item)
        {
            return item.Tag.GetHashCode();
        }
    }
}
