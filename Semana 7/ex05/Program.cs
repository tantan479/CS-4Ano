using System;
using System.Collections.Generic;
using System.Linq;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> palavras = new List<string>();

            string entpalavra=".";

            do{

                Console.WriteLine("Digite uma palavra:");
                entpalavra = Console.ReadLine().ToUpper();
                if(entpalavra != "S"){
                    palavras.Add(entpalavra);
                }

            }while(entpalavra!="S");

            Console.WriteLine("\n");
            Console.Clear();

            
            int index, aux2=0;

            do{
                
                Console.WriteLine("Digite uma palavra a ser buscada:");
                entpalavra = Console.ReadLine().ToUpper();
                if(entpalavra != "S")
                {
                    
                    
                    foreach (var palavra in palavras)
                    {
                    
                    int aux=0;

                        for(int i=0; i < palavra.Count()/2; i++){
                            
                            try
                            {
                                if(entpalavra[i] == palavra[i])
                                aux++;
                                                        
                                if(aux == palavra.Count()/2){
                                    index = palavras.IndexOf(palavra);
                                    Console.WriteLine($"Fragmento {entpalavra} de {palavra} se encontra no index {index}");
                                    aux2++;
                                    break;
                                }
                            }
                            catch(Exception){
                                Console.WriteLine("Fragmento não encontrado");
                                break;
                            }

                            

                        }


                    }

                        if(aux2 == 0){
                            Console.WriteLine("Fragmento não encontrado");
                        }
                }

            }while(entpalavra!="S");

            /*
            
                for(int i; i < palavra.length/2; i++){
                    if(entpalavra[i] == palavra[i]){
                        aux++
                    }
                    if(aux == palavra.length/2){
                        Console.WriteLine($"Fragmento {entpalavra} de {palavra} se encontra no index {index}");
                        break;
                    }
                }

                        if(entpalavra[0] == palavra[0] & entpalavra[1] == palavra[1] & entpalavra[2] == palavra[2]){
                            index = palavras.IndexOf(palavra);
                            Console.WriteLine($"Fragmento {entpalavra} de {palavra} se encontra no index {index}");
                            break;
                        }



            */
        }
    }
}
