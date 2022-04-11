using System;

namespace Q14
{

    /*
    Intermediário 14 - Faça um programa que leia três números, verifique (usando if e else), e mostre o maior deles.
    */

    class Program
    {
        static void Main(string[] args)
        {
            
            double n1, n2, n3, m;
            
            Console.WriteLine("Número 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            m = n1;
            
            if(n2 > m)
               m = n2;
            if(n3 > m)
                m = n3;
            
            Console.WriteLine($"O maior número é: {m}");


        }
    }
}