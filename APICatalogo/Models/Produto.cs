﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required(ErrorMessage ="Campo nome é obrigatório", AllowEmptyStrings =false)]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Campo descrição é obrigatório", AllowEmptyStrings = false)]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "Campo preço é obrigatório", AllowEmptyStrings = false)]
    [Column(TypeName ="decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "Campo ImagemUrl é obrigatório", AllowEmptyStrings = false)]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
    public int CategoriaId { get; set; }

    [JsonIgnore]
    public Categoria? Categoria { get; set; }

}
