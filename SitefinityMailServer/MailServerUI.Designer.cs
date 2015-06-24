namespace SitefinityMailServer
{
    partial class MailServerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailServerUI));
            this.btnPic = new System.Windows.Forms.PictureBox();
            this.lblSwitchUpActive = new System.Windows.Forms.Label();
            this.lblSwitchUpInactive = new System.Windows.Forms.Label();
            this.lblSwitchDownActive = new System.Windows.Forms.Label();
            this.lblSwitchDownInactive = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMinimizeToTray = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.serverStatusGroup = new System.Windows.Forms.GroupBox();
            this.picNyan = new System.Windows.Forms.PictureBox();
            this.StatisticsGroup = new System.Windows.Forms.GroupBox();
            this.lblCurrentPendingBounced = new System.Windows.Forms.Label();
            this.lblCollectionLog = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMessages = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sitefinityMailServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuStartServer = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuStopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuRecipients = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.btnPic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.serverStatusGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNyan)).BeginInit();
            this.StatisticsGroup.SuspendLayout();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPic
            // 
            this.btnPic.BackColor = System.Drawing.Color.Transparent;
            this.btnPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPic.Location = new System.Drawing.Point(84, 32);
            this.btnPic.Margin = new System.Windows.Forms.Padding(0);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(128, 128);
            this.btnPic.TabIndex = 0;
            this.btnPic.TabStop = false;
            // 
            // lblSwitchUpActive
            // 
            this.lblSwitchUpActive.AutoSize = true;
            this.lblSwitchUpActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSwitchUpActive.ForeColor = System.Drawing.Color.Red;
            this.lblSwitchUpActive.Location = new System.Drawing.Point(140, 16);
            this.lblSwitchUpActive.Name = "lblSwitchUpActive";
            this.lblSwitchUpActive.Size = new System.Drawing.Size(23, 13);
            this.lblSwitchUpActive.TabIndex = 1;
            this.lblSwitchUpActive.Text = "On";
            // 
            // lblSwitchUpInactive
            // 
            this.lblSwitchUpInactive.AutoSize = true;
            this.lblSwitchUpInactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSwitchUpInactive.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSwitchUpInactive.Location = new System.Drawing.Point(140, 16);
            this.lblSwitchUpInactive.Name = "lblSwitchUpInactive";
            this.lblSwitchUpInactive.Size = new System.Drawing.Size(21, 13);
            this.lblSwitchUpInactive.TabIndex = 2;
            this.lblSwitchUpInactive.Text = "On";
            // 
            // lblSwitchDownActive
            // 
            this.lblSwitchDownActive.AutoSize = true;
            this.lblSwitchDownActive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSwitchDownActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSwitchDownActive.Location = new System.Drawing.Point(140, 163);
            this.lblSwitchDownActive.Name = "lblSwitchDownActive";
            this.lblSwitchDownActive.Size = new System.Drawing.Size(24, 13);
            this.lblSwitchDownActive.TabIndex = 3;
            this.lblSwitchDownActive.Text = "Off";
            // 
            // lblSwitchDownInactive
            // 
            this.lblSwitchDownInactive.AutoSize = true;
            this.lblSwitchDownInactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSwitchDownInactive.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSwitchDownInactive.Location = new System.Drawing.Point(140, 163);
            this.lblSwitchDownInactive.Name = "lblSwitchDownInactive";
            this.lblSwitchDownInactive.Size = new System.Drawing.Size(21, 13);
            this.lblSwitchDownInactive.TabIndex = 4;
            this.lblSwitchDownInactive.Text = "Off";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.menuTools,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlwaysOnTop,
            this.menuMinimizeToTray});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuAlwaysOnTop
            // 
            this.menuAlwaysOnTop.Name = "menuAlwaysOnTop";
            this.menuAlwaysOnTop.Size = new System.Drawing.Size(160, 22);
            this.menuAlwaysOnTop.Text = "Always on top";
            this.menuAlwaysOnTop.CheckedChanged += new System.EventHandler(this.menuAlwaysOnTop_CheckedChanged);
            this.menuAlwaysOnTop.Click += new System.EventHandler(this.menuAlwaysOnTop_Click);
            // 
            // menuMinimizeToTray
            // 
            this.menuMinimizeToTray.Name = "menuMinimizeToTray";
            this.menuMinimizeToTray.Size = new System.Drawing.Size(160, 22);
            this.menuMinimizeToTray.Text = "Minimize to tray";
            this.menuMinimizeToTray.CheckedChanged += new System.EventHandler(this.menuMinimizeToTray_CheckedChanged);
            this.menuMinimizeToTray.Click += new System.EventHandler(this.menuMinimizeToTray_Click);
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptions});
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(48, 20);
            this.menuTools.Text = "&Tools";
            // 
            // menuOptions
            // 
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(116, 22);
            this.menuOptions.Text = "Options";
            this.menuOptions.Click += new System.EventHandler(this.menuOptions_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(107, 22);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(320, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoStrip
            // 
            this.infoStrip.Name = "infoStrip";
            this.infoStrip.Size = new System.Drawing.Size(59, 17);
            this.infoStrip.Text = "Loading...";
            // 
            // serverStatusGroup
            // 
            this.serverStatusGroup.Controls.Add(this.picNyan);
            this.serverStatusGroup.Controls.Add(this.lblSwitchDownInactive);
            this.serverStatusGroup.Controls.Add(this.lblSwitchDownActive);
            this.serverStatusGroup.Controls.Add(this.lblSwitchUpInactive);
            this.serverStatusGroup.Controls.Add(this.lblSwitchUpActive);
            this.serverStatusGroup.Controls.Add(this.btnPic);
            this.serverStatusGroup.Location = new System.Drawing.Point(12, 27);
            this.serverStatusGroup.Name = "serverStatusGroup";
            this.serverStatusGroup.Size = new System.Drawing.Size(296, 193);
            this.serverStatusGroup.TabIndex = 7;
            this.serverStatusGroup.TabStop = false;
            this.serverStatusGroup.Text = "Server Status";
            // 
            // picNyan
            // 
            this.picNyan.Image = global::SitefinityMailServer.Properties.Resources.Nyan;
            this.picNyan.InitialImage = ((System.Drawing.Image)(resources.GetObject("picNyan.InitialImage")));
            this.picNyan.Location = new System.Drawing.Point(122, 16);
            this.picNyan.Margin = new System.Windows.Forms.Padding(0);
            this.picNyan.Name = "picNyan";
            this.picNyan.Size = new System.Drawing.Size(55, 25);
            this.picNyan.TabIndex = 5;
            this.picNyan.TabStop = false;
            this.picNyan.Visible = false;
            // 
            // StatisticsGroup
            // 
            this.StatisticsGroup.Controls.Add(this.lblCurrentPendingBounced);
            this.StatisticsGroup.Controls.Add(this.lblCollectionLog);
            this.StatisticsGroup.Controls.Add(this.btnReset);
            this.StatisticsGroup.Controls.Add(this.lblMessages);
            this.StatisticsGroup.Location = new System.Drawing.Point(12, 229);
            this.StatisticsGroup.Name = "StatisticsGroup";
            this.StatisticsGroup.Size = new System.Drawing.Size(295, 125);
            this.StatisticsGroup.TabIndex = 8;
            this.StatisticsGroup.TabStop = false;
            this.StatisticsGroup.Text = "Statistics";
            // 
            // lblCurrentPendingBounced
            // 
            this.lblCurrentPendingBounced.AutoSize = true;
            this.lblCurrentPendingBounced.Location = new System.Drawing.Point(7, 45);
            this.lblCurrentPendingBounced.Name = "lblCurrentPendingBounced";
            this.lblCurrentPendingBounced.Size = new System.Drawing.Size(198, 13);
            this.lblCurrentPendingBounced.TabIndex = 3;
            this.lblCurrentPendingBounced.Text = "0 Bounced messages pending collection";
            // 
            // lblCollectionLog
            // 
            this.lblCollectionLog.AutoSize = true;
            this.lblCollectionLog.Location = new System.Drawing.Point(7, 70);
            this.lblCollectionLog.Name = "lblCollectionLog";
            this.lblCollectionLog.Size = new System.Drawing.Size(162, 13);
            this.lblCollectionLog.TabIndex = 2;
            this.lblCollectionLog.Text = "No bounced messages collected";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(96, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset Counters";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMessages.Location = new System.Drawing.Point(7, 20);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(197, 13);
            this.lblMessages.TabIndex = 0;
            this.lblMessages.Text = "Total messages received: 0 (0 bounced)";
            this.lblMessages.Click += new System.EventHandler(this.lblMessages_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Sitefinity Mail Server";
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Text = "Sitefinity Mail Server";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sitefinityMailServerToolStripMenuItem,
            this.notifyMenuStartServer,
            this.notifyMenuStopServer,
            this.notifyMenuOptions,
            this.notifyMenuRecipients,
            this.notifyMenuAbout,
            this.exitToolStripMenuItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(240, 158);
            // 
            // sitefinityMailServerToolStripMenuItem
            // 
            this.sitefinityMailServerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sitefinityMailServerToolStripMenuItem.Name = "sitefinityMailServerToolStripMenuItem";
            this.sitefinityMailServerToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.sitefinityMailServerToolStripMenuItem.Text = "Restore Sitefinity Mail Server";
            this.sitefinityMailServerToolStripMenuItem.Click += new System.EventHandler(this.sitefinityMailServerToolStripMenuItem_Click);
            // 
            // notifyMenuStartServer
            // 
            this.notifyMenuStartServer.Name = "notifyMenuStartServer";
            this.notifyMenuStartServer.Size = new System.Drawing.Size(239, 22);
            this.notifyMenuStartServer.Text = "Start Server";
            this.notifyMenuStartServer.Click += new System.EventHandler(this.notifyMenuStartServer_Click);
            // 
            // notifyMenuStopServer
            // 
            this.notifyMenuStopServer.Name = "notifyMenuStopServer";
            this.notifyMenuStopServer.Size = new System.Drawing.Size(239, 22);
            this.notifyMenuStopServer.Text = "Stop Server";
            this.notifyMenuStopServer.Click += new System.EventHandler(this.notifyMenuStopServer_Click);
            // 
            // notifyMenuOptions
            // 
            this.notifyMenuOptions.Name = "notifyMenuOptions";
            this.notifyMenuOptions.Size = new System.Drawing.Size(239, 22);
            this.notifyMenuOptions.Text = "Options";
            this.notifyMenuOptions.Click += new System.EventHandler(this.notifyMenuOptions_Click);
            // 
            // notifyMenuRecipients
            // 
            this.notifyMenuRecipients.Name = "notifyMenuRecipients";
            this.notifyMenuRecipients.Size = new System.Drawing.Size(239, 22);
            this.notifyMenuRecipients.Text = "Show Recipients";
            this.notifyMenuRecipients.Click += new System.EventHandler(this.notifyMenuRecipients_Click);
            // 
            // notifyMenuAbout
            // 
            this.notifyMenuAbout.Name = "notifyMenuAbout";
            this.notifyMenuAbout.Size = new System.Drawing.Size(239, 22);
            this.notifyMenuAbout.Text = "About Sitefinity Mail Server";
            this.notifyMenuAbout.Click += new System.EventHandler(this.notifyMenuAbout_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MailServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 387);
            this.Controls.Add(this.StatisticsGroup);
            this.Controls.Add(this.serverStatusGroup);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MailServerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sitefinity Mail Server v0.4";
            ((System.ComponentModel.ISupportInitialize)(this.btnPic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.serverStatusGroup.ResumeLayout(false);
            this.serverStatusGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNyan)).EndInit();
            this.StatisticsGroup.ResumeLayout(false);
            this.StatisticsGroup.PerformLayout();
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPic;
        private System.Windows.Forms.Label lblSwitchUpActive;
        private System.Windows.Forms.Label lblSwitchUpInactive;
        private System.Windows.Forms.Label lblSwitchDownActive;
        private System.Windows.Forms.Label lblSwitchDownInactive;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoStrip;
        private System.Windows.Forms.GroupBox serverStatusGroup;
        private System.Windows.Forms.GroupBox StatisticsGroup;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.PictureBox picNyan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCollectionLog;
        private System.Windows.Forms.Label lblCurrentPendingBounced;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem menuMinimizeToTray;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem sitefinityMailServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuStartServer;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuStopServer;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuRecipients;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuAbout;

    }
}

