using System;
using System.Collections.Generic;

namespace WebApiFilmeDataBaseFirst.Models;

public partial class Atore
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Genero { get; set; }

    public virtual ICollection<ElencoFilme> ElencoFilmes { get; } = new List<ElencoFilme>();
}
