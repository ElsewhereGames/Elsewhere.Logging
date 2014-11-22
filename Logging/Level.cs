
namespace Elsewhere.Logging
{

    /// <summary>
    /// This enumerates the levels of severity which can be assigned to log
    /// messages. Note that <see cref="Level.Debug"/> is considered to be the
    /// lowest level, <see cref="Level.Error"/> the highest.
    /// </summary>
    public enum Level
    {

        /// <summary>
        /// Messages at this level are for development and detailed diagnostics
        /// only, and should never appear in released sofware.
        /// </summary>
        Debug,

        /// <summary>
        /// To track the state of an application. Messages at this level could
        /// appear in the logs of released software, but take care not to
        /// generate too many messages.
        /// </summary>
        Information,

        /// <summary>
        /// Used to provide notification of problems which may lead to decreased
        /// experience or even failures if the problem is not addressed.
        /// </summary>
        Warning,

        /// <summary>
        /// Severe degradation of user experience.
        /// </summary>
        Error

    }
}
