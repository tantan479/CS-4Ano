public class FilmeRepoSqlite : IFilmeRepo
{

    private DataContext _db; // _ por convenção de ser privado

    public FilmeRepoSqlite(DataContext db) // preciso de conectar ao banco, dessa forma as minhas funcões conseguem acessar o banco
    {
        this._db = db;
    }

    public Filme ObterFilmePorId(int id)
    {
        var filme = _db.Filmes.Find(id);
        return filme;
    }

    public List<Filme> ObterTodosOsFilmes()
    {
        var filmes = _db.Filmes.OrderBy(f => f.Titulo).ToList();
        return filmes;
    }
}