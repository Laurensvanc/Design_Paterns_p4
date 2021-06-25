using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class KnifeBehaviour : IWeaponBehaviour
    {
        public string UseWeapon()
        {
            string weapon = "Cutting with a knife";
            return weapon;
        }
    }
}
