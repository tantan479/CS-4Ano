using System;

namespace Q16
{

    /*
    Intermediário 16 - Faça um programa que leia três números e mostre-os em ordem decrescente.
    */

    class Program
    {


        static void Main(string[] args)
        {

            double[] num = {0, 0, 0};

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o número {i+1}: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }

            for(int i = 0; i < num.Length; i++){
                for(int j=i; j < num.Length; j++){
                    if(num[i] < num[j]){
                        var aux = num[i];
                        num[i] = num[j];
                        num[j] = aux;
                    }
                }
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($" Vetor num{i}: {num[i]} ");

            }

        }
    }

}