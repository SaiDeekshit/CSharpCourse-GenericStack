using System;
using System.Collections.Generic;

namespace GenericStack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack<string> stackList = new Stack<string>();

            stackList.Push("AAA");
            stackList.Push("BBB");
            stackList.Push("CCC");
            stackList.Push("DDD");
            stackList.Push("EEE");

            Console.WriteLine("What is on the top is " + stackList.Peek());
            stackList.Pop();
            stackList.Pop();
            Console.WriteLine("What is on the top is " + stackList.Peek());
            foreach (var item in stackList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
