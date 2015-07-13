using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SitefinityMailServer.Model
{
    internal class BounceMessage
    {
        public string UserName { get; set; }
        public Guid SubscriberId { get; set; }
        public Guid CampaignId { get; set; }
        public string MessageData { get; set; }

        public BounceMessage(string messageContent, string bounceReason)
        {
            //this.MessageData = messageContent;
            StringReader reader = new StringReader(messageContent);
            string lineText = string.Empty;
            Guid sub;
            while ((lineText = reader.ReadLine()) != null)
            {
                if (lineText.StartsWith("X-Sitefinity-Subscriber"))
                {
                    var pair = lineText.Split(':');
                    if (Guid.TryParse(pair[1].Trim(), out sub))
                        SubscriberId = sub;
                }
                else if (lineText.StartsWith("X-Sitefinity-Campaign"))
                {
                    var pair = lineText.Split(':');
                    if (Guid.TryParse(pair[1].Trim(), out sub))
                    {
                        CampaignId = sub;
                    }
                }
            }
            this.MessageData = string.Format(
                "Received: from localhost (Sitefinity Mail Server [127.0.0.1])" + "\r\n" +
                "Date: " + DateTime.Now.ToLongDateString() + "\r\n" +
                "Status:{0}" + "\r\n" +
                "X-Sitefinity-Subscriber:{2}" + "\r\n" +
                "X-Sitefinity-Campaign:{1}" + "\r\n" +
                "From: Sitefinity Mail Server <sitefinity@sitefinity-campaigns.com>" + "\r\n" +
                "To: Sitefinity Mail Server <sitefinity@sitefinity-campaigns.com>" + "\r\n" +
                "Message-Id: <"+ Guid.NewGuid().ToString() +"@sitefinity-campaigns.com>" + "\r\n" +
                "Subject: Bounced message!" + "\r\n" +
                "\r\n{3}",
                //"Status:{0}\r\nX-Sitefinity-Campaign:{1}\r\nX-Sitefinity-Subscriber:{2}\r\n{3}",
                bounceReason,
                CampaignId.ToString(),
                SubscriberId.ToString(),
                "Bounced message!");

        }
    }
}
