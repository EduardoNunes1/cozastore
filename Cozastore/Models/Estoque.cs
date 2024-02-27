using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Estoque")]
public class Estoque
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Por favor, infome o Produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Display(Name = "Tamanho")]
    [Required(ErrorMessage = "Por favor, infome o Tamanho")]
    public int TamanhoId { get; set; }
    [ForeignKey("TamanhoId")]
    public Tamanho Tamanho { get; set; }

    [Display(Name = "Cor")]
    [Required(ErrorMessage = "Por favor, infome a Cor")]
    public int CorId { get; set; }
    [ForeignKey("CorId")]
    public Cor Cor { get; set; }

    [Display(Name = "Preco")]
    [Column(TypeName = "decimal(10,2)")] 
    public decimal? Preco { get; set; }

    [Display(Name = "Preco com Desconto")]
    [Column(TypeName = "decimal(10,2)")] 
    public decimal? PrecoDesconto { get; set; }

    [Display(Name = "Quantidade Disponivel")]
    [Required(ErrorMessage = "Por favor, informe a Qtde em Estoque")]
    public int QtdeEstoque { get; set; } = 0;
}
