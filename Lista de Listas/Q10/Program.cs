/*
    Considere as informações a seguir relacionadas a um mapa de criptografia:	
	Mapa: Epaço=00, A=01, B=02, C=03, D=04, E=05, F=06, G=07, H=08, I=09, J=10, K=11, L=12, M=13, N=14, O=15, P=16, Q=17, R=18, S=19, T=20, U=21, V=22, W=23, X=24, Y=25, Z=26.
	Caracteres: { 'V', 'O', 'U', ' ', 'C', 'O', 'N', 'S', 'E', 'G', 'U', 'I', 'R' }
	Crie um programa que substitua os valores da lista "Caracteres" por seus respectivos valores de mapeamento, armazenando-os em uma segunda lista. Ao fim, o programa deve mostrar um texto contínuo composto pela junção da lista "criptografada".
	Dica: use o método String.Join(...)

*/

class Q1
{

    static void Main()
    {
        
        List<char> texto = new List<char>(){'V', 'O', 'U', ' ', 'C', 'O', 'N', 'S', 'E', 'G', 'U', 'I', 'R' };

        List<char> alfabeto = new List<char>(){' ','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};;

        List<string> cripto = new List<string>();

        foreach (var item in texto)
        {

            if(alfabeto.IndexOf(item) < 10){
                cripto.Add($"0{alfabeto.IndexOf(item)}");
            }else{
                    cripto.Add($"{alfabeto.IndexOf(item)}");
            } 
        }

       
        Console.WriteLine($"{String.Join("", cripto)}");
       
       
        
        

    }

}