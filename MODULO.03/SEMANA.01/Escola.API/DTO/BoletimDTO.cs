using Escola.API.Model;

namespace Escola.API.DTO
{
    public class BoletimDTO
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int AlunoId { get; set; }

        public BoletimDTO() { }

        public BoletimDTO(BoletimDTO boletim) 
        { 
            Id = boletim.Id;
            Data = boletim.Data;
            AlunoId = boletim.AlunoId;
        }

        public BoletimDTO(Boletim boletim)
        {
        }
    }
}
