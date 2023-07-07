using System;
using System.Collections.Generic;

namespace WebApiFilmeDataBaseFirst.Models;

public partial class Filme
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int? Ano { get; set; }

    public int? Duracao { get; set; }

    public virtual ICollection<ElencoFilme> ElencoFilmes { get; } = new List<ElencoFilme>();

    public virtual ICollection<FilmeDiretor> FilmeDiretors { get; } = new List<FilmeDiretor>();

    public virtual ICollection<FilmeGenero> FilmeGeneros { get; } = new List<FilmeGenero>();
}
