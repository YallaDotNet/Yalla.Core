using System.IO;

namespace Yalla
{
    /// <summary>
    /// Encapsulates compiler-populated caller information.
    /// </summary>
    public sealed class CallerInfo
    {
        /// <summary>
        /// Creates a new instance of <see cref="CallerInfo"/>.
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
        /// File path.
        /// </summary>
        public string FilePath
        {
            get;
            private set;
        }

        /// <summary>
        /// Member name.
        /// </summary>
        public string MemberName
        {
            get;
            private set;
        }

        /// <summary>
        /// Line number.
        /// </summary>
        public int LineNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        public override int GetHashCode()
        {
            return FilePath != null
                ? FilePath.GetHashCode() ^ LineNumber
                : base.GetHashCode();
        }
    }
}
