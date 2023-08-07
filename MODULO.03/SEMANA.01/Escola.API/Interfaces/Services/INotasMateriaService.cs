using Escola.API.Model;

namespace Escola.API.Interfaces.Services
{
    public interface INotasMateriaService
    {
        public NotasMateria ObterPorId(int id);

        public List<NotasMateria> ObterNotasMaterias(int id);
        public List<NotasMateria> ObterPorBoletimId(int boletimId);

        NotasMateria Cadastrar(NotasMateria notasMateria);
        NotasMateria Atualizar(NotasMateria notasMateria);
        
        NotasMateria Excluir(int id);
        
    }
}