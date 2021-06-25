using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class AxeBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            string weapon = "Chopping with an axe";
            return weapon;
        }
    }
}
