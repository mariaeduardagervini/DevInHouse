using Escola.API.Model;

namespace Escola.API.Interfaces.Repositories;

    public interface IAlunoRepository : IBaseRepository<Aluno, int>
    {
        public bool EmailJaCadastrado(string email);
    }

