using System.ComponentModel.DataAnnotations.Schema;

namespace Semana13.Models;

public class ItemPedido
{
    public int Quantidade { get; set; }
    public double ValorUnitario{ get; set; }

    [NotMapped]
    public double ValorItem
    {
        get
        {
            return (Quantidade * ValorUnitario);
        }
    }
    public Pedido Pedido { get; set; }

    [ForeignKey("Pedido")]
    public int IdPedido { get; set; }


    public Produto Produto { get; set; }

    [ForeignKey("Produto")]
    public int IdProduto { get; set; }

}