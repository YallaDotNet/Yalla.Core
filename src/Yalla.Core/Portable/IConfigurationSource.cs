namespace Yalla
{
    /// <summary>
    /// Interface for configuration sources.
    /// </summary>
    public interface IConfigurationSource
    {
        /// <summary>
        /// Configures the logging system.
        /// </summary>
        void Configure();
    }
}
