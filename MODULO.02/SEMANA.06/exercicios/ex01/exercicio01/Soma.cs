namespace exercicio01
{
    public class Soma
    {
        public static double SomarAll(List<double> valores)
        {
            double soma = 0;
            foreach (var item in valores)
            {
                soma += item;
            }
            return soma;
        }
    }
}