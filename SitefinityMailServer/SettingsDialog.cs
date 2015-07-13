using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using SitefinityMailServer.Model;

namespace SitefinityMailServer
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            bounces = new List<BounceUser>();

            this.bounceErrorCombo.Items.AddRange(BounceError.BourceErrors);
        }

        internal List<BounceUser> bounces { get; set; }

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
            BounceUser bounce = bounces.FirstOrDefault(b => b.EmailAddress.Equals(txtAddBounceAddress.Text, StringComparison.CurrentCultureIgnoreCase));
            if (bounce != null)
            {
                MessageBox.Show("A user \"" + txtAddBounceAddress.Text + "\" is already on the bounce list!");
                txtAddBounceAddress.Focus();
                return;
            }
            lstBounced.Items.Add(string.Format("{0} ({1})", txtAddBounceAddress.Text, GetSelectedBounceErrorDescription()));
            bounces.Add(new BounceUser() { EmailAddress = txtAddBounceAddress.Text, BounceError = GetSelectedBounceError() });
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
                    ret += ((ret == "") ? "" : ";") + b.EmailAddress + "," + b.BounceError.Code;
                }
                return ret;
            }
            set
            {
                bounces.Clear();
                lstBounced.Items.Clear();
                if (!string.IsNullOrWhiteSpace(value))
                {
                    string[] users = value.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string user in users)
                    {
                        string[] properties = user.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (properties.Length > 1)
                        {
                            var username = properties[0];
                            var bounceCode = properties[1];
                            var bounceError = BounceError.Get(bounceCode);
                            bounces.Add(new BounceUser() { EmailAddress = username, BounceError = bounceError });
                            lstBounced.Items.Add(string.Format("{0} ({1})", username, bounceError));
                        }
                    }
                }
            }
        }

        private BounceError GetSelectedBounceError()
        {
            var selectedError = this.bounceErrorCombo.SelectedItem as BounceError;
            return selectedError;
        }

        private string GetSelectedBounceErrorDescription()
        {
            var selectedError = this.bounceErrorCombo.SelectedItem as BounceError;
            return selectedError.ToString();
        }

        private void btnRemoveBounce_Click(object sender, EventArgs e)
        {
            for (int i = lstBounced.SelectedItems.Count - 1; i >= 0; i--)
            {
                string user = lstBounced.SelectedItems[i].ToString().Substring(0, lstBounced.SelectedItems[i].ToString().IndexOf("(")).Trim();
                BounceUser u = bounces.FirstOrDefault(b => b.EmailAddress.Equals(user, StringComparison.CurrentCultureIgnoreCase));
                if (u != null)
                    bounces.Remove(u);
                lstBounced.Items.Remove(lstBounced.SelectedItems[i]);
            }
        }
    }
}
