using System;
using System.Collections.Generic;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            List<int> megasena = new List<int>();
            var ramdon = new Random();
            int sorteio;
            int aux=0;
            
            for(int i=0; i<6; i++){
                sorteio = ramdon.Next(1, 51);

                if(!megasena.Contains(sorteio)){
                    megasena.Add(sorteio);
                }else{
                    i--;
                }

            }

            for (int i = 0; i < megasena.Count; i++) // megasena.Sort() em ExGH
            {
                for (int k = 0; k < megasena.Count; k++)
                {
                    if(megasena[i] < megasena[k]){
                        aux = megasena[k];
                        megasena[k] = megasena[i];
                        megasena[i] = aux;
                    }
                }
            }

            Console.WriteLine($"Resultado da megasena: {String.Join(", ",megasena)}");

        }
    }
}
