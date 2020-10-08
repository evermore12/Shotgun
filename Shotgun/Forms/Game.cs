using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun.Forms
{
    public partial class frmGame : Form
    {
        private Game game;
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            game = new Game();
        }

        private void cmdShoot_Click(object sender, EventArgs e)
        {
            if (!game.Player.Gun.Shoot()) MessageBox.Show("Invalid choice");

            else
            {
                game.Bot.RandomMove();
                UpdateScreen();
                game.Reset();
            }

        }

        private void cmdReload_Click(object sender, EventArgs e)
        {
            game.Player.Gun.Reload();
            game.Bot.RandomMove();
            UpdateScreen();
            game.Reset();

        }

        private void cmdBlock_Click(object sender, EventArgs e)
        {
            game.Player.Block();
            game.Bot.RandomMove();
            UpdateScreen();
            game.Reset();

        }   
        
        private void cmdShotgun_Click(object sender, EventArgs e)
        {
            game.Player.Shotgun();
            game.Bot.RandomMove();
            UpdateScreen();
            game.Reset();
        }

        public void UpdateScreen()
        {
            rtxtPlayerAmmunition.Text = game.Player.Gun.Ammunition.ToString();
            rtxtOppnentAmmunition.Text = game.Bot.Gun.Ammunition.ToString();
            Player winner;
            if ((winner = game.CheckForWinner()) != null)
            {
                MessageBox.Show(winner.ToString() + " won");
                this.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(rtxtPlayerAmmunition.Text) >= 3)
            {
                cmdShotgun.Enabled = true;
            }
            else if (int.Parse(rtxtPlayerAmmunition.Text) <= 2)
            {
                cmdShotgun.Enabled = false;
            }
        }


    }
}
