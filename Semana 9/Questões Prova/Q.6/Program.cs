List<int> inteiros = new List<int>();

int inteiro = 0;

do
{

    Console.WriteLine("Digite um número inteiro");
    var entInteiro = Console.ReadLine();
    inteiro = Convert.ToInt32(entInteiro);

    if(inteiro != 0)
        inteiros.Add(inteiro);

} while (inteiro != 0);

List<double> reais = new List<double>();

for(int i = 0; i < inteiros.Count(); i++){
    Console.WriteLine("Digite um número real");
    var entReal = Console.ReadLine();
    var real = Convert.ToDouble(entReal);

    if(real != 0)
        reais.Add(real);
}


// Usando uma lista

List<double> somas = new List<double>();

for (int i = 0; i < inteiros.Count(); i++)
{
    somas.Add(inteiros[i] + reais[i]);
}

var textoSomas = String.Join(", ", somas);
Console.WriteLine(textoSomas);

// Não usando uma lista

for (int i = 0; i < inteiros.Count(); i++)
{
    Console.WriteLine($"{inteiros[i] + reais[i]}, ");
}