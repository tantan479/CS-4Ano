using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Produto
{
    [Key]
    public int IdProduto { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public double Preco { get; set; }
    [Required]
    public int Estoque { get; set; }

    [ForeignKey("Categoria")]
    public int IdCategoria { get; set; }
    public Categoria Categoria { get; set; }
}