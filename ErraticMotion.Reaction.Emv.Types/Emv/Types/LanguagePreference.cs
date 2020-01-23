namespace Servebase.Pceft.Ped.Emv
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 1-4 languages stored in order of preference, each represented by 2 alphabetical characters according to ISO 639
    /// </summary>
    public sealed class LanguagePreference : EmvElement, IEnumerable<LanguagePreferenceItem>
    {
        private readonly List<LanguagePreferenceItem> preferences = new List<LanguagePreferenceItem>();

        private static readonly Func<LanguagePreferencePriority, LanguagePreferenceItem> NoPreference 
            = p => new LanguagePreferenceItem(p, Language.Undefined);

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePreference"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public LanguagePreference(byte[] value)
            : base(TagLengthValueType.LanguagePreference, value)
        {
            if (value == null || value.Length < 2)
            {
                preferences.Add(NoPreference(LanguagePreferencePriority.First));
                preferences.Add(NoPreference(LanguagePreferencePriority.Second));
                preferences.Add(NoPreference(LanguagePreferencePriority.Third));
                preferences.Add(NoPreference(LanguagePreferencePriority.Fourth));
                return;
            }

            if (value.Length < 2 || value.Length > 8 || value.Length.IsOdd())
            {
                throw new ArgumentOutOfRangeException("value", "value length was not an even number between 2 and 8");
            }
            
            Encoding.ASCII.GetString(value)
                .Chunk(2)
                .ForIndex((x, y) =>
                    {
                        var lang = Language.Parse(new string(y.ToArray()));
                        LanguagePreferencePriority priority;
                        switch (x)
                        {
                            case 0:
                                priority = LanguagePreferencePriority.First;
                                break;
                            case 1:
                                priority = LanguagePreferencePriority.Second;
                                break;
                            case 2:
                                priority = LanguagePreferencePriority.Third;
                                break;
                            case 3:
                                priority = LanguagePreferencePriority.Fourth;
                                break;
                            default:
                                throw new ArgumentOutOfRangeException("x");
                        }
                        preferences.Add(new LanguagePreferenceItem(priority, lang));
                    });

            switch (preferences.Count)
            {
                case 1:
                    preferences.Add(NoPreference(LanguagePreferencePriority.Second));
                    preferences.Add(NoPreference(LanguagePreferencePriority.Third));
                    preferences.Add(NoPreference(LanguagePreferencePriority.Fourth));
                    break;
                case 2:
                    preferences.Add(NoPreference(LanguagePreferencePriority.Third));
                    preferences.Add(NoPreference(LanguagePreferencePriority.Fourth));
                    break;
                case 3:
                    preferences.Add(NoPreference(LanguagePreferencePriority.Fourth));
                    break;
            }
        }

        /// <summary>
        /// Determines from the language preferences which language in the match list has the highest
        /// priority. If not match made, then returns <see cref="Language.Undefined"/>
        /// </summary>
        /// <param name="match">The list of item to match</param>
        /// <returns>The <see cref="Language"/> that has the highest priority. If none, then returns unknown.</returns>
        public Language WhichHasPriority(IList<Language> match)
        {
            Language result = null;
            preferences.OrderBy(x => x.Priority.Priority).ForEach(x => {
                if (match.Contains(x.Language) && result == null)
                {
                    result = x.Language;
                }
            });

            return result ?? Language.Undefined;
        }

        #region Overrides of EmvElement

        /// <summary>
        /// 
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(IEmvElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        #endregion

        protected override void OnToString(StringBuilder builder)
        {
            var el = preferences.Where(x => x.Priority == LanguagePreferencePriority.First).Single().Language;
            if (el != Language.Undefined)
            {
                builder.AppendLine(Format("1st preference", el));
            }

            el = preferences.Where(x => x.Priority == LanguagePreferencePriority.Second).Single().Language;
            if (el != Language.Undefined)
            {
                builder.AppendLine(Format("2nd preference", el));
            }

            el = preferences.Where(x => x.Priority == LanguagePreferencePriority.Third).Single().Language;
            if (el != Language.Undefined)
            {
                builder.AppendLine(Format("3rd preference", el));
            }

            el = preferences.Where(x => x.Priority == LanguagePreferencePriority.Fourth).Single().Language;
            if (el != Language.Undefined)
            {
                builder.AppendLine(Format("4th preference", el));
            }
        }

        #region Implementation of IEnumerable

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public IEnumerator<LanguagePreferenceItem> GetEnumerator()
        {
            return preferences.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
