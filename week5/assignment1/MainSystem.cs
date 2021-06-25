using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class MainSystem
    {
        private Logger _logger;
        public SubSystem subsystem;

        public void DoSomeMainWork()
        {
            _logger.Log("MainSystem", "doing some main work");
        }

        public MainSystem()
        {
            _logger = Logger.GetInstance();
            subsystem = new SubSystem();
        }
    }
}
