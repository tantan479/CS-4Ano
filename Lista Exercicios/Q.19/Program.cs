using System;

namespace Q18
{

    /*
    Complemente o algoritmo anterior para que ele mostre na tela “APROVADO” se o conceito for A, B ou C e “REPROVADO” se o conceito for D ou E.
    */

    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, m;
            char c;

            Console.WriteLine("Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            m = (n1+n2)/2;

            if(m>= 9){
                c = 'A';
            }else if(m>= 7.5){
                c = 'B';
            }else if(m>= 6.0){
                c = 'C';
            }else if(m>= 4.0){
                c = 'D';
            }else{
                c = 'E';
            }

            if(c == 'A' | c == 'B' | c == 'C') 
                Console.WriteLine($"APROVADO com conceito {c}");
            else
                Console.WriteLine($"REPROVADO com conceito {c}");

        }
    }
}

