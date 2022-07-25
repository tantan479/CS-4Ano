class Galo: Animal
{
    private bool ehLutador;
    private string nome;

    public Galo(double peso, int qtdDentes, bool estaVivo, bool Luta, string nome) : base("Gallus gallus", peso, qtdDentes, estaVivo, 'M')
    {
        this.ehLutador = Luta;
        this.nome = nome;
    }

    
    public override string ToString()
    {
        string resultado = base.ToString(); // base o ancestral (Animal)
        resultado += $"\nÉs lutador: {this.ehLutador}";
        resultado += $"\nNome: {this.nome}";
        return resultado;
    }
}