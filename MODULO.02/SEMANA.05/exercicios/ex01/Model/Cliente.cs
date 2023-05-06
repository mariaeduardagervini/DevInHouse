namespace BancoFullStack.Model
{
    public abstract class Cliente
    {
        public int NumeroConta { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public decimal Saldo { get; set; }

        public Cliente() {}

        public Cliente(int numeroConta, string endereco, string telefone)
        {
            NumeroConta = numeroConta;
            Endereco = endereco;
            Telefone = telefone;
            Saldo = 0;
        }

        public virtual string ResumoCliente(){
            return $"Número da Conta: {NumeroConta} | Endereço: {Endereco} | Telefone: {Telefone} | Saldo: {Saldo.ToString("C2")}";
        }
    }
}