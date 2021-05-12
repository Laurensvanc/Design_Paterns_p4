using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class BigDataLoader
    {
        public void InitETL() 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces started]");
            Console.ResetColor();

            Extract();
            Transform();
            Load();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[ETL-proces finished]");
            Console.ResetColor();
        }

        public abstract void Extract();
        public abstract void Transform();
        public void Load() 
        {
            Console.WriteLine("loading transformed data...");
        }
    }
}
