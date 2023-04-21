namespace Classes
{
	public class Proprietario
    {
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;}

        public Proprietario(string nome, string cpf, string telefone) {
        Nome = nome;
        CPF = cpf;
        Telefone = telefone;
        }
	}
}

