using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            conta.Deposito(500);
            Console.WriteLine($"Saldo: {conta.VerificarSaldo()}");

            conta.Retirada(200);
            Console.WriteLine($"Saldo: {conta.VerificarSaldo()}");

            conta.Deposito(300);
            Console.WriteLine($"Saldo: {conta.VerificarSaldo()}");

            System.Console.WriteLine("Transações Realizadas:");

            foreach (string transacao in conta.VerificarTransacoes())
            {
                System.Console.WriteLine(transacao);
            }
        }
    }
}