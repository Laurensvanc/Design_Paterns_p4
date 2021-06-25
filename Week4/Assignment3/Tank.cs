using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Tank : IAttacker
    {
        Random rnd = new Random();
        public void AssignDriver(string driver)
        {
            Console.WriteLine($"Driver of attacker: {driver}");
        }

        public void DriveForward()
        {
            int nmb = rnd.Next(1, 10);
            Console.WriteLine("Tank moves foward");
        }

        public void UseWeapon()
        {
            int nmb = rnd.Next(1, 10);
            Console.WriteLine("Tank causes damage with weapon");
        }
    }
}
