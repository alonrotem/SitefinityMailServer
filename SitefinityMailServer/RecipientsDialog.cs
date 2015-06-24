using System.Collections.Generic;
using System.Windows.Forms;

namespace SitefinityMailServer
{
    public partial class RecipientsDialog : Form
    {
        public List<string> listitems { get; private set; }

        public RecipientsDialog()
        {
            InitializeComponent();
            listitems = new List<string>();
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);

            this.lstRecipients.Items.Clear();
            foreach (string item in listitems)
            {
                lstRecipients.Items.Add(item);
            }
        }
    }
}
