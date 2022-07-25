// PRORTER ROD

class Animal : Object
{
    public string especie;
    public double peso;
    public int qtdDentes;
    public bool estaVivo;
    public char genero;

    public void MostrarEstado()
    {
        Console.WriteLine($"Espécie: {this.especie}");
        Console.WriteLine($"Espécie: {this.genero}");
        Console.WriteLine($"Espécie: {this.estaVivo}");
        Console.WriteLine($"Espécie: {this.peso}");
        Console.WriteLine($"Espécie: {this.qtdDentes}");
    }
}