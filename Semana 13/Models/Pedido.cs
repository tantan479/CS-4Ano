using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semana13.Models;

public class Pedido
{
    [Key]
    public int IdPedido { get; set; }
    public DateTime DataHora { get; set; }

    [NotMapped] // Sqlite não o mapeará
    public double ValorTotal
    {
        get
        {
            return (Itens.Sum(i => i.ValorItem)); // Eu não somo os objetos da lista e sim os atributos dos objetos na lista(i(apelido) tal que i.ValorItem)
        }
    }
    public Cliente Cliente{ get; set; }

    [ForeignKey("Cliente")] // Temos aqui a foreign key do objeto cliente
    public int IdCliente { get; set; }
    public List<ItemPedido> Itens { get; set; }
}
