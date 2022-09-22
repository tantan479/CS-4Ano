using System.ComponentModel.DataAnnotations;

public class Categoria
{
    [Key]
    public int IdCategoria{get; set;}
    [Required]
    public string Nome { get; set; }
    public ICollection<Produto> Produtos { get; set; }
}