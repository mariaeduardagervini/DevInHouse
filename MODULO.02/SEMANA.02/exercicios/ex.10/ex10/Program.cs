internal class Program
{
	private static void Main(string[] args)
	{
	double numero1, numero2;
	char operacao;

	Console.WriteLine("Olá! Seja bem-vindo(a) a Calculadora!");

	do {
		Console.WriteLine("Agora, escolha uma operação: ");

		Console.WriteLine("+ : SOMA");
		Console.WriteLine("- : SUBTRAIR");
		Console.WriteLine("* : MULTIPLICAR");
		Console.WriteLine("/ : DIVIDIR");
		Console.WriteLine("? : SAIR");
					
		Console.Write("\nDigite a operação escolhida: ");
		operacao = char.Parse(Console.ReadLine());
					
		if(operacao != '?') {
		 	Console.WriteLine("Digite o primeiro número: ");
		 	numero1 = int.Parse(Console.ReadLine());
		 	Console.WriteLine("Digite o segundo número: ");
		 	numero2 = int.Parse(Console.ReadLine());

		 	switch (operacao)
		 	{
		 		case '+':
		 			Console.WriteLine(numero1 + numero2);
		 			break;
		 		case '-':
		 			Console.WriteLine(numero1 - numero2);
		 			break;
		 		case '*':
		 			Console.WriteLine(numero1 * numero2);
		 			break;
		 		case '/':
		 			Console.WriteLine(numero1 / numero2);
		 			break;
		 		default:
		 			Console.WriteLine("Opção inválida");
		 			break;
		 	}
		}
	} while (operacao != '?');
		
		Console.WriteLine("\nObrigado por usar a calculadora!");
	}
}


		