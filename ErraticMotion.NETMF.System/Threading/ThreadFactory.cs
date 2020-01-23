namespace System.Threading
{
    using System;

    public static class ThreadFactory
    {
        /// <summary>
        /// Creates the thread.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="priority">The priority.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><c>start</c> is null.</exception>
        public static Thread CreateThread(ThreadStart start, ThreadPriority priority)
        {
            if (start == null)
            {
                throw new ArgumentNullException("start");
            }

            return new Thread(start)
            {
                Priority = priority
            };
        }
    }
}
