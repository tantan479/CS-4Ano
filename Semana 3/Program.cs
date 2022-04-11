using System;
using System.Collections.Generic;
using System.Linq;

namespace Semana_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Continuação dos exercicios 8 e 9 na pasta semana 2");

            int[] valores = {8, 4, 6};

            int soma = 0;

            string[] nome = {"Renato", "Ribeiro", "Altoé"};

            char[] nomep = {'R', 'E', 'N', 'A', 'T', 'O'};

            double[] n4 = {22.00, 23.00, 22.00, 25.00};

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Elemento {i} = {valores[i]}");
            } 

            for (int i = 0; i < valores.Length; i++)
            {
                soma+=valores[i];
            }

            Console.WriteLine($"Soma: {soma}");

            soma = 0;

            foreach (int valor in valores)
            {
                soma += valor; 
            }

            foreach(char l in nomep)
            {
                Console.Write(l);
            }

            double soman4=0;
            

            foreach(double valor in n4)
            {
                soman4+=valor;
            }

            var meidia = soman4/n4.Length;

            Console.WriteLine($"\nSoma: {soma} Média:{meidia}");


            soman4 = 0;
            meidia = 0;

            
            for (int i = 0; i < 4; i++)
            {
                soman4+=n4[i];
                if(i==3){
                    meidia=soman4/4;
                    Console.WriteLine($"Soma: {soma} Média:{meidia}");
                }
            }

            for (int i = 0; i < nome.Length; i++){Console.Write($"{nome[i]} ");}

            
            Console.WriteLine("\n");
            Console.WriteLine(String.Join(' ', nome));

            string nomecompleto = String.Join(' ', nome);

            
            
            for (int i = 0; i < nomecompleto.Length; i++)
            {
                if(String.Equals(nomecompleto.Split(' '), " ")){
                    break;
                }else{
                    Console.Write(nomecompleto[i]);
                }
                

            }

            List<double> precos = new List<double>();

            precos.Add(5.6);
            precos.Add(3.9);

            double somaPrecos = precos.Sum();
            double mediaPrecos = precos.Average();
            int qtdprecos = precos.Count();
            double maior = precos.Max();
            double menor = precos.Min();
            precos.Insert(0, 9.9);
            precos.Append(8.5); // Igaul aod add

            if(precos.Contains(9.9)){
                
            }

            List<double> notas = new List<double>();

            notas.Add(24);
            notas.Add(21);
            notas.Add(20);
            notas.Add(25);

            var nmedia = notas.Average();
            var sumnotas = notas.Sum();

        }
    }
}
