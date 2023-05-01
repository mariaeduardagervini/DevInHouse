using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex09
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Valor de Pi: " + Calculadora.Pi);

            int a = 8;
            int b = 6;

            System.Console.WriteLine("Soma: " + Calculadora.Soma(a, b));
            System.Console.WriteLine("Subtração: " + Calculadora.Subtracao(a, b));
            System.Console.WriteLine("Multiplicação: " + Calculadora.Multiplicacao(a, b));
            System.Console.WriteLine("Divisão: " + Calculadora.Divisao(a, b));
        }
    }
}