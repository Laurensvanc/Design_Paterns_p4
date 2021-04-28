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

        void Start()
        {
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            CheckValues(myStack);
            ProcessValue(myStack);
        }

        void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = rnd.Next(1, 100);
                stack.Push(value);
                Console.WriteLine($"pushed {value,2}, new count: {stack.Count}");
            }

            Console.WriteLine();
        }

        void CheckValues(IStack stack) 
        {
            int input;

            do
            {
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());

                if (input == 0) { Console.WriteLine(); continue; }

                if (stack.Contains(input)) 
                {
                    Console.WriteLine($"stack contains value {input}"); 
                    continue;
                }

                Console.WriteLine($"stack does not contain value {input}");

            }
            while (input != 0);
        }

        void ProcessValue(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value,2}, new count: {stack.Count}");
            }
        }
    }
}
