using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

namespace clicker_2
{
    public partial class optionsWindow : Form
    {
        public optionsWindow()
        {
            InitializeComponent();
        }

        private void optionsWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try { Process.Start("https://github.com/remona-minett"); }
            catch(Exception) { /* do nothing about it if there is no default browser association */ }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                client.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                try 
                { 
                    onlineVerLabel.Text = client.DownloadString("https://raw.githubusercontent.com/remona-minett/rm-Clicker-2/master/ver.txt"); 
                    onlineVerLabel.Visible = true;
                }
                catch (Exception)
                {
                    onlineVerLabel.Text = "no net?";
                    onlineVerLabel.Visible = true;
                }
            }
        }

        private void goOnlineButton_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text != "Thank You") { label3.Text = "Thank You"; }
            else { label3.Text = "Enjoy Playing"; }
        }
    }
}
