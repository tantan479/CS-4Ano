using System;

namespace Q20
{

    /*
    Intermediário 20 - Faça um programa que peça os 3 lados de um triângulo. O programa deverá informar se os valores podem ser um triângulo. Indique, caso os lados formem um triângulo, se o mesmo é equilátero, isósceles ou escaleno. Dicas:

	Triangulo é viável quando a soma de quaisquer dos dois lados é maior que o terceiro.
	Triângulo equilátero possui três lados iguais;
	Triângulo isósceles possui quaisquer dois lados iguais;
	Triângulo escaleno possui três lados diferentes.
    */

    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.WriteLine("Informe o valor do lado A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do lado B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor do lado C: ");
            C = Convert.ToDouble(Console.ReadLine());

            if(verificar(A, B, C) == true){
                classificar(A, B, C);
            }else{
                Console.Write("Triangulo Inválido");
            }


            
        }

        static bool verificar(double A, double B, double C)
        {
            if(A > B+C)
                return false;
            if(B > A+C)
                return false;
            if(C > A+B)
                return false;

            
            Console.WriteLine("\nÉ um trinagulo válido");
            return true; 
        }

        static void classificar(double A, double B, double C)
        {
            //Triangulo Equilátero
            if(A == B & B == C){
                Console.WriteLine("Triângulo Equilátero");
                return;
            }


            //Triangulo Isósceles
            if(A == B || A == C || B == C){
                Console.WriteLine("Triângulo Isósceles");
                return;
            }

            Console.WriteLine("Triangulo Escaleno");
            return;



            
        }
    }
}
