/*
    Considere duas listas com os seguintes valores:
	Lista1: { "E", "es", "progr", "usa", "lis" }
	Lista2: { "u", "tou", "amando", "ndo", "tas" }
	Faça um programa com duas listas inicializadas conforme acima e que una os elementos de mesmo índice dessas duas listas em uma terceira lista, mostrando os itens da terceira lista separados pelo caractere de espaço (' ').
	Dica: use o método Add(...) de listas
*/

class Q1
{

    static void Main()
    {
        
       List<String> a1 = new List<string>(){ "E", "es", "progr", "usa", "lis" };
       List<String> a2 = new List<string>(){ "u", "tou", "amando", "ndo", "tas" };
       List<String> a3 = new List<string>();

       for (int i = 0; i < a1.Count(); i++)
       {
           a3.Add($"{a1[i]+a2[i]}");
       }

       Console.WriteLine($"{String.Join(" ", a3)}");

    }

}