using System;
using System.Collections.Generic;

namespace WebApiFilmeDataBaseFirst.Models;

public partial class Genero
{
    public int Id { get; set; }

    public string Genero1 { get; set; } = null!;

    public virtual ICollection<FilmeGenero> FilmeGeneros { get; } = new List<FilmeGenero>();
}
