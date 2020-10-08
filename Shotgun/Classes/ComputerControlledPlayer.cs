using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Shotgun
{
    public class ComputerControlledPlayer : Player
    {
        public void RandomMove()
        {
            Random randomNumberGenerator = new Random();
            bool validChoice = false;
            while (!validChoice)
            {
                int randomNumber = randomNumberGenerator.Next(1, 5);

                if (randomNumber == 1 && Gun.Ammunition > 0)
                {
                    Gun.Shoot();
                    validChoice = true;
                }
                else if (randomNumber == 2)
                {
                    Gun.Reload();
                    validChoice = true;
                }
                else if (randomNumber == 3)
                {
                    Block();
                    validChoice = true;
                }
                else if(randomNumber == 4 && Gun.Ammunition >= 3)
                {
                    Shotgun();
                    validChoice = true;
                }
            }
            
        }
    }
}
