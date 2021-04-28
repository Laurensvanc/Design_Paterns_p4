using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            Console.ResetColor();
            main.Start();
        }

        void Start()
        {
            Console.ResetColor();
            IPencil pencil = new Pencil();
            WriteTillStop(pencil);

            Console.WriteLine("\nend of program...");
            Console.ReadKey();
        }

        void WriteTillStop(IPencil pencil)
        {
            PencilSharpener sharpener = new PencilSharpener();
            string input = "";

            do
            {
                Console.Write("Enter a word: ");
                input = Console.ReadLine();

                if (input.ToLower() == "stop")
                    continue;

                if (input.ToLower() == "sharpen") { sharpener.Sharpen(pencil); continue; }
                    

                pencil.Write(input);
            } while (input.ToLower() != "stop");
        }
    }
}
