﻿namespace Escola.API.Model;

public class Turma
{
    public int Id { get; set; }
    public string Curso { get; set; }
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; }
}
