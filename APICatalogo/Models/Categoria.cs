using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;

[Table("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "Campo nome é obrigatório", AllowEmptyStrings = false)]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O campo ImagemUrl é obrigatório", AllowEmptyStrings =false)]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    [JsonIgnore]
    public ICollection<Produto>? Produtos { get; set; }

    //Boa pratica iniciar a coleção assim que definirmos uma coleção na classe.
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
}
