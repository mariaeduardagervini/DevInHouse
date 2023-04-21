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

        public string Imprimir() {
            return($"Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}, Cor: {Cor}, Proprietario: {Proprietario.Nome}");
        }
       	}
}
