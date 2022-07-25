using System;
using System.Collections.Generic;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            List<int> n1 = new List<int>();
            List<int> n2 = new List<int>();
            List<int> n3 = new List<int>();

            for(int i=0; i<5; i++){
                n1.Add(random.Next(1,100));
                n2.Add(random.Next(1,100));
                n3.Add(n1[i] + n2[i]);
            }

            Console.WriteLine(String.Join(", ", n3));

        }
    }
}
