/*
Faça um programa que crie uma lista inicializada com 5 números inteiros desordenados e mostre-os em ordem decrescente.
Dica: use os métodos Sort() e Reverse()	de listas
*/

class Q1
{

    static void Main()
    {
        
        List<int> a = new List<int>(){11, 7, 25, 10, 13};
        
        a.Sort(); // Ordena em ordem crescente
        a.Reverse(); // Inverte a ordem dos elementos


        Console.Write("Numeros em ordem decrescente: ");
        Console.WriteLine($"{String.Join(" ", a)}");

    }

}