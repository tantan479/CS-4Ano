namespace Semana20.Models;


public class RockStar
{

    public static List<RockStar> lista = new List<RockStar>();

    static RockStar(){
        lista.Add(new RockStar(1, "Ludwig van Beethoven", "deafman@gmail.com"));
        lista.Add(new RockStar(2, "Wolfgang Amadeus Mozart", "wolf@gmail.com"));
        lista.Add(new RockStar(3, "Joseph Haydn", "papahaydn@gmail.com"));
        lista.Add(new RockStar(4, "Johann Sebastian Bach", "god@gmail.com"));
        lista.Add(new RockStar(5, "Antonio Vivaldi", "redpriest@gmail.com"));
        lista.Add(new RockStar(6, "Antonin Dvorak", "folkinspiration@gmail.com"));
        lista.Add(new RockStar(7, "Pyor Ilitch Tchaikovsky", "swan@gmail.com"));
        lista.Add(new RockStar(8, "Domenico Scarlatti", "bestklavier@gmail.com"));
        lista.Add(new RockStar(9, "Jean Sibelius", "appcomposer@gmail.com"));
        lista.Add(new RockStar(10, "Johann Strauss II", "waltz@gmail.com"));
    }

    public RockStar(int id, string nome, string email)
    {
        this.Id = id;
        this.Nome = nome;
        this.Email = email;
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

}