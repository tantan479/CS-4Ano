using System;

namespace Q18
{

    /*
    Intermediário 18 – Faça um programa que leia duas notas parciais obtidas por um aluno, calcule a sua média e lhe atribua um conceito conforme a tabela abaixo:

    Média de aproveitamento		Conceito 
    Entre 9.0 e 10.0 		A
    Entre 7.5 e 9.0			B
    Entre 6.0 e 7.5			C
    Entre 4.0 e 6.0			D
    Entre 4.0 e 0			E
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

            Console.WriteLine($"Conceito {c}");

        }
    }
}