using System.ComponentModel.DataAnnotations;

namespace Semana13.Models;

public class Cliente
{
    [Key] // Decoração de propriedade, tipos primitivos são considerados obrigatorios. String é opcional por padrão // int? diz que não é obrigatorio
    public int IdCliente { get; set; }

    [StringLength(64)] [Required]
    public string Nome { get; set; }

    [StringLength(64)] [Required]
    public string Email { get; set; }

    [StringLength(16)] [Required] // 16 por toc
    public string Telefone { get; set; }

    [StringLength(128)] 
    public string Endereco { get; set; }
    public List<Pedido> Pedidos { get; set; }

}