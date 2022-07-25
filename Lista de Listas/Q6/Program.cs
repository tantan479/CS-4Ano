/*
Faça um programa que crie uma lista inicializada com os caracteres do seu nome e mostre-os como uma palavra de trás para frente.
	Dica: use os métodos Reverse() de listas e String.Join(...)
*/

class Q1
{

    static void Main()
    {
        
       List<char> a = new List<char>(){'R', 'E', 'N', 'A', 'T', 'O'};

       a.Reverse();

       Console.WriteLine($"{String.Join("", a)}");

    }

}