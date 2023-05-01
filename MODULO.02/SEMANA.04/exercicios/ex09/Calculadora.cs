using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex09
{
    public static class Calculadora
    {
        public const double Pi = 3.14159;

        public static int Soma(int a, int b)
        {
            return a + b;
        }

        public static int Subtracao(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicacao(int a, int b)
        {
            return a * b;
        }

        public static int Divisao(int a, int b)
        {
            
            if (b == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida");
            }
            
            return a / b;
        }

    }
}