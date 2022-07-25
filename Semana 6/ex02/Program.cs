using System;
using System.Collections.Generic;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> n1 = new List<int>();
            List<int> n2 = new List<int>();
            List<int> n3 = new List<int>();

            for(int i=0; i<5; i++){
                
                Console.WriteLine($"Número {i+1}, Lista 1:");
                n1.Add(Convert.ToInt32(Console.ReadLine()));
                
                Console.WriteLine($"Número {i+1}, Lista 2:");
                n2.Add(Convert.ToInt32(Console.ReadLine()));

                Console.Clear();
                
                n3.Add(n1[i] + n2[i]);

            }

            Console.WriteLine(String.Join(", ", n3));

        }
    }
}
