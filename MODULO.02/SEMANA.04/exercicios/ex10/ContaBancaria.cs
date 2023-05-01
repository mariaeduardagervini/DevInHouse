using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex10
{
    public class ContaBancaria
    {
        private double saldo;
        private List<string> transacoes = new List<string>();

        public void Deposito(double valor)
        {
            saldo += valor;
            transacoes.Add($"Deposito de {valor} realizado em {DateTime.Now}");
        }

        public bool Retirada(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                transacoes.Add($"Saque de {valor} realizado em {DateTime.Now}");
                return true;
            }
            else
            {
                return false;
            }
        }

        public double VerificarSaldo()
        {
            return saldo;
        }

        public List<string> VerificarTransacoes()
        {
            return transacoes;
        }
    }
}