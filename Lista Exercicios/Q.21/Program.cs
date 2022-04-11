using System;

namespace Q21
{

    /*
    Intermediário 21 - Faça um programa que calcule as raízes de uma equação do segundo grau, na forma ax2 + bx + c. O programa deverá pedir os valores de a, b e c e fazer as consistências, informando ao usuário as seguintes situações:  

	Se o usuário informar o valor de A igual a zero, a equação não é do segundo grau e o programa não deve pedir os demais valores, sendo encerrado;
	Se o delta calculado for negativo, a equação não possui raízes reais. Informe ao usuário e encerre o programa;
	Se o delta calculado for igual a zero, a equação possui apenas uma raiz real; informe ao usuário;
	Se o delta for positivo, a equação possui duas raízes reais; informe-as ao usuário.
    */

    public class Inicial
    {
        static void Main()
        {
            Program p = new Program();
            p.Main2();
        }
    }
    
    
    public class Program
    {

        int a, b, c, d;
        double r1, r2;

        public void Main2()
        {
           
            if(entrada() == true){
                if(delta() == true){
                    calcular();
                }
            }

        }

        bool entrada()
        {
            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());
            if(a == 0)
                return false;
            
            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            return true;
        }

        bool delta()
        {
            // delta = b²-4ac

            d = (b*b)-(4*a*c);

            if(d < 0){
                Console.WriteLine("A equação não possui raízes reais.");
                return false;
            } 

            if(d == 0){
                Console.WriteLine("A equação possui apenas uma raiz real");
                return true;
            }

            Console.WriteLine("A equação possui 2 raízes reais");
            return true;
        }

        void calcular()
        {
            r1 = (-b + Math.Sqrt(d)) / 2.0*a ;
            r2 = (-b - Math.Sqrt(d)) / 2.0*a ; 

            if(r1 == r2)
                Console.WriteLine($"Raíz {r1}");
            
            Console.WriteLine($"Raíz 1: {r1}" );
            Console.WriteLine($"Raíz 2: {r2}" );
        }
    }
}
