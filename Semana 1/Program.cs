using System;

namespace Semana_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("-----------");

            Console.WriteLine("Escreva um número: ");
            string e1 = Console.ReadLine();
            Console.WriteLine("Escreva um número: ");
            string e2 = Console.ReadLine();

            int x = Convert.ToInt32(e1);
            int y = Convert.ToInt32(e2);
            int soma = x + y;
            int sub = x - y;
            int mul = x*y;

            if (y == 0){
                Console.WriteLine("Impossível dividir por zero");
            }else{
                double div = x/(double)y;
                Console.WriteLine($"A divisão de {x} por {y} é {div:F2}");
            }

            Console.WriteLine($"A soma de {x} e {y} é {soma}");
            Console.WriteLine($"A subtração de {x} por {y} é {sub}");
            Console.WriteLine($"A multiplicação de {x} por {y} é {mul}");
        }
    }
}
