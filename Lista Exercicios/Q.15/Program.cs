using System;

namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double n1, n2, n3, M, m;
            
            Console.WriteLine("Número 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());
        
            // Localizano o maior
            M = n1;
            
            if(n2 > M)
               M = n2;
            if(n3 > M)
                M = n3;

            // Localizando o menor
            m = n1;

            if(n2 < m)
               m = n2;
            if(n3 < m)
                m = n3;

            Console.WriteLine($"Maior: {M}\nMenor: {m}");
        
        }
    }
}