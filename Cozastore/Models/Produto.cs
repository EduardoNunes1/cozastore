using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cozastore.Models;

[Table("Produto")]

public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage ="Por favor, informe o Nome")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir no máximo 100 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(1000, ErrorMessage = "A Descrição Resumida deve conter no maximo 1000 Caracteres")]
    public string DescricaoResumida { get; set; }

    [Display(Name = "Descrição Completa")]
    [StringLength(1000, ErrorMessage = "A Descrição Completa deve conter no maximo 8000 Caracteres")]
    public string DescricaoCompleta { get; set; }

    
    [StringLength(10, ErrorMessage = "O SKU deve conter no maximo 10 Caracteres")]
    public string SKU { get; set; }

    [Display(Name = "Preco")]
    [Column(TypeName = "decimal(10,2)")] 
    [Required(ErrorMessage = "Por favor, informe o preço do produto")]
    public decimal Preco { get; set; }

    [Display(Name = "Preco com Desconto")]
    [Column(TypeName = "decimal(10,2)")] 
    public decimal PrecoDesconto { get; set; }

    [Display(Name = "Produto em Destaque?")]
    public bool Destaque { get; set; }

    [Column(TypeName = "decimal(8,3)")]
    public decimal Peso { get; set; } 

    [StringLength(30, ErrorMessage = "O Materia deve possuir no maximo 30 caracteres")]
    public string Material { get; set; }
    
    [Display(Name = "Dimensão")]
    [StringLength(30, ErrorMessage = "A Dimensão de possuir no maximo 30 caracteres")]
    public string Dimensao { get; set; }

    [Display(Name = "Categoria")]
    [Required(ErrorMessage = "Por favor, informe a catgoria do produto")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    public ICollection<Estoque> Estoque { get; set; }
}