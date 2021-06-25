using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class RobotAdapter : IAttacker
    {
        private Robot robot;

        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }

        public void AssignDriver(string driver)
        {
            robot.AssignDriver(driver);
        }

        public void DriveForward()
        {
            robot.DriveForward();
        }

        public void UseWeapon()
        {
            robot.DriveForward();
        }
    }
}
