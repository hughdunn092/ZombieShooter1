﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooter1
{
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gameScreen = new GameScreen();
            f.Controls.Add(gameScreen);

            gameScreen.Location = new Point((this.Width - gameScreen.Width) / 2, (this.Height - gameScreen.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
