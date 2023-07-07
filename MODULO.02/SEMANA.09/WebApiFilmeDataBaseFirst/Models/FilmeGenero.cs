using System;
using System.Collections.Generic;

namespace WebApiFilmeDataBaseFirst.Models;

public partial class FilmeGenero
{
    public int Id { get; set; }

    public int IdGenero { get; set; }

    public int IdFilme { get; set; }

    public virtual Filme IdFilmeNavigation { get; set; } = null!;

    public virtual Genero IdGeneroNavigation { get; set; } = null!;
}
