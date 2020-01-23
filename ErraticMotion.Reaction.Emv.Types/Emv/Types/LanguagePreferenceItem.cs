namespace Servebase.Pceft.Ped.Emv
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class LanguagePreferenceItem 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePreferenceItem"/> class.
        /// </summary>
        /// <param name="priority">The priority.</param>
        /// <param name="language">The language.</param>
        internal LanguagePreferenceItem(LanguagePreferencePriority priority, Language language)
        {
            Priority = priority;
            Language = language;
        }

        /// <summary>
        /// 
        /// </summary>
        public LanguagePreferencePriority Priority { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public Language Language { get; private set; }
    }
}
