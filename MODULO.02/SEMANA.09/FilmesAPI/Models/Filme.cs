using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do filme não pode exceder 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo de diretor é de preenchimento obrigatório")]
        [MaxLength(100, ErrorMessage ="O campo diretor não pode exceder 100 caracteres")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "O campo de genero é de preenchimento obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo genero não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo de duração é obrigatório")]
        [Range(1, 360, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 360")]
        public int Duracao { get; set; }

       

       
    }
}