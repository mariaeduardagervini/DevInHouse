using Classes;
internal class Program
{
	private static void Main(string[] args)
	{
	
	Proprietario proprietario1 = new Proprietario("Maria", "001.002.003-04", "3333-0000");

	Proprietario proprietario2 = new Proprietario("João", "004.003.002-01", "2222-0000");

	Proprietario proprietario3 = new Proprietario("Sandra", "000.003.008-07", "3444-0000");
	
	Carro carro1 = new Carro("Volkswagen", "Nivus", "MMM5E24", "Branca", proprietario1);
	
	Carro carro2 = new Carro("Fiat", "Toro", "JHG8A75", "Preta", proprietario2);
	
	Carro carro3 = new Carro("Ford", "Focus", "GHI9E35", "Prata", proprietario3);
	
	List<Carro> listaCarros = new List<Carro>();
	listaCarros.Add(carro1);
	listaCarros.Add(carro2);
	listaCarros.Add(carro3);


	void cadastrarCarros() {

		Console.Write("Digite a marca: ");
		string marca = Console.ReadLine();

		Console.Write("Digite o modelo: ");
		string modelo = Console.ReadLine();

		Console.Write("Digite a placa: ");
		string placa = Console.ReadLine();

		Console.Write("Digite a cor: ");
		string cor = Console.ReadLine();

		Console.Write("Digite o seu nome: ");
		string nome = Console.ReadLine();

		Console.Write("Digite o cpf: ");
		string cpf = Console.ReadLine();

		Console.Write("Digite o telefone: ");
		string telefone = Console.ReadLine();

		Proprietario proprietario4 = new Proprietario(nome,cpf, telefone);
		Carro carro4 = new Carro(marca, modelo, placa, cor, proprietario4);

		listaCarros.Add(carro4);
	};
	cadastrarCarros();
	
	foreach(Carro carro in listaCarros){
       Console.WriteLine(carro.Imprimir());
		 }

	}
}