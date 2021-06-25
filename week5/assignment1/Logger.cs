using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Logger
    {
        private int numberOfLines = 0;
        private static Logger uniqueInstance;

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Logger();

            return uniqueInstance;
        }

        public void Log(string system, string log)
        {
            numberOfLines++;
            Console.WriteLine(String.Format("{0} - [{1}] {2}", numberOfLines, system, log));
        }

        private Logger() { }
    }
}
