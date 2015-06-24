using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SitefinityMailServer
{
    public class UserMessage
    {
        public string Recipient
        {
            get;
            set;
        }

        public string MessageSource
        {
            get;
            set;
        }

        public bool IsOpened
        {
            get;
            set;
        }

        public List<string> MessageLinks
        {
            get;
            set;
        }
    }
}
