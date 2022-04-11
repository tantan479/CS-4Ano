using System;

namespace Q22
{

    /*
    Intermediário 22 - Faça um Programa que peça um número correspondente a um determinado ano e em seguida informe se este ano é ou não bissexto. Dica: simplificando, um ano é bissexto se ele é divisível por 4 e não é divisível por 100. Se for divisível por 100, ele só é bissexto se for divisível por 400, caso contrário, não é bissexto.
    */

    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.WriteLine("Digite um ano:");
            ano = Convert.ToInt32(Console.ReadLine());

            if((ano%4 == 0 & ano%100 != 0) || (ano%100 == 0 & ano%400 == 0))
                Console.WriteLine("O ano é bissexto");
            else
                Console.WriteLine("O ano não é bissexto");

        }
    }
}
