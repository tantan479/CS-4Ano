class Cachorro: Animal
{
    public string tipoPelo;
    private string raca;
    private string nome;

    public Cachorro(double peso, int qtdDentes, bool estaVivo, char genero, string raca, string nome) : base("Canis Familiares", peso, qtdDentes, estaVivo, genero) // chamei lhe seu construtor da ancestral
    {
        this.raca = raca;
        this.nome = nome;
    }

    public override string ToString()
    {
        string resultado = base.ToString(); // base o ancestral (Animal)
        resultado += $"\nRaça: {this.raca}";
        resultado += $"\nNome: {this.nome}";
        return resultado;
    }
}