using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace SitefinityMailServer
{
    public partial class ReceivedMailDialog : Form
    {
        public ReceivedMailDialog()
        {
            InitializeComponent();
            lstEmails.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(lstEmails_ItemSelectionChanged);
        }

        void lstEmails_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            il.Images[e.ItemIndex] = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("SitefinityMailServer.Resources.Mail_Open.png"));
        }

        ImageList il = new ImageList();

        private void ReceivedMailDialog_Load(object sender, EventArgs e)
        {
            Stream imgStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SitefinityMailServer.Resources.Mail_Closed.png");

            il.Images.Add(new Bitmap(imgStream));
            il.Images.Add(new Bitmap(imgStream));
            il.Images.Add(new Bitmap(imgStream));
            lstEmails.SmallImageList = il;

            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(new System.Windows.Forms.ListViewItem.ListViewSubItem()
            {
                Text = "mmm",
                ForeColor = Color.AliceBlue
            });
            lvi.ImageIndex = 0;
            lvi.Text = "   hi";
            lstEmails.Items.Add(lvi);

            ListViewItem lvi2 = new ListViewItem();
            lvi2.ImageIndex = 1;
            lvi2.Text = "   hi2";
            lstEmails.Items.Add(lvi2);
            
            ListViewItem lvi3 = new ListViewItem();
            lvi3.ImageIndex = 2;
            lvi3.Text = "   hi3";
            lstEmails.Items.Add(lvi3);
            lstEmails.Columns[0].Width = lstEmails.Width -7;
            /*
ImageList il = new ImageList();
il.Images.Add("test1", Image.FromFile(@"c:\Documents\SharpDevelop Projects\learning2\learning2\Koala.jpg"));

listView1.View = View.LargeIcon;
listView1.LargeImageList = il;
listView1.Items.Add("test");

for(int i = 0; i < il.Images.Count; i++)
{
    ListViewItem lvi = new ListViewItem();
    lvi.ImageIndex = i;
    lvi.Text="koala 1";
    listView1.Items.Add(lvi);
}           
             */
            //lstEmails.Items.Add()
        }
    }
}
