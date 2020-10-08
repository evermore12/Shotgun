using Shotgun.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shotgun
{
    public class Game
    {
        public ComputerControlledPlayer Bot { get; set; }
        public UserControlledPlayer Player { get; set; }

        public Game()
        {
            Player = new UserControlledPlayer();
            Bot = new ComputerControlledPlayer();
        }
        public Player CheckForWinner()
        {
            if (Player.UsingShotgun)
            {
                return Player;
            }
            if (Bot.UsingShotgun)
            {
                return Bot;
            }
            if (Bot.Gun.Reloading && Player.Gun.Shooting)
            {
                return Player;
            }
            if (Player.Gun.Reloading && Bot.Gun.Shooting)
            {
                return Bot;
            }
            return null;
        }

        public void Reset()
        {
            Player.Gun.Shooting = false;
            Player.Gun.Reloading = false;
            Bot.Gun.Shooting = false;
            Bot.Gun.Reloading = false;
        }
    }
}
