namespace Classes
{
	public class Boletim {
		public int Nota1 {get; set;}
		public int Nota2 {get; set;}
		public int Nota3 {get; set;}

		public string ObterDescritivoNotas() {
			return $"Nota1: {Nota1}, Nota2: {Nota2}, Nota3: {Nota3}";
		}
		public double Media() {
			return (Nota1 + Nota2 + Nota3) / 3;
		}
	}
}