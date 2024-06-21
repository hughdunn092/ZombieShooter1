namespace ZombieShooter1
{
    partial class EndScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Playbill", 48F);
            this.exitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.Location = new System.Drawing.Point(793, 460);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(448, 188);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Playbill", 48F);
            this.playButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.Location = new System.Drawing.Point(146, 460);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(448, 188);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endLabel.Font = new System.Drawing.Font("Playbill", 150F);
            this.endLabel.ForeColor = System.Drawing.Color.DarkKhaki;
            this.endLabel.Location = new System.Drawing.Point(119, 116);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(1158, 255);
            this.endLabel.TabIndex = 9;
            this.endLabel.Text = "GAME OVER";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZombieShooter1.Properties.Resources.deathImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(1386, 1017);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label endLabel;
    }
}
