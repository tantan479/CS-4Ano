using System;
using System.Collections.Generic;
using System.Linq;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n1 = new List<int>(){4, 5 ,8 ,5 ,4};

            Console.WriteLine($"A soma é: {n1.Sum()}" );
            Console.WriteLine($"A média é: {n1.Average()}");
            Console.WriteLine($"O maior valor é: {n1.Max()}");
            Console.WriteLine($"O menor valor é: {n1.Min()}");

        }
    }
}
