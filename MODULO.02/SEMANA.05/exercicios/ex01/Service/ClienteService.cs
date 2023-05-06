using BancoFullStack.Model;


namespace BancoFullStack.Service
{
    public class ClienteService 
    {
        private static List<Cliente> _clientes = new List<Cliente>();

        public ClienteService()
        {
            _clientes.Add(new PessoaFisica(555,"Rua Caminho ", "756", "400", "Maria", new DateTime(1993,05,5)));
           
        }
        public void CriarConta(){
            Console.WriteLine("Qual o tipo de conta que deseja Criar? ");
            Console.WriteLine("1 - Pessoa Física ");
            Console.WriteLine("2 - Pessoa Jurídica ");
            var opcao = Console.ReadLine();

           
        }

        public Cliente BuscarClientePorNumeroDeConta(int numeroConta) {
            return _clientes.Find(cliente => cliente.NumeroConta == numeroConta);
        }

        public void ExibirClientes(){
            foreach (var cliente in _clientes){
                Console.WriteLine(cliente.ResumoCliente());
            }
        }
	}
}