/*
01. Faça um programa que crie uma lista inicializada com 5 números inteiros desordenados e mostre-os em ordem crescente.
Dica: use o método Sort() de listas 
*/

class Q1
{

    static void Main()
    {
        
        List<int> a = new List<int>(){11, 7, 25, 10, 13};
        
        a.Sort();


        Console.Write("Numeros em ordem crescente: ");
        Console.WriteLine($"{String.Join(" ", a)}");

    }

}