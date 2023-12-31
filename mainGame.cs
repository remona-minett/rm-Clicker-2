﻿using System;
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
    { // 1 tick = 1 second
        bool shopOpen = false;
        bool vanityOpen = false;

        // click charge
        int charge1clickfill= 1; int charge2clickfill = 1;
        // shop upgrade counts - not the current price of upgrades - indexing at 0 so adding 1 when calculating price is necessary.
        int c1u1count = 0; int c1u2count = 0; int c1u3count = 0; int c1u4count = 0;
        int c2u1count = 0; int c2u2count = 0; int c2u3count = 0; int c2u4count = 0;
        int bu1count = 0; int bu2count = 0; 
        bool vanityUnlocked = false; // one-time purchase


        public mainGame()
        {
            InitializeComponent();
        }

        private void mainGame_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 300);
            startThreads();
            // insert listener for `d` key for `d`ebug options which proffers a panel of overrides
        }

        private void shopRevealButton_Click(object sender, EventArgs e)
        {
            if (shopOpen == false) // the shop is closed
            {
                shopOpen = true; shopRevealButton.Text = "Close Shop";
                Size = new Size(800, 455); // reveal shop buttons - this can comfortably be set to 600 for future use.
                c1u1.Enabled = true; c1u2.Enabled = true; c1u3.Enabled = true; c1u4.Enabled = true; // chargebar 1 upgrades
                c2u1.Enabled = true; c2u2.Enabled = true; c2u3.Enabled = true; c2u4.Enabled = true; // chargebar 2 upgrades
                bu1.Enabled = true; // bu2.Enabled = true; // batbar upgrades
            }
            else if (shopOpen == true) // the shop is open
            {
                shopOpen = false; shopRevealButton.Text = "Open Shop";
                Size = new Size(800, 300); // hide shop buttons - side effect highlights shop button again?
                c1u1.Enabled = false; c1u2.Enabled = false; c1u3.Enabled = false; c1u4.Enabled = false; // chargebar 1 upgrades
                bu1.Enabled = false; // bu2.Enabled = false; // batbar upgrades
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // todo saveload.cs due 2 Release
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
            var batteryBarThread = new Thread(batteryBar) { IsBackground = true }; batteryBarThread.Start();
            var chargeBar1Thread = new Thread(chargeBar1) { IsBackground = true }; chargeBar1Thread.Start();
            var chargeBar2Thread = new Thread(chargeBar2) { IsBackground = true }; chargeBar2Thread.Start();
            upgradeShop();
        }

        private void batteryBar()
        {
            for (; ; )
            {
                var chargeamount = 0;
                if (chargebar1.Value != 0) chargeamount++; // discharge upgrade - ensure enough is in the bar else you generate free power
                if (chargebar2.Value != 0) chargeamount++; // discharge upgrade - ensure enough is in the bar else you generate free power
                Invoke((MethodInvoker)delegate
                {
                    batbar.Step = chargeamount;
                    batbar.PerformStep();
                    batbarvalue.Text = batbar.Value.ToString(); // write current charge
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
                    // autocharge comes first before !=0 maths
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
                    // autocharge comes first before !=0 maths
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

        private void upgradeShop() // index +1 for pricing only. call upgradeshop to recalculate values on click of upgrade button.
        {
            // behaviour
            chargebar1.Maximum = 10 + (c1u1count * 10); // bar size
            charge1clickfill = 1 + (c1u2count); // click power
            chargebar2.Maximum = 10 + (c2u1count * 10);
            charge2clickfill = 1 + (c2u2count);
            // cXu3 math done in chargebar and batbar calculations
            // cXu4 math done in chargebar calculations
            // pricing, 2nd cb intended to be 2x price to disjoint upgrades
            var c1u1price = (20 * (c1u1count + 1)).ToString();
            var c2u1price = (40 * (c2u1count + 1)).ToString();
            var c1u2price = (40 * (c1u2count + 1)).ToString();
            var c2u2price = (80 * (c2u2count + 1)).ToString();
            var c1u3price = (100 * (c1u3count + 1)).ToString();
            var c2u3price = (200 * (c2u3count + 1)).ToString();
            var c1u4price = (200 * (c1u4count + 1)).ToString();
            var c2u4price = (400 * (c2u4count + 1)).ToString();
            var bu1price = batbar.Maximum.ToString();
            // var bu2price = 
            c1u1.Text = c1u1price; c2u1.Text = c2u1price;
            c1u2.Text = c1u2price; c2u2.Text = c2u2price;
            c1u3.Text = c1u3price; c2u3.Text = c2u3price;
            c1u4.Text = c1u4price; c2u4.Text = c2u4price;
            bu1.Text = bu1price; // always the max capacity
            // bu2.Text = bu2price;
            // vanityUnlock.Text = "???" // doesn't need maths since it is one-time
            return;
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

        private void c1u1_Click(object sender, EventArgs e)
        {
            // add to purchase count, then call upgradeshop to reprice and recalculate upgrades. freeze the button until return after clicking to prevent bypassing checks and allow time for the process to tick.
            c1u1.Enabled = false;
            c1u1count++;
            upgradeShop();
            c1u1.Enabled = true;
        }

        private void c1u2_Click(object sender, EventArgs e)
        {
            c1u2.Enabled = false;
            c1u2count++;
            upgradeShop();
            c1u2.Enabled = true;
        }

        private void c1u3_Click(object sender, EventArgs e)
        {
            c1u3.Enabled = false;
            c1u3count++;
            upgradeShop();
            c1u3.Enabled = true;
        }

        private void c1u4_Click(object sender, EventArgs e)
        {
            c1u4.Enabled = false;
            c1u4count++;
            upgradeShop();
            c1u4.Enabled = true;
        }

        private void c2u1_Click(object sender, EventArgs e)
        {
            c2u1.Enabled = false;
            c2u1count++;
            upgradeShop();
            c2u1.Enabled = true;
        }

        private void c2u2_Click(object sender, EventArgs e)
        {
            c2u2.Enabled = false;
            c2u2count++;
            upgradeShop();
            c2u2.Enabled = true;
        }

        private void c2u3_Click(object sender, EventArgs e)
        {
            c2u3.Enabled = false;
            c2u3count++;
            upgradeShop();
            c2u3.Enabled = true;
        }

        private void c2u4_Click(object sender, EventArgs e)
        {
            c2u4.Enabled = false;
            c2u4count++;
            upgradeShop();
            c2u4.Enabled = true;
        }

        private void bu1_Click(object sender, EventArgs e)
        {
            bu1.Enabled = false;
            bu1count++;
            upgradeShop();
            bu1.Enabled = true;
        }

        private void vanityUnlock_Click(object sender, EventArgs e)
        {
            // process vanity code here
        }
    }
}
