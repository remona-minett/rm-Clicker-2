namespace clicker_2
{
    partial class optionsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.goOnlineButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.onlineVerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Online Version:";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(194, 12);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(101, 23);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check for Update";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // goOnlineButton
            // 
            this.goOnlineButton.Location = new System.Drawing.Point(194, 42);
            this.goOnlineButton.Name = "goOnlineButton";
            this.goOnlineButton.Size = new System.Drawing.Size(101, 23);
            this.goOnlineButton.TabIndex = 3;
            this.goOnlineButton.Text = "Open Releases";
            this.goOnlineButton.UseVisualStyleBackColor = true;
            this.goOnlineButton.Click += new System.EventHandler(this.goOnlineButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(283, 23);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made with love by Remona Minett in 2023";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2 Alpha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // onlineVerLabel
            // 
            this.onlineVerLabel.AutoSize = true;
            this.onlineVerLabel.Location = new System.Drawing.Point(100, 47);
            this.onlineVerLabel.Name = "onlineVerLabel";
            this.onlineVerLabel.Size = new System.Drawing.Size(73, 13);
            this.onlineVerLabel.TabIndex = 6;
            this.onlineVerLabel.Text = "error - no net?";
            this.onlineVerLabel.Visible = false;
            // 
            // optionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 100);
            this.Controls.Add(this.onlineVerLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.goOnlineButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "optionsWindow";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.optionsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button goOnlineButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label onlineVerLabel;
    }
}