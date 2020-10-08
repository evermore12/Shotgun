using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public abstract class Player 
    {
        public Gun Gun { get; set; }
        public bool UsingShotgun { get; set; }

        public Player()
        {
            Gun = new Gun();
        }
        public void Block()
        {

        }
        public void Shotgun()
        {
            UsingShotgun = true;
        }
        public override string ToString()
        {
            string withNamespace =  base.ToString();
            string withoutNamespace = withNamespace.Substring(withNamespace.IndexOf('.') + 1);
            return withoutNamespace;
        }

    }
}
