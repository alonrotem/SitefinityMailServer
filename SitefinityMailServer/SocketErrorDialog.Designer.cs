namespace SitefinityMailServer
{
    partial class SocketErrorDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtErrorMessage = new System.Windows.Forms.Label();
            this.btnStophMailServer = new System.Windows.Forms.Button();
            this.btnIllStopTheServiceMyself = new System.Windows.Forms.Button();
            this.btnChangePort = new System.Windows.Forms.Button();
            this.txtChangePort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.AutoSize = true;
            this.txtErrorMessage.Location = new System.Drawing.Point(12, 18);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(83, 13);
            this.txtErrorMessage.TabIndex = 0;
            this.txtErrorMessage.Text = "txtErrorMessage";
            // 
            // btnStophMailServer
            // 
            this.btnStophMailServer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStophMailServer.Location = new System.Drawing.Point(15, 3);
            this.btnStophMailServer.Name = "btnStophMailServer";
            this.btnStophMailServer.Size = new System.Drawing.Size(491, 23);
            this.btnStophMailServer.TabIndex = 1;
            this.btnStophMailServer.Text = "Yes, it\'s hMailServer. Please try to stop the service for me. Thank you so much! " +
    "You are awesome!";
            this.btnStophMailServer.UseVisualStyleBackColor = true;
            // 
            // btnIllStopTheServiceMyself
            // 
            this.btnIllStopTheServiceMyself.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIllStopTheServiceMyself.Location = new System.Drawing.Point(16, 62);
            this.btnIllStopTheServiceMyself.Name = "btnIllStopTheServiceMyself";
            this.btnIllStopTheServiceMyself.Size = new System.Drawing.Size(488, 23);
            this.btnIllStopTheServiceMyself.TabIndex = 2;
            this.btnIllStopTheServiceMyself.Text = "Don\'t do anything. I\'ll stop the blocking app myself";
            this.btnIllStopTheServiceMyself.UseVisualStyleBackColor = true;
            // 
            // btnChangePort
            // 
            this.btnChangePort.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChangePort.Location = new System.Drawing.Point(404, 33);
            this.btnChangePort.Name = "btnChangePort";
            this.btnChangePort.Size = new System.Drawing.Size(102, 23);
            this.btnChangePort.TabIndex = 3;
            this.btnChangePort.Text = "Change Port";
            this.btnChangePort.UseVisualStyleBackColor = true;
            this.btnChangePort.Click += new System.EventHandler(this.btnChangePort_Click);
            // 
            // txtChangePort
            // 
            this.txtChangePort.Location = new System.Drawing.Point(333, 35);
            this.txtChangePort.Name = "txtChangePort";
            this.txtChangePort.Size = new System.Drawing.Size(57, 20);
            this.txtChangePort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "To run with the other app, set a new port for Sitefinity Mail Server";
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoSize = true;
            this.pnlButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnStophMailServer);
            this.pnlButtons.Controls.Add(this.btnIllStopTheServiceMyself);
            this.pnlButtons.Controls.Add(this.btnChangePort);
            this.pnlButtons.Controls.Add(this.txtChangePort);
            this.pnlButtons.Controls.Add(this.label1);
            this.pnlButtons.Location = new System.Drawing.Point(4, 120);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(509, 88);
            this.pnlButtons.TabIndex = 6;
            // 
            // SocketErrorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 219);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SocketErrorDialog";
            this.ShowIcon = false;
            this.Text = "Error Opening Socket";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtErrorMessage;
        private System.Windows.Forms.Button btnStophMailServer;
        private System.Windows.Forms.Button btnIllStopTheServiceMyself;
        private System.Windows.Forms.Button btnChangePort;
        private System.Windows.Forms.TextBox txtChangePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButtons;
    }
}