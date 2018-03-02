namespace MusicProgram
{
    partial class MockingbirdLauncher
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
            this.playerLaunchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.directoryButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.informationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerLaunchButton
            // 
            this.playerLaunchButton.Location = new System.Drawing.Point(12, 12);
            this.playerLaunchButton.Name = "playerLaunchButton";
            this.playerLaunchButton.Size = new System.Drawing.Size(101, 23);
            this.playerLaunchButton.TabIndex = 0;
            this.playerLaunchButton.Text = "Launch Player";
            this.playerLaunchButton.UseVisualStyleBackColor = true;
            this.playerLaunchButton.Click += new System.EventHandler(this.playerLaunchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 70);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // directoryButton
            // 
            this.directoryButton.Location = new System.Drawing.Point(12, 41);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(101, 23);
            this.directoryButton.TabIndex = 1;
            this.directoryButton.Text = "Change Directory";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // informationTextBox
            // 
            this.informationTextBox.Location = new System.Drawing.Point(119, 12);
            this.informationTextBox.Multiline = true;
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.ReadOnly = true;
            this.informationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.informationTextBox.Size = new System.Drawing.Size(260, 179);
            this.informationTextBox.TabIndex = 4;
            this.informationTextBox.TabStop = false;
            // 
            // MockingbirdLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 203);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.informationTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playerLaunchButton);
            this.Name = "MockingbirdLauncher";
            this.Text = "Mockingbird Launcher";
            this.Load += new System.EventHandler(this.MockingbirdLauncher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playerLaunchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button directoryButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox informationTextBox;
    }
}

