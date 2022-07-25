/*
    Crie um programa com uma lista inicializada com os valores a seguir:
	{ 8, 9, 6, 3, 7, 2, 5, 4, 1, 2, 7, 8, 5, 9, 4, 2, 3 }
	O programa deve remover da lista todos os elementos pares e, ao fim, exibir a lista com os elementos separados por vírgula.
	Dica: use o método Remove(...) de listas e uma estrutura "do..while"
*/

class Q1
{

    static void Main()
    {
        
        List<int> a = new List<int>(){ 8, 9, 8, 8, 8, 8, 8 , 1, 2, 7, 8, 5, 9, 4, 2, 3 };

        // foreach (var item in a) // não, pois a coleção muda durante a execução
        
        int i = 0;
        
        do{

            if (a[i]%2 == 0){
                a.Remove(a[i]);
                i--;
            }

            i++;

        }while(i < a.Count());

        Console.WriteLine($"{String.Join(" ", a)}");

    }

}