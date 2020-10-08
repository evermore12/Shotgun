using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public class Gun
    {
        public int Ammunition { get; set; }
        public bool Shooting { get; set; }
        public bool Reloading { get; set; }

        public void Reload()
        {
            Ammunition++;
            Reloading = true;
        }
        public bool Shoot()
        {
            if (Ammunition > 0)
            {
                Ammunition--;
                Shooting = true;
                return true;
            }
            else return false;
        }
    }
}
