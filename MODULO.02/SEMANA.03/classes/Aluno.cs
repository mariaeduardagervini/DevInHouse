namespace Classes
{
	public class Aluno
	{
		public string Nome {get; set;}
		public int Matricula {get; set;}
		public string  Endereco {get; set;}
		public string Telefone {get; set;}

		public Boletim Boletim { get; set; }

		public void RealizarMatricula() {
			//Faça a Matrícula
			Console.WriteLine($"Matrícula de {Nome} realizada!");
		}
		public void ConsultarNotas(){
		Console.WriteLine($"As notas de {Nome} são: ");
		}
	}
}