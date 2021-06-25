using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            string weapon = "Shooting an arrow with a bow";
            return weapon;
        }
    }
}
