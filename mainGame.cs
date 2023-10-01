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
        public mainGame()
        {
            InitializeComponent();
        }

        private void mainGame_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 300);
            //startThreads();
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
            batteryBar();
            chargeBar1();
            chargeBar2();
            upgradeShop();
        }

        private void batteryBar()
        {
            for (; ; )
            {
                var v = 0;
                // logic needs to include discharge upgrade
            }
        }

        private void chargeBar1()
        {

        }

        private void chargeBar2()
        {

        }

        private void upgradeShop()
        {

        }
    }
}
