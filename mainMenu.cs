using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace clicker_2
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            // var tutorial = new tutorial(); // not implemented
            // tutorial.Show()
            // --- skipcode ---
            var game = new mainGame();
            game.FormClosed += new FormClosedEventHandler(formClosed); // listen for game close
            game.Show();
            // --- end skipcode ---
            this.Visible = false;
        }

        private void loadGame_Click(object sender, EventArgs e)
        {

        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            var options = new optionsWindow();
            options.Show();
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); // kill invisible main menu / prevents memory leak
        }
    }
}

/*
 * 
 * Originally created by Remona Minett, 30 Sep 2023
 * Windows Forms Application (WFA)
 * .NET Framework 4.7.2
 * Sequel to rm-Clicker, which turned out to be a demo in the eye of Clicker 2.
 * 
 */