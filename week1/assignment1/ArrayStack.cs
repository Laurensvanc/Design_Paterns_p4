using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class ArrayStack : IStack
    {
        public static int max { get; set; }
        int[] stack;

        public ArrayStack(int inputMax)
        {
            max = inputMax;
            stack = new int[max];
            Count = 0;
        }

        public int Count { get; set; }

        public bool IsEmpty 
        {
            get
            {
                return Count == 0;
            }
        }

        public void Push(int value)
        {
            if (Count > max)
                throw new Exception("Stack is full");

            stack[++Count] = value;
        }

        public int Pop()
        {
            if (Count == 0)
                throw new Exception("Stack is empty");

            int item = stack[Count];
            stack = stack.Take(stack.Count() - 1).ToArray();
            Count--;

            return item;
        }

        public bool Contains(int value)
        {
            return stack.Contains(value);
        }
    }
}
