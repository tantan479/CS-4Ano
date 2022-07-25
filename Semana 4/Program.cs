using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace Semana_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int op = 1;

            do{

                Console.WriteLine("\nPressione qualquer tecla");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\n------Programas------");
                Console.WriteLine("1- Contar Negativos");
                Console.WriteLine("2- Ze maior que Chico");
                Console.WriteLine("3- Média de Positivos");
                Console.WriteLine("4- Média notas");
                Console.WriteLine("0- Pare");


                Console.WriteLine("Escolha:");
                op = Convert.ToInt32(Console.ReadLine());

                switch(op)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(450);
                        break;
                    case 1:
                        Contarneg();
                        break;
                    case 2:
                        Chicoze();
                        break;
                    case 3:
                        Medpos();
                        break;
                    case 4:
                        Alunos();
                        break;
                    default:
                        Console.WriteLine("Escolha Inválida");
                        break;
                }
            }while(op != 0);

            Console.Clear();

        }

        static void Contarneg()
        {

            Console.Clear();

            double[] A = new double[5];
            int neg=0;

            for(int i = 0; i < A.Length; i++){
                Console.WriteLine($"Número {i + 1}:");
                A[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach(var n in A){
                if(n < 0)
                    neg++;
            }

            Console.WriteLine($"Há {neg} números negativos");

        }

        static void Chicoze()
        {
            double c = 1.5, z = 1.10; // passar para int erro de arrendondamento do tipo double
            int ano = 0;

            Console.Clear();

            for(int i = 0; i <= 1; i++){
                if (z <= c){
                    i--;
                    ano++;
                    c += 0.02;
                    z += 0.03;
                };
            }
            
            //do{
               // c += 0.02;
               // z += 0.03;
                //ano++;
            //}while(z <= c);

            Console.WriteLine($"Anos: {ano} \nChico: {c:F2}m Zé: {z:F2}m");
        }

        static void Medpos()
        {
            List<int> num = new List<int>();

            int ent = 0;
            
            do{

                Console.WriteLine("Digite um número: ");
                ent = Convert.ToInt32(Console.ReadLine()); // int.Parse() outro metodo para converter
                
                if(ent >=0) 
                    num.Add(ent);

            }while(ent >= 0);

            var media = num.Average();

            Console.WriteLine($"A média é: {media}");

        }


        static void Alunos()
        {
            List<double> notas = new List<Double>(); // para calcular a media
            List<double> notas1 = new List<Double>();
            List<double> notas2 = new List<Double>();
            List<double> notas3 = new List<Double>();
            List<string> codigos = new List<string>();
            List<double> medias = new List<double>();

            string entcod="";
            double nota;
            
            do{
                
                Console.Clear();

                Console.WriteLine("Digite o código do aluno: ");
                entcod = Console.ReadLine();

                    if (entcod != "0"){
                            codigos.Add(entcod);

                        for(int i = 0; i < 3; i++){
                            Console.WriteLine($"Digita a nota {i + 1}:");
                            nota = Convert.ToDouble(Console.ReadLine());
                            notas.Add(nota);
                            if(i == 0) notas1.Add(nota);
                            if(i == 1) notas2.Add(nota);
                            if(i == 2) notas3.Add(nota);
                        }

                        medias.Add(notas.Average());

                        notas.Clear();
                    }

            }while(Convert.ToInt32(entcod) != 0);


            Console.WriteLine("\nMédia das notas: ");

            foreach(var item in medias){
                Console.WriteLine($"{item:F2}");
            }


        }

    }
}
