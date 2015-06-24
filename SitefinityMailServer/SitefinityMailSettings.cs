using System.Configuration;

namespace SitefinityMailServer
{
    internal class SitefinityMailSettings :ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("sitefinity-campaigns.com")]
        public string MailServerDomain
        {
            get
            {
                return ((string)this["MailServerDomain"]);
            }
            set
            {
                this["MailServerDomain"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("25")]
        public int SmtpServerPort
        {
            get
            {
                return (int)this["SmtpServerPort"];
            }
            set
            {
                this["SmtpServerPort"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("995")]
        public int Pop3ServerPort
        {
            get
            {
                return (int)this["Pop3ServerPort"];
            }
            set
            {
                this["Pop3ServerPort"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("sitefinity@sitefinity-campaigns.com")]
        public string SitefinityPop3BounceTrackerUsername
        {
            get
            {
                return ((string)this["SitefinityPop3BounceTrackerUsername"]);
            }
            set
            {
                this["SitefinityPop3BounceTrackerUsername"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string BounceUsers
        {
            get
            {
                return ((string)this["BounceUsers"]);
            }
            set
            {
                this["BounceUsers"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool ReallySendMessage
        {
            get
            {
                return (bool)this["ReallySendMessage"];
            }
            set
            {
                this["ReallySendMessage"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool MinimizeToTray
        {
            get
            {
                return (bool)this["MinimizeToTray"];
            }
            set
            {
                this["MinimizeToTray"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool StartMinimized
        {
            get
            {
                return (bool)this["StartMinimized"];
            }
            set
            {
                this["StartMinimized"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool AlwaysOnTop
        {
            get
            {
                return (bool)this["AlwaysOnTop"];
            }
            set
            {
                this["AlwaysOnTop"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool StartServerWhenApplicationStarts
        {
            get
            {
                return (bool)this["StartServerWhenApplicationStarts"];
            }
            set
            {
                this["StartServerWhenApplicationStarts"] = value;
            }
        }
    }
}
