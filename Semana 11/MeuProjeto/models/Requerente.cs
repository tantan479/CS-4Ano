using System.ComponentModel.DataAnnotations;

public class Requerente
{
    
    [Key]
    public int IdRequerente{ get; set; }
    [Required, StringLength(11)]
    public string Cpf{ get; set; }
    [Required, StringLength(64)]
    public string Nome{ get; set; }
    [Required, StringLength(256)]
    public string Endereco{ get; set; }
    public int IdPlano{ get; set; }
}

// dotnet add package Microsoft.EntityFrameWorkCore.Sqlite
// dotnet add package Microsoft.EntityFrameWorkCore.Design