using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SitefinityMailServer
{
    public partial class SocketErrorDialog : Form
    {
        public SocketErrorDialog()
        {
            InitializeComponent();
        }

        public Label ErrorLebel
        {
            get
            {
                return this.txtErrorMessage;
            }
        }

        public Button StopMailServerForMe
        {
            get
            {
                return this.btnStophMailServer;
            }
        }

        public TextBox PortTextbox
        {
            get
            {
                return this.txtChangePort;
            }
        }

        public Panel ButtonsPanel
        {
            get
            {
                return this.pnlButtons;
            }
        }

        private void btnChangePort_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Retry;
        }
    }
}
