using System.ComponentModel.DataAnnotations;

namespace Semana13.Models;

public class Produto
{
    [Key]
    public int IdProduto { get; set; }

    [StringLength(64)][Required]
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }

    //public List<ItemPedido> Itens { get; set; } //Atributos de coleção(listas) não são necessárias, apesar de servirem como atalhos para determinadas buscas...
}