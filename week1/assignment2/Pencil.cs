using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;

        public Pencil()
        {
            this.maxToWrite = 15;
            this.nrOfCharsWritten = 0;
        }

        public bool CanWrite => maxToWrite >= 0;

        public void AfterSharpening()
        {
            maxToWrite = 17;
        }

        public void Write(string message)
        {
            if (message.ToLower() == "stop")
                return;

            foreach (char character in message)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                if (!CanWrite) { Console.Write("#"); Console.ResetColor(); continue; }
                if (Char.IsWhiteSpace(character)) { Console.Write(character); Console.ResetColor(); continue; }

                nrOfCharsWritten++;
                Console.Write(character);
                --maxToWrite;
            }

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
