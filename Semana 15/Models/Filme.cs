using System.ComponentModel.DataAnnotations;

public class Filme
{
    [Key]
    public int IdFilme { get; set; }

    [Required] [StringLength(64)]
    public string Titulo { get; set; }

    [Required] [StringLength(512)]
    public string Sinopse { get; set; }

    public double Avaliacao { get; set; }
    public int Duracao { get; set; }

    [Required] [StringLength(32)]
    public string Genero { get; set; }

}