using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            main.Start();
        }

        void Start()
        {
            IAttacker Tank = new Tank();
            Robot Robot = new Robot();

            List<IAttacker> attackers = new List<IAttacker>();

            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine($"Driver of attacker: {attacker}");
                attacker.DriveForward();
                attacker.UseWeapon();
            }
        }
    }
}
