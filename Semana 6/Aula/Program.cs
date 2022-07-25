using System;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v1 = new Veiculo();
            v1.Marca = "Honda";
            v1.Modelo = "Fit";
            v1.AnoFabricacao = 2016;
            v1.Quilometragem = 5640;
            v1.Preco = 50000;
            v1.Testar(10);
            v1.Abastecer(10);
        }
    }
}
