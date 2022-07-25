using System;
using System.Collections.Generic;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palavras = new List<string>();

            string entpalavra=".";


            // Questão 3

            do{

                Console.WriteLine("Digite uma palavra:");
                entpalavra = Console.ReadLine().ToUpper();
                if(entpalavra != "S"){
                    palavras.Add(entpalavra);
                }

            }while(entpalavra!="S");

            Console.WriteLine("\n");
            Console.Clear();


            // Questão 4

            do{
                
                Console.WriteLine("Digite uma palavra a ser buscada:");
                entpalavra = Console.ReadLine().ToUpper();
                if(entpalavra != "S"){
                    if(palavras.Contains(entpalavra)){
                         var index = palavras.IndexOf(entpalavra);
                         Console.WriteLine($"Palavra {entpalavra} se encontra no index {index}");
                    }else{
                        Console.WriteLine("Não contem");
                    }
                }

            }while(entpalavra!="S");


        }
    }
}
