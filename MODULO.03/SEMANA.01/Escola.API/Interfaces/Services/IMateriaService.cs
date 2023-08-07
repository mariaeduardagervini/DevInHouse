using Escola.API.Model;

namespace Escola.API.Interfaces.Services
{
    public interface IMateriaService
    {

        Materia Atualizar(Materia materia);

        Materia Cadastrar(Materia materia);

        public void Excluir(int id);
    }
}