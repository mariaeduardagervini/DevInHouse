using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFilmeDataBaseFirst.Models;

public partial class FilmeDiretor
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Filme")]
    public int IdFilme { get; set; }
    public Filme Filme { get; set; }

    [ForeignKey("Diretore")]
    public int IdDiretor { get; set; }
    public Diretore Diretore { get; set; }

    public virtual Diretore IdDiretorNavigation { get; set; } = null!;

    public virtual Filme IdFilmeNavigation { get; set; } = null!;
}
