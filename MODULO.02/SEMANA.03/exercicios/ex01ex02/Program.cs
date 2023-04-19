internal class Program
{
	static int SomaNumeros(int num1, int num2)
		{
 		return num1 + num2;
		}
	static double SomaNumeros (double num1, double num2)
		{
    	return num1 + num2;
		}
 	static double SomaNumeros (double num1, double num2, double num3)
		{
    	return num1 + num2 + num3;
		}
	private static void Main(string[] args)
	{
		
		int resultado1 = SomaNumeros(5,8);
		Console.WriteLine(resultado1);

		 double resultado2 = SomaNumeros(5.2,8.1);
		 Console.WriteLine(resultado2);

		 double resultado3 = SomaNumeros(5.2,7.2,1.1);
		 Console.WriteLine(resultado3);
	}
}