using System;

namespace SitefinityMailServer.POP3.IO
{
    /// <summary>
    /// The exception that is thrown when maximum allowed line size has exceeded.
    /// </summary>
    public class LineSizeExceededException : Exception
    {
        /// <summary>
        /// Default coonstructor.
        /// </summary>
        public LineSizeExceededException() : base()
        {
        }
    }
}
