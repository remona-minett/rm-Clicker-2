using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace clicker_2
{
    public partial class mainGame : Form
    {
        bool shopOpen = false;
        bool vanityOpen = false;

        // click charge
        int charge1clickfill= 1; int charge2clickfill = 1;
        //

        public mainGame()
        {
            InitializeComponent();
        }

        private void mainGame_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 300);
            startThreads();
        }

        private void shopRevealButton_Click(object sender, EventArgs e)
        {
            if (shopOpen == false) // the shop is closed
            {
                shopOpen = true; shopRevealButton.Text = "Close Shop";
                Size = new Size(800, 455); // reveal shop buttons - this can comfortably be set to 600 for future use.
                // enable shop buttons here
            }
            else if (shopOpen == true) // the shop is open
            {
                shopOpen = false; shopRevealButton.Text = "Open Shop";
                Size = new Size(800, 300); // hide shop buttons
                // disable shop buttons here
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void vanityShowButton_Click(object sender, EventArgs e)
        {
            if (vanityOpen == false)
            {
                vanityOpen = true; vanityShowButton.Text = "Hide Vanity Options";
                vanity1Label.Visible = true; vanity2Label.Visible = true; vanity1RedButton.Visible = true; vanity2RedButton.Visible = true; vanity1GreenButton.Visible = true; vanity2GreenButton.Visible = true; vanity1BlueButton.Visible = true; vanity2BlueButton.Visible = true; vanity1PurpleButton.Visible = true; vanity2PurpleButton.Visible = true; vanity1OrangeButton.Visible = true; vanity2OrangeButton.Visible = true; vanity1YellowButton.Visible = true; vanity2YellowButton.Visible = true;
            }
            else if (vanityOpen == true)
            {
                vanityOpen = false; vanityShowButton.Text = "Show Vanity Options";
                vanity1Label.Visible = false; vanity2Label.Visible = false; vanity1RedButton.Visible = false; vanity2RedButton.Visible = false; vanity1GreenButton.Visible = false; vanity2GreenButton.Visible = false; vanity1BlueButton.Visible = false; vanity2BlueButton.Visible = false; vanity1PurpleButton.Visible = false; vanity2PurpleButton.Visible = false; vanity1OrangeButton.Visible = false; vanity2OrangeButton.Visible = false; vanity1YellowButton.Visible = false; vanity2YellowButton.Visible = false;
            }
        }

        private void startThreads()
        {
            var batteryBarThread = new Thread(batteryBar); batteryBarThread.IsBackground = true; batteryBarThread.Start();
            var chargeBar1Thread = new Thread(chargeBar1); chargeBar1Thread.IsBackground = true; chargeBar1Thread.Start();
            var chargeBar2Thread = new Thread(chargeBar2); chargeBar2Thread.IsBackground = true; chargeBar2Thread.Start();
            var upgradeShopThread = new Thread(upgradeShop); upgradeShopThread.IsBackground = true; upgradeShopThread.Start();
        }

        private void batteryBar()
        {
            for (; ; )
            {
                var chargeamount = 0;
                if (chargebar1.Value != 0) chargeamount++; // discharge upgrade
                if (chargebar2.Value != 0) chargeamount++; // discharge upgrade
                Invoke((MethodInvoker)delegate
                {
                    batbar.Step = chargeamount;
                    batbar.PerformStep();
                    batbarvalue.Text = batbar.Value.ToString();
                });
                Thread.Sleep(1000);
            }
        }

        private void chargeBar1()
        {
            for (; ; )
            {
                Invoke((MethodInvoker)delegate
                {
                    if (chargebar1.Value != 0)
                    {
                        if (batbar.Value != batbar.Maximum) // battery full = pause
                        {
                            chargebar1.Step = -1; // discharge upgrade
                            chargebar1.PerformStep();
                        }
                    }
                });
                Thread.Sleep(1000);
            }
        }

        private void chargeBar2()
        {
            for (; ; )
            {
                Invoke((MethodInvoker)delegate
                {
                    if (chargebar2.Value != 0)
                    {
                        if (batbar.Value != batbar.Maximum)
                        {
                            chargebar2.Step = -1; // discharge upgrade
                            chargebar2.PerformStep();
                        }
                    }
                });
                Thread.Sleep(1000);
            }
        }

        private void upgradeShop()
        {

        }

        private void chargebar1_Click(object sender, EventArgs e)
        {
            chargebar1.Step = charge1clickfill;
            chargebar1.PerformStep();
        }

        private void chargebar2_Click(object sender, EventArgs e)
        {
            chargebar2.Step = charge2clickfill;
            chargebar2.PerformStep();
        }
    }
}
