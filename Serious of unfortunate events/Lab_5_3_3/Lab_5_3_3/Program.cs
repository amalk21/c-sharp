using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_3_3
{
    class Program
    {
        static void Main(string[] args)
        {


            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            Console.WriteLine("No. of elements in Stack: {0}", myStack.Count);

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek());
                Console.WriteLine(myStack.Peek());
            }

            Console.WriteLine("Popping : " + myStack.Pop());
            Console.WriteLine(myStack.Peek());

            Console.WriteLine("No. of elements in Stack: {0}", myStack.Count);


        }
    }
}
