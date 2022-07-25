/*
Faça um programa que crie duas listas inicializadas com 10 números inteiros cada e mostre a soma dos elementos de mesmo índice (obs.: o resultado serão 10 números inteiros).
*/

class Q1
{

    static void Main()
    {
        
        List<int> a1 = new List<int>(){10, 8, 5, 4, 8, 4, 7, 23, 14, 19};
        List<int> a2 = new List<int>(){5, 1, 2, 4, 7, 6, 4, 1, 7, 10};
        List<int> asom = new List<int>();

        for (int i = 0; i < a1.Count(); i++)
        {
            asom.Add(a1[i] + a2[i]);
        }

        Console.Write("Soma dos Números: ");
        Console.WriteLine($"{String.Join(" ", asom)}");

    }

}