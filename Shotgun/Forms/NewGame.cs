using Shotgun.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class frmNewGame : Form
    {
        public frmNewGame()
        {
            InitializeComponent();
        }
        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            frmGame frmGame = new frmGame();
            frmGame.Show();
        }
        private void cmdQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
