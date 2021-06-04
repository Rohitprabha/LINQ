using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
            //LINQ Query using Query Syntax
            var QuerySyntax = from obj in integerList where obj > 5 select obj;

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
