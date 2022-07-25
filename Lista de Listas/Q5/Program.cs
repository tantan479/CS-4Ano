/*
Faça um programa que crie uma lista inicializada com os caracteres do seu nome e mostre-os como uma palavra.
Dica: use o método String.Join(...)
*/

class Q1
{

    static void Main()
    {
        
        List<char> a = new List<char>(){'R', 'E', 'N', 'A', 'T', 'O'};

        Console.WriteLine($"{String.Join("", a)}");

    }

}