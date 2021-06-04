using System;

namespace LINQ_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 100, 30, 20, 40, 80, 50, 10, 60, 70, 90 };
            int count = 0;
            foreach (int x in a)
            {
                if (x >= 50)
                    count += 1;
            }
            int[] b = new int[count];
            int index = 0;
            foreach (int x in a)
            {
                if (x >= 50)
                {
                    b[index] = x;
                    index++;
                }
            }
            Array.Sort(b);
            Array.Reverse(b);
            foreach (int x in b)
                Console.Write(x + " ");
            Console.ReadLine();
        }
    }
}
