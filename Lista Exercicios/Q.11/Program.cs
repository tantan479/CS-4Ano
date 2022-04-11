using System;

namespace Q11
{

    /*
    Fácil 11 - Para doar sangue é necessário ter entre 18 e 67 anos. Faça um programa que pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não.
    */
    class Program
    {
        static void Main(string[] args)
        {

            int idade;
            
            Console.WriteLine("Qual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade > 17 & idade < 68)
                Console.WriteLine("Você pode doar sangue");
            else
                Console.WriteLine("Você não pode doar sangue");

        }
    }
}