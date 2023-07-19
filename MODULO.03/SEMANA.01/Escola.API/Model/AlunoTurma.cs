namespace Escola.API.Model;

public class AlunoTurma
{
    public virtual Aluno Aluno { get; set; }
    public virtual Turma Turma{ get; set; }

    public int AlunoId { get; set; }
    public virtual int TurmaId { get; set; }

    }
