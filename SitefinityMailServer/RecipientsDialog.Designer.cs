namespace SitefinityMailServer
{
    partial class RecipientsDialog
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
            this.lstRecipients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstRecipients
            // 
            this.lstRecipients.FormattingEnabled = true;
            this.lstRecipients.Items.AddRange(new object[] {
            "x"});
            this.lstRecipients.Location = new System.Drawing.Point(6, 6);
            this.lstRecipients.Name = "lstRecipients";
            this.lstRecipients.Size = new System.Drawing.Size(334, 446);
            this.lstRecipients.TabIndex = 0;
            // 
            // RecipientsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 469);
            this.Controls.Add(this.lstRecipients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecipientsDialog";
            this.Text = "Recipients";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecipients;
    }
}