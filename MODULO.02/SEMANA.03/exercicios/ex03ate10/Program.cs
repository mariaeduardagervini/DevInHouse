using Classes;
internal class Program
{
	private static void Main(string[] args)
	{
	
	var proprietario1 = new Proprietario();
	proprietario1.Nome = "Maria";
	proprietario1.CPF = "001.002.003-04";
	proprietario1.Telefone = "3333-0000";

	var proprietario2 = new Proprietario();
	proprietario2.Nome = "João";
	proprietario2.CPF = "004.003.002-01";
	proprietario2.Telefone = "2222-0000";

	var proprietario3 = new Proprietario();
	proprietario3.Nome = "Sandra";
	proprietario3.CPF = "000.003.008-07";
	proprietario3.Telefone = "3444-0000";

	var carro1 = new Carro();
	carro1.Marca = "Volkswagen";
	carro1.Modelo = "Nivus";
	carro1.Placa = "MMM5E24";
	carro1.Cor = "Branca";
	carro1.Proprietario = "proprietario1";

	var carro2 = new Carro();
	carro2.Marca = "Fiat";
	carro2.Modelo = "Toro";
	carro2.Placa = "JHG8A75";
	carro2.Cor = "Preta";
	carro2.Proprietario = "proprietario2";

	var carro3 = new Carro();
	carro3.Marca = "Ford";
	carro3.Modelo = "Focus";
	carro3.Placa = "GHI9E35";
	carro3.Cor = "Prata";
	carro3.Proprietario = "proprietario3";

	List<Carro> listaCarros = new List<Carro>();
	listaCarros.Add(carro1);
	listaCarros.Add(carro2);
	listaCarros.Add(carro3);

	foreach(Carro carro in listaCarros){
       Console.WriteLine(carro.Marca);
 }
	}
}