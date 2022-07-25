// PRORTER ROD

class Animal : Object // Herança
{
    string especie;
    double peso;
    public int qtdDentes;
    public bool estaVivo;
    public char genero;

    public Animal(string especie, double peso, int qtdDentes, bool estaVivo, char genero)
    {
        this.especie = especie;
        this.SetPeso(peso);
        this.qtdDentes = qtdDentes;
        this.estaVivo = estaVivo;
        this.genero = genero;
    }

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

    public override string ToString()
    {
        string resultado = "";
        resultado += $"\nEspécie: {this.especie}";
        resultado += $"\nGenero: {this.genero}";
        resultado += $"\nEstá vivo: {this.estaVivo}";
        resultado += $"\nPeso: {this.GetPeso()}";
        resultado += $"\nQuantidade de dentes: {this.qtdDentes}";
        return resultado;
    }
}