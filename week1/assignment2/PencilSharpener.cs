using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("sharpening the pencil...");
            pencil.AfterSharpening();

            Console.ResetColor();
        }
    }
}
