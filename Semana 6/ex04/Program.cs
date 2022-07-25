using System;
using System.Collections.Generic;
using System.Linq;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> precos = new List<double>();
            List<string> nomes = new List<string>();

            string entnome = "";
            
            do{
                Console.WriteLine("Digite o nome do produto: ");
                entnome = Console.ReadLine();

                if(entnome !="S"){
                    nomes.Add(entnome);
                    Console.WriteLine("Digite o preço do produto: ");
                    precos.Add(Convert.ToDouble(Console.ReadLine()));
                }

                Console.Clear();

            }while(entnome !="S");

            Console.WriteLine($"Produto mais caro: {nomes[precos.IndexOf(precos.Max())]}\nPreço: {precos.Max():C}");
            Console.WriteLine($"Produto mais barato: {nomes[precos.IndexOf(precos.Min())]}\nPreço: {precos.Min():C}");

        }
    }
}
