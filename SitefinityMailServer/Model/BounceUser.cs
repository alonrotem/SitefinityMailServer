using System;
using System.Linq;

namespace SitefinityMailServer.Model
{
    internal class BounceUser
    {
        public string EmailAddress { get; set; }
        public BounceError BounceError { get; set; }
    }
}
