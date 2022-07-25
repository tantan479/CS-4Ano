using Microsoft.EntityFrameworkCore;
using Semana13.Models;

namespace Semana13.Data;

public class DataContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<ItemPedido> ItensPedido { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<ItemPedido>().HasKey(ip => new{ ip.IdPedido, ip.IdProduto}); // protocolação de chave composta em ItemPedido
    }

    public DataContext(DbContextOptions<DataContext> options) : base(options){}
}