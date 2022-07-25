using System;
using System.Collections.Generic;
using System.Linq;

namespace Semana_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int[] valores = new int[5];
            // Array.Resize(ref valores, 10); // gera lixo

            List<int> valores = new List<int>();

            valores.Add(10);
            valores.Add(3);
            valores.Add(7);
            valores.Add(11);
            Console.WriteLine(String.Join(',', valores)); // 10,3,7,11
            valores.Insert(1, 6);
            Console.WriteLine(String.Join(',', valores)); // 10,6,3,7,11
            valores[4] = 8;
            Console.WriteLine(String.Join(',', valores)); // 10,6,3,7,8
            valores.Remove(3);
            Console.WriteLine(String.Join(',', valores)); // 10,6,7,8
            valores.RemoveAt(3);
            Console.WriteLine(String.Join(',', valores)); // 10,6,7
            valores.AddRange(new int[] {8, 3, 5});
            Console.WriteLine(String.Join(',', valores)); // 10,6,7,8,3,5
            valores.Sort();
            Console.WriteLine(String.Join(',', valores)); // 3,5,6,7,8,10
            valores.Reverse();
            Console.WriteLine(String.Join(',', valores)); // 10,8,7,6,5,3


            // 

            Console.WriteLine($"Posição do 7: {valores.IndexOf(7)}"); // 2
            valores.Insert(4, 8);
            Console.WriteLine(String.Join(',', valores)); // 10,8,8,6,8,3,5
            Console.WriteLine($"Posição do 7: {valores.IndexOf(8)}"); // 1
            Console.WriteLine($"Posição do 7: {valores.LastIndexOf(8)}"); // 4

            int soma = 0;

            foreach (var item in valores)
            {
                soma +=item;   
            }
            Console.WriteLine($"A soma é {soma}"); // 47
            Console.WriteLine($"A soma é {valores.Sum()}"); // 47
            Console.WriteLine($"A média é {valores.Average()}"); // 6,
            Console.WriteLine($"A maior valor é {valores.Max()}"); // 10
            Console.WriteLine($"A maior valor é {valores.Min()}"); // 3
            Console.WriteLine($"A maior valor é {valores.Count()}"); // 7


            List<int> valores1 = new List<int>();
            List<int> valores2 = new List<int>();
            List<int> soma12 = new List<int>();

            valores1.AddRange(new int[] {8,5,6,8,4,5,2,1,2,5});
            valores2.AddRange(new int[] {5,8,6,4,8,4,6,8,7,5});
            soma12.Add(valores1.Sum() + valores2.Sum());


        }
    }
}
