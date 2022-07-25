/*
    Crie um programa com uma lista inicializada com os valores a seguir:
	{ 8, 9, 6, 3, 7, 2, 5, 4, 1, 2, 7, 8, 5, 9, 4, 2, 3 }
	O programa deve contar a quantidade de vezes que o número 2 aparece na lista.
	Dica: use uma estrutura "foreach"
*/

class Q1
{

    static void Main()
    {
        
        List<int> a = new List<int>(){ 8, 9, 6, 3, 7, 2, 5, 4, 1, 2, 7, 8, 5, 9, 4, 2, 3 };

        int qtd = 0;
        
        foreach (var item in a)
        {
            if(item == 2)
                qtd++;
        }

        Console.WriteLine($"Quantidade de 2's: {qtd}");
        
        

    }

}