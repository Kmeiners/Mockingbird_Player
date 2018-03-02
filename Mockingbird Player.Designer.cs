namespace MusicProgram
{
    partial class Player
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
            this.songListBox = new System.Windows.Forms.ListBox();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songListBox
            // 
            this.songListBox.FormattingEnabled = true;
            this.songListBox.Items.AddRange(new object[] {
            "Song 1",
            "Song 2",
            "Song 3",
            "Song 4"});
            this.songListBox.Location = new System.Drawing.Point(12, 68);
            this.songListBox.Name = "songListBox";
            this.songListBox.Size = new System.Drawing.Size(521, 212);
            this.songListBox.TabIndex = 1;
            // 
            // playPauseButton
            // 
            this.playPauseButton.Image = global::MusicProgram.Properties.Resources.mockingplay;
            this.playPauseButton.Location = new System.Drawing.Point(68, 12);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(50, 50);
            this.playPauseButton.TabIndex = 2;
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Image = global::MusicProgram.Properties.Resources.mockingprev;
            this.previousButton.Location = new System.Drawing.Point(12, 12);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(50, 50);
            this.previousButton.TabIndex = 3;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Image = global::MusicProgram.Properties.Resources.mockingnext;
            this.nextButton.Location = new System.Drawing.Point(124, 12);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(50, 50);
            this.nextButton.TabIndex = 4;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 291);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.songListBox);
            this.Name = "Player";
            this.Text = "Mockingbird Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox songListBox;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
    }
}

