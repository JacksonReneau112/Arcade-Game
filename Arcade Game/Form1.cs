using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Arcade_Game
{
    public partial class ArcadeGame : Form
    {
        public ArcadeGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            NewGameLabel.Text = "Game Sarting In : 3";
            PlayGameButton.Visible = false;
            NewGameLabel.Location = new Point(12, 172);

            Refresh();
            Thread.Sleep(1000);

            NewGameLabel.Text = "Game Sarting In : 2";

            Refresh();
            Thread.Sleep(1000);

            NewGameLabel.Text = "Game Sarting In : 1";

            Refresh();
            Thread.Sleep(1000);

            NewGameLabel.Text = "GO!";
            this.BackColor = Color.Green;
            
        }
    }
}
