using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            main.Start();
        }

        private void Start()
        {
            Logger logger = Logger.GetInstance();
            MainSystem mainSystem = new MainSystem();

            logger.Log("main", "starting");

            mainSystem.DoSomeMainWork();
            mainSystem.subsystem.DoSomeWork();
            mainSystem.subsystem.DoSomeMoreWork();

            logger.Log("main", "finishing");

            Console.ReadKey();
        }
    }
}
