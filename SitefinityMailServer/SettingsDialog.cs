using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SitefinityMailServer
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            bounces = new List<BounceUser>();
        }

        public List<BounceUser> bounces { get; set; }

        private void chkReallySend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReallySend.Checked)
            {
                MessageBox.Show("This option is not really working yet.");
                chkReallySend.Checked = false;
            }
        }

        private void btnAddAbounceAddress_Click(object sender, EventArgs e)
        {
            txtAddBounceAddress.Text = txtAddBounceAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtAddBounceAddress.Text))
            {
                MessageBox.Show("Please enter an address to add to the bounce list");
                txtAddBounceAddress.Focus();
                return;
            }
            BounceUser bounce = bounces.FirstOrDefault(b => b.UserName.Equals(txtAddBounceAddress.Text, StringComparison.CurrentCultureIgnoreCase));
            if (bounce != null)
            {
                MessageBox.Show("A user \"" + txtAddBounceAddress.Text + "\" is already on the bounce list!");
                txtAddBounceAddress.Focus();
                return;
            }
            lstBounced.Items.Add(string.Format("{0} ({1})", txtAddBounceAddress.Text, parseReasonText()));
            bounces.Add(new BounceUser() { UserName = txtAddBounceAddress.Text, BounceReason = parseReason ()});
            txtAddBounceAddress.Text = "";
            txtAddBounceAddress.Focus();
        }

        public string BouncesUsersList
        {
            get
            {
                string ret = "";
                foreach (BounceUser b in bounces)
                {
                    ret += ((ret == "") ? "" : ";") + b.UserName + "," + b.BounceReason;
                }
                return ret;
            }
            set
            {
                bounces.Clear();
                lstBounced.Items.Clear();
                if(!string.IsNullOrWhiteSpace(value))
                {
                    string[] users = value.Split(new string[] {";"}, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string user in users)
                    {
                        string[] parts = user.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length > 1)
                        {
                            bounces.Add(new BounceUser() { UserName = parts[0], BounceReason = parts[1] });
                            lstBounced.Items.Add(string.Format("{0} ({1})", parts[0], parseReasonText(parts[1])));
                        }
                    }
                }
            }
        }

        private string parseReason()
        {
            if (radioMailboxFull.Checked)
                return BouncedUserMessage.Bounce_MailboxFull;
            else if (radioUnknownUser.Checked)
                return BouncedUserMessage.Bounce_UnknownUser;
            else
                return BouncedUserMessage.Bounce_Other;
        }

        private string parseReasonText()
        {
            if (radioMailboxFull.Checked)
                return parseReasonText(BouncedUserMessage.Bounce_MailboxFull);
            else if (radioUnknownUser.Checked)
                return parseReasonText(BouncedUserMessage.Bounce_UnknownUser);
            else
                return parseReasonText(BouncedUserMessage.Bounce_Other);
        }

        private string parseReasonText(string reason)
        {
            if (reason == BouncedUserMessage.Bounce_MailboxFull)
                return "Mailbox is full";
            else if (reason == BouncedUserMessage.Bounce_UnknownUser)
                return "User is unknown";
            else
                return "Unknown reason";
        }

        private void btnRemoveBounce_Click(object sender, EventArgs e)
        {
            for (int i = lstBounced.SelectedItems.Count - 1; i >= 0; i--)
            {
                string user = lstBounced.SelectedItems[i].ToString().Substring(0, lstBounced.SelectedItems[i].ToString().IndexOf("(")).Trim();
                BounceUser u = bounces.FirstOrDefault(b => b.UserName.Equals(user, StringComparison.CurrentCultureIgnoreCase));
                if (u != null)
                    bounces.Remove(u);
                lstBounced.Items.Remove(lstBounced.SelectedItems[i]);
            }
        }
    }
}
