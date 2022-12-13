using System.Collections.ObjectModel;

namespace APICatalogo.Models;
public class Categoria
{
    public int CategoriaId { get; set; }
    public string? Nome { get; set; }
    public string? ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }

    //Boa pratica iniciar a coleção assim que definirmos uma coleção na classe.
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }
}
