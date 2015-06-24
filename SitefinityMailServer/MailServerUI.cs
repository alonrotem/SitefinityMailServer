using System;
using System.Windows.Forms;
using System.Threading;
using SitefinityMailServer.SMTP;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Collections.Generic;
using SitefinityMailServer.SMTP.Common;
using System.ServiceProcess;
using System.Linq;
using SitefinityMailServer.POP3;
using System.Net;
using SitefinityMailServer.POP3.Net;
using System.Text;
using System.Net.Sockets;

namespace SitefinityMailServer
{
    public partial class MailServerUI : Form
    {
        const string curVersion = "Sitefinity Mail Server v0.6";

        #region Construction

        public MailServerUI()
        {
            InitializeComponent();
            this.btnPic.Click += new EventHandler(btnPic_Click);

            this.lblSwitchUpInactive.Click += new EventHandler(lblSwitchUpInactive_Click);
            this.lblSwitchDownInactive.Click += new EventHandler(lblSwitchDownInactive_Click);
            this.Resize += new EventHandler(MailServerUI_Resize);
            this.Text = curVersion;

            this.SetImage(imgDown);
            messagesReceptionTimer.Elapsed += delegate { MessageReceptionTimerElapsed(); };
        }

        #endregion

        #region UI Overridden methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ServiceController hMailServerService = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "hMailServer");
            if (hMailServerService != null && hMailServerService.Status == ServiceControllerStatus.Running)
            {
                DialogResult result = MessageBox.Show("hMailServer is currently running on your machine. Shall I stop it for you?", "hMailServer Service Detected", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    hMailServerService.Stop();
                    hMailServerService.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 30));
                    if (hMailServerService.Status == ServiceControllerStatus.Stopped)
                    {
                        MessageBox.Show("hMailServer stopped successully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to stop hMailServer.");
                    }
                }
            }

            UpdateInfoStrip();
            if (settings.StartServerWhenApplicationStarts)
            {
                SetImage(imgUp);
                notifyMenuStartServer.Visible = false;
                notifyMenuStopServer.Visible = true;
            }
            else
            {
                notifyMenuStartServer.Visible = true;
                notifyMenuStopServer.Visible = false;
            }
            menuAlwaysOnTop.Checked = settings.AlwaysOnTop;
            menuMinimizeToTray.Checked = settings.MinimizeToTray;

            bouncedUsers.Clear();
            if (!string.IsNullOrWhiteSpace(settings.BounceUsers))
            {
                string[] users = settings.BounceUsers.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string user in users)
                {
                    string[] parts = user.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 1)
                    {
                        bouncedUsers.Add(new BounceUser() { UserName = parts[0], BounceReason = parts[1] });
                    }
                }
            }
            if (settings.StartMinimized)
            {
                this.MiminizeToTray();
            }
            notifyMenuRecipients.Enabled = false;
            notifyMenuRecipients.Text = "Recipients (0)";

            //using (ReceivedMailDialog d = new ReceivedMailDialog())
            //{
            //    d.ShowDialog();
            //}
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (serverStarted)
                stopServer();
            this.notifyIcon.Visible = false;

            base.OnClosing(e);
        }

        void MailServerUI_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.MiminizeToTray();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.RestoreFromTray();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.RestoreFromTray();
            }
        }

        private void MiminizeToTray()
        {
            if (this.settings.MinimizeToTray)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.notifyIcon.Visible = true;
                this.Hide();
                this.settings.StartMinimized = true;
                ShowRandomTrayHelloMessage();
                this.settings.Save();
                isInTray = true;
            }
        }

        private void ShowRandomTrayHelloMessage()
        {
            #region Messages
            DateTime now = DateTime.Now;
            TimeSpan timespan = new DateTime(now.Year, now.Month, now.Day, 18, 0, 0).Subtract(now);
            string[] helloMessages = new string[]
            {
                "Sitefinity Mail Server is running in the background!",
                "Greetings!",
                "Oh, hello there!",
                "WhazzuuuuuuuuUUUUuuuuup?!",
                "Coffee?",
                "Sintefinity Mail Server is now formatting your hard drive. This may take several minutes...",
                curVersion + " kicks ass!",
                "I have nothing to say.",
                ((timespan.Ticks > 0) ? 
                    string.Format("Hey, it's {0}! Only {1:00}:{2:00} hours til 18:00!", now.ToString("HH:mm"), timespan.Hours, timespan.Minutes+1) : 
                    string.Format("It's {0}! Why are you still working?", now.ToString("HH:mm"))
                 ),
                "Nyan Nyan Nyan Nyan Nyan Nyan Nyan Nyan Nyan",
                "Nyan!",
                "HAPPY GOLDEN!!",
                "Beer plesae!",
                "Yes, I'll have a beer, thank you.",
                "Did you know? Nyan cats fart rainbows!",
                "Nyan Cat is watching you!",
                "WTF?!",
                "Where is my hamburger?",
                "hmmmmmm",
                "Hi from your notification area!",
                "=O.O=",
                "=^.^=",
                "=^.-=",
                ":)",
                "Still here..!",
                "Minimizing, huh?",
                "I'm the best server in the world!",
                "!! ----====(({ H A P P Y   G O L D E N }))====---- !!",
                "≈≈≈≈-=^.^= Nyan Nyan Nyan Nyan Nyan Nyan Nyan",
                "Sitefinity Mail Server is deleting your porn collection. Please wait...",
                "Sitefinity Mail Server is sending your porn to the CEO. Please wait...",
                "Sitefinity Mail Server is removing your Facebook account. This may take several minutes..",
                "Sitefinity Mail Server is hacking your private messages...",
                "(*yawn*)",
                "(sun)",
                "Чалга!",
                "Sitefinity Mail Server is showing fake texts when minimized since 2012.",
                "Sitefinity Mail Server - the only mail server which doesn't really send emails!",
                "*Hiding under the sofa*",
                now.ToString("HH:mm") + "...",
                "Going under cover",
                "-{n Nyan Nyan Nyan Nyan Nyan Nyan Ny}- This may take several minutes...",
                "Hello, kitty!"
            };
            #endregion

            Random random = new Random();
            int message = random.Next(0, helloMessages.Length-1);
            notifyIcon.ShowBalloonTip(5000, curVersion, helloMessages[message], ToolTipIcon.Info);
        }

        private void RestoreFromTray()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.notifyIcon.Visible = false;
            this.settings.StartMinimized = false;
            this.settings.Save();
            isInTray = false;
        }

        #endregion

        #region UI Events & Menus

        void lblSwitchUpInactive_Click(object sender, EventArgs e)
        {
            this.SetImage(imgUp);
        }

        void lblSwitchDownInactive_Click(object sender, EventArgs e)
        {
            this.SetImage(imgDown);
        }

        void btnPic_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Y <= 60)
            {
                this.SetImage(this.imgUp);
            }
            if (((MouseEventArgs)e).Y >= 70)
            {
                this.SetImage(this.imgDown);
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            this.ShowAbout();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            messageCounter = 0;
            previousTimerMessageCount = 0;
            finalTimerMessageCount = 0;
            bounceCounter = 0;
            bouncedMessages.Clear();
            recipients.Clear();
            UpadteStatistics();
        }

        private void lblMessages_Click(object sender, EventArgs e)
        {
            this.ShowRecipients();
        }

        private void menuOptions_Click(object sender, EventArgs e)
        {
            this.ShowOptions();
        }

        private void menuAlwaysOnTop_Click(object sender, EventArgs e)
        {
            menuAlwaysOnTop.Checked = !menuAlwaysOnTop.Checked;
        }

        private void menuAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.SetAlwaysOnTop();
        }

        private void menuMinimizeToTray_Click(object sender, EventArgs e)
        {
            menuMinimizeToTray.Checked = !menuMinimizeToTray.Checked;
        }

        private void menuMinimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            this.settings.MinimizeToTray = menuMinimizeToTray.Checked;
            this.settings.Save();
        }

        private void sitefinityMailServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RestoreFromTray();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyMenuStartServer_Click(object sender, EventArgs e)
        {
            this.SetImage(imgUp);
        }

        private void notifyMenuStopServer_Click(object sender, EventArgs e)
        {
            this.SetImage(imgDown);
        }

        private void notifyMenuOptions_Click(object sender, EventArgs e)
        {
            this.ShowOptions(true);
        }

        private void notifyMenuRecipients_Click(object sender, EventArgs e)
        {
            this.ShowRecipients(true);
        }

        private void notifyMenuAbout_Click(object sender, EventArgs e)
        {
            this.ShowAbout();
        }

        #endregion

        #region Mail server event handlers

        void processor_MessageReceived(object sender, MessageEventArgs e)
        {
            messageCounter++;
            string rec = "";
            bool isBounced = false;
            foreach (EmailAddress recipient in e.Message.ToAddresses)
            {
                string bounced = "";
                BounceUser user = this.bouncedUsers.FirstOrDefault(u => u.UserName.Equals(recipient.Address, StringComparison.CurrentCultureIgnoreCase));
                if (user != null)
                {
                    isBounced = true;
                    bounced = " (bounced)";
                    bounceCounter++;
                    bouncedMessages.Add(new BouncedUserMessage(e.Message.Data, user.BounceReason));
                }
                rec += ((rec == "") ? "" : ", ") + recipient.Address + bounced;
            }
            recipients.Add(rec);
            //this.messagesReceived.Add(new UserMessage() { MessageSource = e.Message.Data, Recipient = e.Message.ToAddresses.First().Address,  IsOpened = false });
            UpadteStatistics();
            if (isInTray)
            {
                if (!messagesReceptionTimer.Enabled)
                {
                    notifyIcon.ShowBalloonTip(1000, curVersion, "Hmmmm... I'm receiving some messages...", ToolTipIcon.Info);
                    notifyIcon.Text = curVersion + ": Receving messages...";
                    messagesReceptionTimer.Start();
                }
            }
        }

        void MessageReceptionTimerElapsed()
        {
            if (isInTray)
            {
                if (messageCounter == previousTimerMessageCount)
                {
                    messagesReceptionTimer.Stop();
                    int num = messageCounter - finalTimerMessageCount;
                    string s = (num == 1) ? "" : "s";
                    notifyIcon.Text = curVersion + " (Started): " + num + " message" + s + " in fake inbox!";
                    notifyIcon.ShowBalloonTip(3000, curVersion, "I have " + num + " message" + s + " in my fake inbox!", ToolTipIcon.Info);
                }
                else
                    previousTimerMessageCount = messageCounter;
            }
            else
            {
                messagesReceptionTimer.Stop();
                finalTimerMessageCount = previousTimerMessageCount;
            }
        }

        void pop3Server_UserQuit(object sender, Pop3SessionEventArgs e)
        {
            POP3_Session session = sender as POP3_Session;
            if (session != null)
            {
                string currentUser = session.m_UserName;
                if (currentUser == this.settings.SitefinityPop3BounceTrackerUsername)
                {
                    SetText(lblCollectionLog, "[" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "] Bounced messages collected.");
                    bouncedMessages.Clear();
                    UpadteStatistics();
                    if(isInTray)
                        notifyIcon.ShowBalloonTip(5000, curVersion, "Messages collected by Sitefinity's POP3 Client!", ToolTipIcon.Info);
                }
            }
        }

        void pop3Server_UserAuthenticated(object sender, Pop3SessionEventArgs e)
        {
            POP3_Session session = sender as POP3_Session;
            if (session != null)
            {
                string currentUser = session.m_UserName;
                if (currentUser == this.settings.SitefinityPop3BounceTrackerUsername)
                {
                    for (int message = 0; message < bouncedMessages.Count; message++)
                    {
                        session.m_pMessages.Add((message + 1).ToString(), new POP3_ServerMessage((message + 1).ToString(), bouncedMessages[message].MessageData.Length) { SequenceNumber = (message + 1) });
                    }
                    session.GetMessageStream += new EventHandler<POP3_e_GetMessageStream>(delegate(object s, POP3_e_GetMessageStream ms)
                    {
                        int messageId;
                        if (int.TryParse(ms.Message.UID, out messageId))
                        {
                            ms.MessageStream = new MemoryStream(ASCIIEncoding.Default.GetBytes(bouncedMessages[messageId].MessageData));
                        }
                        //ms.MessageStream = new MemoryStream(ASCIIEncoding.Default.GetBytes(bouncedMessage));
                    });
                }
            }
        }

        #endregion

        #region Server management

        private void startServer()
        {
            if (!serverStarted)
            {
                //SMTP
                processor = new SMTPProcessor(this.settings.MailServerDomain);
                smtpServer = new SimpleSMTPServer(this.settings.SmtpServerPort, processor.ProcessConnection);
                processor.MessageReceived += new SMTPProcessor.SmtpEventHandler(processor_MessageReceived);

                Thread thread = new Thread(() => SafeExecute(() => smtpServer.Start(), MailThreadExceptionHandler));
                thread.Start();
                smtpThreadRunning = true;
                //smtpThread = new System.Threading.Thread(new ThreadStart(smtpServer.Start));
                //smtpThread.Start();

                //POP3
                pop3Server = new POP3_Server();
                pop3Server.Bindings = new POP3.Net.IPBindInfo[] 
                { 
                    new IPBindInfo(
                        "SitefinityMailServer", 
                        BindInfoProtocol.TCP, 
                        IPAddress.Any, 
                        this.settings.Pop3ServerPort) 
                };
                pop3Server.UserAuthenticated += new POP3.TCP.TCP_Server<POP3_Session>.UserAuthenticatedEventHandler(pop3Server_UserAuthenticated);
                pop3Server.UserQuit += new POP3.TCP.TCP_Server<POP3_Session>.UserQuitEventHandler(pop3Server_UserQuit);
                pop3Server.Start();

                serverStarted = true;
            }
        }

        private void MailThreadExceptionHandler(Exception exception)
        {
            if (exception is SocketException)
            {
                this.BeginInvoke(new MethodInvoker(() => ShowSocketErrorDialog_ThreadSafe((SocketException)exception)));
            }
            else
            {
                MessageBox.Show(string.Format("Failed to start SMTP server. I don't know how to solve this problem (yet).\nException info:\n\n{0}", exception.Message), "OMG");
                this.SetImage(imgDown);
            }
        }

        private void ShowSocketErrorDialog_ThreadSafe(SocketException exception)
        {
            bool optop = this.TopMost;
            this.TopMost = false;

            smtpThreadRunning = false;
            serverStarted = false;
            SetImage(imgDown);
            using (SocketErrorDialog sed = new SocketErrorDialog())
            {
                ServiceController hMailServerService = ServiceController.GetServices().FirstOrDefault(s => s.ServiceName == "hMailServer");
                bool hMailServerRunning = (hMailServerService != null && hMailServerService.Status == ServiceControllerStatus.Running);
                sed.ErrorLebel.Text = string.Format(
                    "Failed to open SMTP port {0}.\n{1}\n\nWhat would you like to do?",
                    this.settings.SmtpServerPort.ToString(),
                    (hMailServerRunning ?
                        "I have detected hMailServer service in running mode." :
                        "\nIt may be hMailServer, or another server holding this port (although I have not detected a running instance\nof hMailServer).")
                );

                sed.PortTextbox.Text = settings.SmtpServerPort.ToString();
                sed.PortTextbox.SelectAll();
                sed.PortTextbox.Focus();
                sed.StopMailServerForMe.Visible = hMailServerRunning;
                sed.StartPosition = FormStartPosition.CenterScreen;
                sed.ShowInTaskbar = false;
                sed.Height = 200;
                sed.ButtonsPanel.Top = (hMailServerRunning) ? 80 : 70;
                DialogResult result = sed.ShowDialog();
                if (hMailServerRunning && result == System.Windows.Forms.DialogResult.OK)
                {
                    hMailServerService.Stop();
                    hMailServerService.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 30));
                    if (hMailServerService.Status == ServiceControllerStatus.Stopped)
                    {
                        MessageBox.Show("hMailServer stopped successully.", "Killed the bastard!");
                        this.SetImage(imgUp);
                    }
                    else
                    {
                        MessageBox.Show("Failed to stop hMailServer.", "Damn!");
                    }
                }
                if (result == System.Windows.Forms.DialogResult.Retry)
                {
                    int newport = -1;
                    if (int.TryParse(sed.PortTextbox.Text, out newport))
                    {
                        if (newport != this.settings.SmtpServerPort)
                        {
                            this.settings.SmtpServerPort = newport;
                            this.settings.Save();
                            MessageBox.Show(string.Format("Set new SMTP port: {0}.", newport), "New port set");
                            this.UpdateInfoStrip();
                            this.SetImage(imgUp);
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Are you kidding me?\nChanging the port to the same one ({0}) won't help you much!", newport), "Are you kidding?");
                            this.MailThreadExceptionHandler(exception);
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Invalid SMTP port \"{0}\"!", sed.PortTextbox.Text), "Wait, what..?");
                        this.MailThreadExceptionHandler(exception);
                    }
                }
            }
            this.TopMost = optop;
        }

        private static void SafeExecute(Action methodToRun, Action<Exception> handler)
        {
            try
            {
                methodToRun();
            }
            catch (Exception ex)
            {
                handler(ex);
            }
        }


        private void stopServer()
        {
            if (serverStarted)
            {
                //SMTP
                smtpServer.Stop();
                if (smtpThreadRunning)
                {
                    if (smtpThread != null)
                        smtpThread.Abort();
                    smtpThreadRunning = false;
                }
                processor = null;
                smtpServer = null;

                //POP3
                pop3Server.Stop();


                serverStarted = false;
            }
        }

        #endregion

        #region Thread-safe & unsafe UI handling

        public static void SetText(Label varLabel, string newText)
        {
            if (varLabel.InvokeRequired)
            {
                varLabel.BeginInvoke(new MethodInvoker(() => SetText(varLabel, newText)));
            }
            else
            {
                varLabel.Text = newText;
            }
        }

        public static void SetVisibility(Control control, bool visibleStatus)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(new MethodInvoker(() => SetVisibility(control, visibleStatus)));
            }
            else
            {
                control.Visible = visibleStatus;
            }
        }

        public static void SetVisibility(ToolStripMenuItem control, bool visibleStatus, Control anothercontrol)
        {
            if (anothercontrol.InvokeRequired)
            {
                anothercontrol.BeginInvoke(new MethodInvoker(() => SetVisibility(control, visibleStatus, anothercontrol)));
            }
            else
            {
                control.Visible = visibleStatus;
            }
        }

        void SetImage(string embeddedResourceName)
        {
            Stream imgStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(embeddedResourceName);

            if (imgStream != null)
                this.btnPic.Image = new Bitmap(imgStream);

            if (embeddedResourceName == imgDown)
            {
                SetVisibility(this.lblSwitchDownActive, true);
                SetVisibility(this.lblSwitchDownInactive, false);
                SetVisibility(this.lblSwitchUpInactive, true);
                SetVisibility(picNyan, false);
                if (serverStarted)
                    stopServer();

                notifyIcon.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(notifyOn));
                notifyIcon.Text = curVersion + " (Stopped)";
                SetVisibility(notifyMenuStartServer, true, this.lblSwitchDownActive);
                SetVisibility(notifyMenuStopServer, false, this.lblSwitchDownActive);
            }
            else
            {
                SetVisibility(this.lblSwitchDownActive, false);
                SetVisibility(this.lblSwitchDownInactive, true);
                SetVisibility(this.lblSwitchUpInactive, false);
                SetVisibility(picNyan, true);
                if (!serverStarted)
                    startServer();

                notifyIcon.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(notifyOff));
                notifyIcon.Text = curVersion + " (Started)";
                SetVisibility(notifyMenuStartServer, false, this.lblSwitchDownActive);
                SetVisibility(notifyMenuStopServer, true, this.lblSwitchDownActive);
            }
        }

        private void UpadteStatistics()
        {
            SetText(lblMessages, string.Format("Messages processed: {0} ({1} bounced)", messageCounter, bounceCounter));
            SetText(lblCurrentPendingBounced, string.Format("[{0}] {1} bounced message{2} in the queue", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), bouncedMessages.Count.ToString(), ((bouncedMessages.Count == 1)? "" : "s")));
            notifyMenuRecipients.Enabled = messageCounter > 0;
            notifyMenuRecipients.Text = "Recipients (" + messageCounter + ")";
        }

        private void UpdateInfoStrip()
        {
            infoStrip.Text = string.Format("\"{0}\", SMTP:{1}, POP3:{2}", settings.MailServerDomain, settings.SmtpServerPort.ToString(), this.settings.Pop3ServerPort.ToString());
        }

        private void SetAlwaysOnTop()
        {
            this.TopMost = menuAlwaysOnTop.Checked;
            this.settings.AlwaysOnTop = menuAlwaysOnTop.Checked;
            this.settings.Save();
        }

        private void ShowOptions(bool inCentreScreen = false)
        {
            bool optop = this.TopMost;
            this.TopMost = false;
            using (SettingsDialog settingsWin = new SettingsDialog())
            {
                if (inCentreScreen)
                    settingsWin.StartPosition = FormStartPosition.CenterScreen;

                settingsWin.txtDomain.Text = this.settings.MailServerDomain;
                settingsWin.txtSMTPPort.Text = this.settings.SmtpServerPort.ToString();
                settingsWin.chkAutoStart.Checked = this.settings.StartServerWhenApplicationStarts;
                settingsWin.chkReallySend.Checked = this.settings.ReallySendMessage;
                settingsWin.txtPop3ServerPort.Text = this.settings.Pop3ServerPort.ToString();
                settingsWin.txtSitefinityBounce.Text = this.settings.SitefinityPop3BounceTrackerUsername;
                settingsWin.BouncesUsersList = this.settings.BounceUsers;
                DialogResult res = settingsWin.ShowDialog();
                if (res == System.Windows.Forms.DialogResult.OK)
                {
                    this.settings.MailServerDomain = settingsWin.txtDomain.Text;
                    int port = this.settings.SmtpServerPort;
                    if (int.TryParse(settingsWin.txtSMTPPort.Text, out port))
                    {
                        this.settings.SmtpServerPort = port;
                    }
                    this.settings.StartServerWhenApplicationStarts = settingsWin.chkAutoStart.Checked;
                    this.settings.ReallySendMessage = settingsWin.chkReallySend.Checked;
                    if (int.TryParse(settingsWin.txtPop3ServerPort.Text, out port))
                    {
                        this.settings.Pop3ServerPort = port;
                    }
                    this.settings.SitefinityPop3BounceTrackerUsername = settingsWin.txtSitefinityBounce.Text;
                    this.settings.BounceUsers = settingsWin.BouncesUsersList;
                    bouncedUsers.Clear();
                    bouncedUsers.AddRange(settingsWin.bounces);
                    this.settings.Save();

                    if (serverStarted)
                    {
                        stopServer();
                        startServer();
                    }
                    messageCounter = 0;
                    previousTimerMessageCount = 0;
                    bounceCounter = 0;
                    bouncedMessages.Clear();
                    recipients.Clear();
                    UpadteStatistics();
                    UpdateInfoStrip();
                }
            }
            this.TopMost = optop;
        }

        private void ShowRecipients(bool inCentreScreen = false)
        {
            bool optop = this.TopMost;
            this.TopMost = false;

            if (this.recipients.Count == 0)
            {
                MessageBox.Show("No recipients have received any messages yet.");
            }
            else
            {
                using (RecipientsDialog recipientsDialog = new RecipientsDialog())
                {
                    if (inCentreScreen)
                        recipientsDialog.StartPosition = FormStartPosition.CenterScreen;
                    recipientsDialog.listitems.AddRange(recipients);
                    recipientsDialog.ShowDialog();
                }
            }
            this.TopMost = optop;
        }

        private void ShowAbout()
        {
            bool optop = this.TopMost;
            this.TopMost = false;
            using (AboutDialog about = new AboutDialog())
            {
                about.Text = curVersion;
                about.VersionLabel.Text = curVersion;
                about.StartPosition = FormStartPosition.CenterScreen;
                about.ShowDialog();
            }
            this.TopMost = optop;
        }

        #endregion

        #region Fields and constants

        Thread smtpThread;
        SimpleSMTPServer smtpServer;
        POP3_Server pop3Server;
        SMTPProcessor processor;
        bool serverStarted = false;
        int messageCounter = 0;
        int previousTimerMessageCount = 0;
        int finalTimerMessageCount = 0;
        List<string> recipients = new List<string>();
        List<BouncedUserMessage> bouncedMessages = new List<BouncedUserMessage>();
        List<BounceUser> bouncedUsers = new List<BounceUser>();
        int bounceCounter = 0;

        private string imgDown = "SitefinityMailServer.Resources.switch_Down.png";
        private string imgUp = "SitefinityMailServer.Resources.switch_Up.png";

        private string notifyOn = "SitefinityMailServer.Resources.ServerOn.ico";
        private string notifyOff = "SitefinityMailServer.Resources.ServerOff.ico";

        bool isInTray = false;
        bool smtpThreadRunning = false;
        SitefinityMailSettings settings = new SitefinityMailSettings();
        List<UserMessage> messagesReceived = new List<UserMessage>();
        System.Timers.Timer messagesReceptionTimer = new System.Timers.Timer(6005);

        #endregion
    }
}
