using System;
using System.Linq;

namespace LINQ_Example_1
{
    class LinqClass
    {
        static void Main()
        {
            int[] a = { 100, 30, 20, 40, 80, 50, 10, 60, 70, 90 };
            var b = from i in a where i >= 50 orderby i descending select i;
            foreach (int x in b)
                Console.Write(x + " ");
            Console.ReadLine();
        }
    }
}
