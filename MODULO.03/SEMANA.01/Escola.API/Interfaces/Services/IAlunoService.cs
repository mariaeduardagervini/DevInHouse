using Escola.API.Model;

namespace Escola.API.Interfaces.Services;

    public interface IAlunoService
    {
        public Aluno Criar(Aluno aluno);
        public Aluno ObterPorId(int id);
        public Aluno Atualizar(Aluno aluno);
        public List<Aluno> ObterAlunos();
        public void DeletarAluno(int id);
    }
