using System;

class Veiculo
{
    public string Marca;
    public string Modelo;
    public string Cor;
    public int AnoFabricacao;
    public int AnoModelo;
    public double Preco;
    public int Quilometragem;
    public int MesesDeGarantia;
    public int VolumeTanque;
    void Vender(){}
    public void Testar(int kmRodados)
    {
        this.Quilometragem += kmRodados;
    }
    void Limpar(){}
    public void Abastecer(int litros)
    {
        this.VolumeTanque += litros;
    }


}