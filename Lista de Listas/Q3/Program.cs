/*
Faça um programa que crie uma lista inicializada com 10 números inteiros e armazene em uma segunda lista os quadrados dos números da primeira lista, mostrando-os ao final separados por vírgula.
Dica: use os métodos Add() de listas, String.Join(...) e Math.Pow(...)
*/

class Q1
{

    static void Main()
    {
        
        List<int> a = new List<int>(){7, 8, 3, 4, 48, 47, 59, 46, 12, 10};
        List<int> a2 = new List<int>();

        foreach (var item in a)
        {
            double x = item;
            
            a2.Add(Convert.ToInt32(Math.Pow(x, 2.0)));
        }

        Console.Write("Lista ao quadrado: ");
        Console.WriteLine($"{String.Join(", ", a2)}");

    }

}