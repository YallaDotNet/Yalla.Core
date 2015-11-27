using System;
using System.Text;

namespace Yalla
{
    /// <summary>
    /// Default formatter.
    /// </summary>
    public class DefaultFormatter : FormatterBase
    {
        private static readonly Lazy<DefaultFormatter> _lazy;

        static DefaultFormatter()
        {
            _lazy = new Lazy<DefaultFormatter>(() => new DefaultFormatter());
        }

        /// <summary>
        /// Gets an instance of the <see cref="Yalla.DefaultFormatter"/> class.
        /// </summary>
        /// <value>The instance.</value>
        public static DefaultFormatter Instance
        {
            get { return _lazy.Value; }
        }

        internal DefaultFormatter()
        {
        }

        /// <summary>
        /// Gets the prologue.
        /// </summary>
        /// <value>Prologue.</value>
        public override string Prologue
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the epilogue.
        /// </summary>
        /// <value>Epilogue.</value>
        public override string Epilogue
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the message prefix.
        /// </summary>
        /// <value>Message prefix.</value>
        protected override string Prefix
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the message suffix.
        /// </summary>
        /// <value>Message suffix.</value>
        protected override string Suffix
        {
            get { return "\r\n"; }
        }

        /// <summary>
        /// Appends an entry.
        /// </summary>
        /// <param name="builder">String builder.</param>
        /// <param name="provider">Format provider.</param>
        /// <param name="entry">The entry.</param>
        /// <returns>The <see cref="StringBuilder"/> used to format the entry.</returns>
        protected override StringBuilder AppendEntry(StringBuilder builder, IFormatProvider provider, LogEntry entry)
        {
            return entry.Exception == null
                ? AppendMessage(builder, provider, entry)
                : AppendException(builder, provider, entry);
        }

        /// <summary>
        /// Appends a message.
        /// </summary>
        /// <param name="builder">String builder.</param>
        /// <param name="provider">Format provider.</param>
        /// <param name="entry">The entry.</param>
        /// <returns>The <see cref="StringBuilder"/> used to format the entry.</returns>
        protected virtual StringBuilder AppendMessage(StringBuilder builder, IFormatProvider provider, LogEntry entry)
        {
            return builder.AppendFormat(provider, "{0}", entry.Message);
        }

        /// <summary>
        /// Appends an exception.
        /// </summary>
        /// <param name="builder">String builder.</param>
        /// <param name="provider">Format provider.</param>
        /// <param name="entry">The entry.</param>
        /// <returns>The <see cref="StringBuilder"/> used to format the entry.</returns>
        protected virtual StringBuilder AppendException(StringBuilder builder, IFormatProvider provider, LogEntry entry)
        {
            return builder.AppendFormat(provider, "{0}", entry.Exception);
        }
    }
}
