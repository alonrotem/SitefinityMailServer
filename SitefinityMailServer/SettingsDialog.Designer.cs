namespace SitefinityMailServer
{
    partial class SettingsDialog
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bounceErrorCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddAbounceAddress = new System.Windows.Forms.Button();
            this.txtAddBounceAddress = new System.Windows.Forms.TextBox();
            this.btnRemoveBounce = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBounced = new System.Windows.Forms.ListBox();
            this.txtSitefinityBounce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPop3ServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkReallySend = new System.Windows.Forms.CheckBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bounceErrorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bounceErrorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnRemoveBounce);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lstBounced);
            this.groupBox1.Controls.Add(this.txtSitefinityBounce);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPop3ServerPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkReallySend);
            this.groupBox1.Controls.Add(this.chkAutoStart);
            this.groupBox1.Controls.Add(this.txtSMTPPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDomain);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bounceErrorCombo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddAbounceAddress);
            this.groupBox2.Controls.Add(this.txtAddBounceAddress);
            this.groupBox2.Location = new System.Drawing.Point(12, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 165);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Bounced User";
            // 
            // bounceErrorCombo
            // 
            this.bounceErrorCombo.FormattingEnabled = true;
            this.bounceErrorCombo.Location = new System.Drawing.Point(6, 69);
            this.bounceErrorCombo.Name = "bounceErrorCombo";
            this.bounceErrorCombo.Size = new System.Drawing.Size(333, 21);
            this.bounceErrorCombo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Why is this user\'s email boucing?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Username:";
            // 
            // btnAddAbounceAddress
            // 
            this.btnAddAbounceAddress.Location = new System.Drawing.Point(114, 136);
            this.btnAddAbounceAddress.Name = "btnAddAbounceAddress";
            this.btnAddAbounceAddress.Size = new System.Drawing.Size(117, 23);
            this.btnAddAbounceAddress.TabIndex = 13;
            this.btnAddAbounceAddress.Text = "Add Bounce User";
            this.btnAddAbounceAddress.UseVisualStyleBackColor = true;
            this.btnAddAbounceAddress.Click += new System.EventHandler(this.btnAddAbounceAddress_Click);
            // 
            // txtAddBounceAddress
            // 
            this.txtAddBounceAddress.Location = new System.Drawing.Point(67, 23);
            this.txtAddBounceAddress.Name = "txtAddBounceAddress";
            this.txtAddBounceAddress.Size = new System.Drawing.Size(272, 20);
            this.txtAddBounceAddress.TabIndex = 12;
            // 
            // btnRemoveBounce
            // 
            this.btnRemoveBounce.Location = new System.Drawing.Point(114, 455);
            this.btnRemoveBounce.Name = "btnRemoveBounce";
            this.btnRemoveBounce.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveBounce.TabIndex = 14;
            this.btnRemoveBounce.Text = "Remove Selected Users";
            this.btnRemoveBounce.UseVisualStyleBackColor = true;
            this.btnRemoveBounce.Click += new System.EventHandler(this.btnRemoveBounce_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bounce Messages Sent to The Following Addresses:";
            // 
            // lstBounced
            // 
            this.lstBounced.FormattingEnabled = true;
            this.lstBounced.Location = new System.Drawing.Point(8, 328);
            this.lstBounced.Name = "lstBounced";
            this.lstBounced.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBounced.Size = new System.Drawing.Size(349, 121);
            this.lstBounced.TabIndex = 10;
            // 
            // txtSitefinityBounce
            // 
            this.txtSitefinityBounce.Location = new System.Drawing.Point(183, 97);
            this.txtSitefinityBounce.Name = "txtSitefinityBounce";
            this.txtSitefinityBounce.Size = new System.Drawing.Size(175, 20);
            this.txtSitefinityBounce.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sitefinity Bounce POP3 Username:";
            // 
            // txtPop3ServerPort
            // 
            this.txtPop3ServerPort.Location = new System.Drawing.Point(183, 71);
            this.txtPop3ServerPort.Name = "txtPop3ServerPort";
            this.txtPop3ServerPort.Size = new System.Drawing.Size(175, 20);
            this.txtPop3ServerPort.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "POP3 Server Port:";
            // 
            // chkReallySend
            // 
            this.chkReallySend.AutoSize = true;
            this.chkReallySend.Location = new System.Drawing.Point(8, 503);
            this.chkReallySend.Name = "chkReallySend";
            this.chkReallySend.Size = new System.Drawing.Size(160, 17);
            this.chkReallySend.TabIndex = 5;
            this.chkReallySend.Text = "Really keep/send messages";
            this.chkReallySend.UseVisualStyleBackColor = true;
            this.chkReallySend.CheckedChanged += new System.EventHandler(this.chkReallySend_CheckedChanged);
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(8, 480);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(161, 17);
            this.chkAutoStart.TabIndex = 4;
            this.chkAutoStart.Text = "Automatically start the server";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Location = new System.Drawing.Point(183, 45);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(175, 20);
            this.txtSMTPPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SMTP Server Port:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(183, 19);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(175, 20);
            this.txtDomain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Domain:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(90, 552);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(208, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bounceErrorBindingSource
            // 
            this.bounceErrorBindingSource.DataSource = typeof(SitefinityMailServer.Model.BounceError);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 587);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bounceErrorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDomain;
        public System.Windows.Forms.TextBox txtSMTPPort;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkAutoStart;
        public System.Windows.Forms.CheckBox chkReallySend;
        public System.Windows.Forms.TextBox txtPop3ServerPort;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSitefinityBounce;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBounced;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddBounceAddress;
        private System.Windows.Forms.Button btnAddAbounceAddress;
        private System.Windows.Forms.Button btnRemoveBounce;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bounceErrorCombo;
        private System.Windows.Forms.BindingSource bounceErrorBindingSource;
    }
}