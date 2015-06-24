using System.Windows.Forms;
using System.Diagnostics;

namespace SitefinityMailServer
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        public Label VersionLabel
        {
            get
            {
                return this.lblVersionText;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.ericdaugherty.com/apps/simplemailprocessor/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.lumisoft.ee/lsWWW/ENG/Products/Mail_Server/mail_index_eng.aspx?type=info");
        }
    }
}
