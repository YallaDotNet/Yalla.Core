namespace Yalla
{
    /// <summary>
    /// Format message delegate.
    /// </summary>
    /// <param name="format">Message format.</param>
    /// <param name="args">Message format arguments.</param>
    /// <returns>Formatted message.</returns>
    public delegate string FormatMessageHandler(string format, params object[] args);

    /// <summary>
    /// Format message callback delegate.
    /// </summary>
    /// <param name="formatMessage">Format message delegate.</param>
    /// <returns>Formatted message.</returns>
    public delegate string FormatMessageCallback(FormatMessageHandler formatMessage);
}
