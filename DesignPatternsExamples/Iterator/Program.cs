using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            var iterator = list.Iterator;

            while (!iterator.IsComplete)
            {
                var n = iterator.Next();
                Console.WriteLine(n.ToString());
            }

            Console.ReadLine();
        }
    }
}
