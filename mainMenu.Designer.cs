namespace clicker_2
{
    partial class mainMenu
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
            this.loadGame = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadGame
            // 
            this.loadGame.ForeColor = System.Drawing.SystemColors.Control;
            this.loadGame.Location = new System.Drawing.Point(93, 41);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(75, 23);
            this.loadGame.TabIndex = 2;
            this.loadGame.Text = "Load Game";
            this.loadGame.UseVisualStyleBackColor = true;
            this.loadGame.Click += new System.EventHandler(this.loadGame_Click);
            // 
            // newGame
            // 
            this.newGame.ForeColor = System.Drawing.SystemColors.Control;
            this.newGame.Location = new System.Drawing.Point(93, 12);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 23);
            this.newGame.TabIndex = 1;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.optionsButton.Location = new System.Drawing.Point(93, 70);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 3;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(261, 102);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.loadGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Clicker 2 Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button optionsButton;
    }
}

