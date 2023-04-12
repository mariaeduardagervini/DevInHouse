internal class Program
{
	private static void Main(string[] args)
	{
		// Variáveis
		//String? nome; // Tipo de dado "texto"
		//int idade; // Declaração de duas variáveis do tipo inteiro
		//Mensagens instrucionais ao usuário
		//Console.WriteLine("Olá mundo! Digite o seu nome: ");

		// Entradas - Inserção de dados
		//nome = Console.ReadLine(); // Aguardando o usuário digitar 

		//Console.WriteLine("Olá " + nome + ", digite a sua idade: ");
		//idade = int.Parse(Console.Read());
	
		// Processamentos - cálculos, regras de negócio

		//Saídas: mostrar resultados em tela
		//Console.WriteLine("Olá " + nome + ", a sua idade é " + (idade + 1)); // + está concatenando 


		// EXEMPLO 02, OPERADORES

		// int numero1 =10;
		// int numero2 = 15;

		// int soma = numero1 + numero2;
		// int subtracao = numero1 - numero2;
		// int multiplicacao = numero1 * numero2;
		// double divisao = numero1 / numero2;
		// int restoDaDivisao = numero1 % numero2;

		// Console.WriteLine(soma);
		// Console.WriteLine(subtracao);
		// Console.WriteLine(multiplicacao);
		// Console.WriteLine(divisao);
		// Console.WriteLine(restoDaDivisao);

		// EXEMPLO 03

		// Console.WriteLine("Digite o primeiro número: ");
		// int numero1 = int.Parse(Console.ReadLine());

		// Console.WriteLine("Digite o segundo número: ");
		// int numero2 = int.Parse(Console.ReadLine());

		// //Processamentos
		// int soma = numero1 + numero2;

		// // Saídas
		// Console.WriteLine("A soma dos números é: " + soma);

		// EXEMPLO 04 

		//Console.WriteLine((2 + 2) * 2);

		// EXEMPLO 05

		// Console.WriteLine("Digite o primeiro número: ");
		// int numero1 = int.Parse(Console.ReadLine());

		// Console.WriteLine("Digite o segundo número: ");
		// int numero2 = int.Parse(Console.ReadLine());

		// // Estrutura condicional, if-else
		// if (numero1 > numero2)
		// {
		// 	Console.WriteLine("O primeiro número é maior");	
		// }else if(numero1 == numero2){
		// 	Console.WriteLine("Os números são iguais!");
		// } else {
		// 	Console.WriteLine("O segundo número é maior");
		// }
		//Console.WriteLine(1 == 1);
		//Console.WriteLine(2 >= 5);

		// EXEMPLO 06

		// Console.WriteLine("Digite um número para verificar se ele é ímpar ou par: ");
		// int numero = int.Parse(Console.ReadLine());

		// if(numero % 2 == 0) 
		// {
		// 	Console.WriteLine("O número é par!");
		// }
		// else
		// {
		// 	Console.WriteLine("O número é ímpar!");
		// }

		// EXEMPLO 07

		// Variáveis
		double numero1, numero2;
		string operacao;

		Console.WriteLine("Olá! Seja bem-vindo(a) a Calculadora!");

		Console.WriteLine("Agora, escolha uma operação: ");

		Console.WriteLine("+ : SOMA");
		Console.WriteLine("- : SUBTRAIR");
		Console.WriteLine("* : MULTIPLICAR");
		Console.WriteLine("/ : DIVIDIR");
		Console.WriteLine("? : SAIR");
		
		// Entradas
		Console.Write("\nDigite a operação escolhida: "); //\n quebra a linha
		operacao = char.Parse(Console.ReadLine());
		

		Console.WriteLine("Digite o primeiro número: ");
		numero1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o segundo número: ");
		numero2 = int.Parse(Console.ReadLine());

		// Processamentos/Operações
		// MENU COM IF-ELSE
		// if(operacao == "+") 
		// {
		// 	Console.WriteLine("soma");
		// } else if( operacao == "-") 
		// {
		// 	Console.WriteLine("subtração");
		// } else if( operacao == "*") {
		// 	Console.WriteLine("multiplicação");
		// }else if( operacao == "/") {
		// 	Console.WriteLine("divisão");
		// }else if( operacao == "?") {
		// 	Console.WriteLine("sair");
		// } else {
		// 	Console.WriteLine("Opção inválida! digite uma opção disponível no menu.");
		// }
		// MENU COM SWITCH CASE (OUTRAS ESTRUTURA CONDICIONAL)
		switch (operacao)
		{
			case "+":
				Console.WriteLine(numero1 + numero2);
				break;
			case "-":
				Console.WriteLine(numero1 - numero2);
				break;
			case "*":
				Console.WriteLine(numero1 * numero2);
				break;
			case "/":
				Console.WriteLine(numero1 / numero2);
				break;
			case "?":
				Console.WriteLine("Saindo do sistema...");
				break;
			default:
				Console.WriteLine("Caso nenhuma das opções");
				break;
		}
		


		// Saídas
	}
}


