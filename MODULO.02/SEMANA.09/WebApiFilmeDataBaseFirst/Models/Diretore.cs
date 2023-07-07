using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiFilmeDataBaseFirst.Models;

public partial class Diretore


{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Esse campo é obrigatório")]
    [MaxLength(200, ErrorMessage = "Esse campo aceita até 200 caracteres")]
    [MinLength(3, ErrorMessage = "Favor digite o nome do Diretor")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "Esse campo é obrigatório")]
    [MaxLength(50, ErrorMessage = "Esse campo aceita até 50 caracteres")]
    [MinLength(3, ErrorMessage = "Favor digite o telefone do Diretor")]

    public string Telefone { get; set; } = null!;

    public virtual ICollection<FilmeDiretor> FilmeDiretors { get; } = new List<FilmeDiretor>();
}
