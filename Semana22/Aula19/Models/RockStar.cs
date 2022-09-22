using System.ComponentModel.DataAnnotations;

namespace Aula19.Models;
public class RockStar
{
    public static List<RockStar> lista = new List<RockStar>();

    // static RockStar()
    // {
    //     lista.Add(new RockStar(1, "Ludwig van Beethoven", "deafman@gmail.com"));
    //     lista.Add(new RockStar(2, "Wolfgang Amadeus Mozart", "wolfie@gmail.com"));
    //     lista.Add(new RockStar(3, "Joseph Haydn", "papahaydn@gmail.com"));
    //     lista.Add(new RockStar(4, "Johann Sebastian Bach", "god@gmail.com"));
    //     lista.Add(new RockStar(5, "Antonio Vivaldi", "redpriest@gmail.com"));
    //     lista.Add(new RockStar(6, "Antonin Dvorak", "folkinspiration@gmail.com"));
    //     lista.Add(new RockStar(7, "Piotr Ilitch Tchaikovsky", "swan@gmail.com"));
    //     lista.Add(new RockStar(8, "Domenico Scarlatti", "bestklavier@gmail.com"));
    //     lista.Add(new RockStar(9, "Jean Sibelius", "appcomposer@gmail.com"));
    //     lista.Add(new RockStar(10, "Johann Strauss II", "waltz@gmail.com"));
    // }

    // public RockStar(int id, string nome, string email)
    // {
    //     this.Id = id;
    //     this.Nome = nome;
    //     this.Email = email;
    // }

    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = " O campo {0} é obrigatório.")]
    [StringLength(64, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = " O campo {0} é obrigatório.")]
    [StringLength(64, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
    public string Email { get; set; }

    [Required(ErrorMessage = " O campo {0} é obrigatório.")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = " O campo {0} é obrigatório.")]
    [StringLength(64, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
    public string PaisOrigem { get; set; }

    [Required(ErrorMessage = " O campo {0} é obrigatório.")]
    [StringLength(512, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
    public string Descricao { get; set; }
}