// PRORTER ROD

class Animal : Object // Herança
{
    public string especie;
    double peso;
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

    public void SetPeso(double novoPeso)
    {
        if(novoPeso > 0){
            this.peso = novoPeso;
        }else
        {
            throw new Exception("Isso é heresia");
        }
    }

    public double GetPeso()
    {
        return this.peso;
    }
}