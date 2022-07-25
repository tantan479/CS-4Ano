//Implementando contrato dos serviçoes que a minha aplicação precisa

public interface IFilmeRepo
{
    List<Filme> ObterTodosOsFilmes();

    Filme ObterFilmePorId(int id);
}