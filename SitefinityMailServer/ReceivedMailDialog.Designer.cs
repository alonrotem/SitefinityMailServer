namespace SitefinityMailServer
{
    partial class ReceivedMailDialog
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
            this.lblReceivedMail = new System.Windows.Forms.Label();
            this.lstEmails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceivedMail
            // 
            this.lblReceivedMail.AutoSize = true;
            this.lblReceivedMail.Location = new System.Drawing.Point(12, 9);
            this.lblReceivedMail.Name = "lblReceivedMail";
            this.lblReceivedMail.Size = new System.Drawing.Size(108, 13);
            this.lblReceivedMail.TabIndex = 1;
            this.lblReceivedMail.Text = "Email received so far:";
            // 
            // lstEmails
            // 
            this.lstEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstEmails.FullRowSelect = true;
            this.lstEmails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstEmails.Location = new System.Drawing.Point(12, 27);
            this.lstEmails.Name = "lstEmails";
            this.lstEmails.Size = new System.Drawing.Size(414, 574);
            this.lstEmails.TabIndex = 2;
            this.lstEmails.UseCompatibleStateImageBehavior = false;
            this.lstEmails.View = System.Windows.Forms.View.Details;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(12, 606);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(414, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Alright";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ReceivedMailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 644);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstEmails);
            this.Controls.Add(this.lblReceivedMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceivedMailDialog";
            this.Text = "ReceivedMailDialog";
            this.Load += new System.EventHandler(this.ReceivedMailDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceivedMail;
        private System.Windows.Forms.ListView lstEmails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnOK;
    }
}