using System.IO;

namespace Yalla
{
    /// <summary>
    /// Encapsulates compiler-populated caller information.
    /// </summary>
    public sealed class CallerInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallerInfo"/> class.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="memberName">Member name.</param>
        /// <param name="lineNumber">Line number.</param>
        public CallerInfo(string filePath, string memberName, int lineNumber)
        {
            FilePath = filePath;
            MemberName = memberName;
            LineNumber = lineNumber;
        }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <value>File path.</value>
        public string FilePath
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the member name.
        /// </summary>
        /// <value>Member name.</value>
        public string MemberName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the line number.
        /// </summary>
        /// <value>Line number.</value>
        public int LineNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return FilePath != null
                ? FilePath.GetHashCode() ^ LineNumber
                : base.GetHashCode();
        }
    }
}
