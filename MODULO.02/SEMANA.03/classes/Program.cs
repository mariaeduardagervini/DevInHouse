using Classes;

Aluno aluno = new Aluno();
aluno.Nome = "Maria";
aluno.Matricula = 5;
aluno.Telefone = "123";
aluno.Endereco = "Rua 123";

Console.WriteLine("Nota 1 do aluno " + aluno.Boletim.Nota1);

Boletim boletim = new Boletim();
boletim.Nota1 = 5;
boletim.Nota2 = 6;
boletim.Nota3 = 8;



aluno.RealizarMatricula();
aluno.ConsultarNotas();