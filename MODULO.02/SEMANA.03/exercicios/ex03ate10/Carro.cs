namespace Classes
{
	public class Carro
    {
        public string Marca{get; set;}
        public string Modelo {get; set;}
        public string Placa {get; set;}
        public string Cor {get; set;}
        public Proprietario Proprietario {get; set;}

        public Carro(string marca, string modelo, string placa, string cor, Proprietario proprietario) {
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Cor = cor;
        Proprietario = proprietario;
        }

        public string ListarCadastros() {
            return($"\n- Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}, Cor: {Cor} \n Proprietário: {Proprietario.Nome}, CPF: {Proprietario.CPF}, Telefone: {Proprietario.Telefone} \n");
        }
       	}
}
