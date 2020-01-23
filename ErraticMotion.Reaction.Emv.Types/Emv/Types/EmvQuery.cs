namespace Servebase.Pceft.Ped.Emv
{
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// Acts as a base class for single <see cref="IEmvElement"/> implementation queries.
    /// </summary>
    public abstract class EmvQuery<T> : EmvElementVisitorBase where T : EmvElement
    {
        /// <summary>
        /// Indicates whether this query has a result.
        /// </summary>
        public virtual bool HasResult
        {
            get { return (Result != null); }
        }

        /// <summary>
        /// Gets the result of the query
        /// </summary>
        public T Result { get; protected set; }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(GetType().Name);
            builder.AppendLine(string.Format(CultureInfo.InvariantCulture, "{0,45}: {1}", "Has Result", HasResult));
            if (HasResult)
            {
                builder.AppendLine(Result.ToString());
            }

            return builder.ToString();
        }
    }
}
