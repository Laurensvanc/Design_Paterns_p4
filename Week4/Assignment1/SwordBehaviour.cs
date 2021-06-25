using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SwordBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            string weapon = "Swinging a sword";
            return weapon;
        }
    }
}
