using System;
using System.Linq;

namespace SitefinityMailServer.Model
{
    /// <summary>
    /// Represents a single bounce error.
    /// </summary>
    internal class BounceError
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Code of the error.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the Description of the error.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether the error is a hard or soft bounce.
        /// </summary>
        public bool IsHardBounce { get; set; }

        #endregion

        #region Bounce Errors

        /// <summary>
        /// All supported bounce errors.
        /// </summary>
        public static BounceError[] BourceErrors = new BounceError[]
        {
            new BounceError() { Code = "5.0.0", Description = "Address does not exist", IsHardBounce = true },
            new BounceError() { Code = "5.1.0", Description = "Other address status", IsHardBounce = true },
            new BounceError() { Code = "5.1.1", Description = "Bad destination mailbox address", IsHardBounce = true },
            new BounceError() { Code = "5.1.2", Description = "Bad destination system address", IsHardBounce = true },
            new BounceError() { Code = "5.1.3", Description = "Bad destination mailbox address syntax", IsHardBounce = true },
            new BounceError() { Code = "5.1.4", Description = "Destination mailbox address ambiguous", IsHardBounce = true },
            new BounceError() { Code = "5.1.5", Description = "Destination mailbox address valid", IsHardBounce = true },
            new BounceError() { Code = "5.1.6", Description = "Mailbox has moved", IsHardBounce = true },
            new BounceError() { Code = "5.1.7", Description = "Bad sender’s mailbox address syntax", IsHardBounce = true },
            new BounceError() { Code = "5.1.8", Description = "Bad sender’s system address", IsHardBounce = true },
            new BounceError() { Code = "5.2.0", Description = "Other or undefined mailbox status", IsHardBounce = false },
            new BounceError() { Code = "5.2.1", Description = "Mailbox disabled, not accepting messages", IsHardBounce = false },
            new BounceError() { Code = "5.2.2", Description = "Mailbox full", IsHardBounce = false },

            new BounceError() { Code = "2.9.9", Description = "Unknown bounce", IsHardBounce = false },
        };

        /// <summary>
        /// Gets a bounce error by error code.
        /// </summary>
        /// <param name="errorCode">The code of the error. E.g. "5.0.0"</param>
        /// <returns>An instance of <see cref="BounceError"/> class with the given error or null, if no such bounce error exist.</returns>
        public static BounceError Get(string errorCode)
        {
            var bounceError = BounceError.BourceErrors.FirstOrDefault(e => e.Code == errorCode);
            return bounceError;
        }

        #endregion

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2})", this.Code, this.Description, this.IsHardBounce ? "hard" : "soft");
        }
    }
}
