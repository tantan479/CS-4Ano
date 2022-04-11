using System;

namespace Q13
{

    /*
    Fácil 13 - Crie um programa que peça um número ao usuário e armazene ele na variável x. Depois peça outro número e armazene na variável y. Mostre esses números. Em seguida, faça com que x passe a ter o valor de y, e que y passe a ter o valor de x.
    */

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Digite um número para armazená-lo em x: ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número para armazená-lo em y: ");
            var y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Var x: {x}\nVar y: {y}");
            
            Console.WriteLine("\nTrocando os números de variáveis\n");

            var aux = x;
            x = y;
            y = aux;

            Console.WriteLine($"Var x: {x}\nVar y: {y}");




        }
    }
}
