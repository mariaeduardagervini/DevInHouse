﻿internal class Program
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

		// EXEMPLO 07 - CALCULADORA

		// Variáveis
		// double numero1, numero2;
		// char operacao;

		// Console.WriteLine("Olá! Seja bem-vindo(a) a Calculadora!");

		// do {
		// 	Console.WriteLine("Agora, escolha uma operação: ");

		// 	Console.WriteLine("+ : SOMA");
		// 	Console.WriteLine("- : SUBTRAIR");
		// 	Console.WriteLine("* : MULTIPLICAR");
		// 	Console.WriteLine("/ : DIVIDIR");
		// 	Console.WriteLine("? : SAIR");
			
		// 	// Entradas
		// 	Console.Write("\nDigite a operação escolhida: "); //\n quebra a linha
		// 	operacao = char.Parse(Console.ReadLine());
			
		// 	if(operacao != '?') {
		// 		Console.WriteLine("Digite o primeiro número: ");
		// 		numero1 = int.Parse(Console.ReadLine());
		// 		Console.WriteLine("Digite o segundo número: ");
		// 		numero2 = int.Parse(Console.ReadLine());

		// 		switch (operacao)
		// 		{
		// 		case '+':
		// 			Console.WriteLine(numero1 + numero2);
		// 			break;
		// 		case '-':
		// 			Console.WriteLine(numero1 - numero2);
		// 			break;
		// 		case '*':
		// 			Console.WriteLine(numero1 * numero2);
		// 			break;
		// 		case '/':
		// 			Console.WriteLine(numero1 / numero2);
		// 			break;
		// 		default:
		// 			Console.WriteLine("Opção inválida");
		// 			break;
		// 		}
		// 	}
		// } while (operacao != '?');
		
		// Console.WriteLine("\nObrigado por usar a calculadora!");
		

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
		
		


		// Saídas

// EXEMPLO DE LAÇO DE REPETIÇÃO FOR
	// for(int i = 1; i <= 20; i++) 
	// {
	// 	Console.Write(i + ", ");
	// }
	// Console.WriteLine("Fora do campo de repetição.")

// EXEMPLO DE LAÇO DE REPETIÇÃO WHILE
	// bool condicao = true;
	// int valor = 0;
	// while(condicao) 
	// {
	// 	if(valor == 10) {
	// 	condicao = false;
	// 	}
	// 	Console.WriteLine(valor++); // valor = valor + 1
	// }

	// LISTAS -  aula 04

		// List<string> nomes = new List<string>{"Maria", "Eduarda"};

		// nomes.Add("Luiz");
	
		// Console.WriteLine(nomes[1]);

		// nomes.Insert(1, "Roberta");

		// Console.WriteLine(nomes[1]);

		// Console.WriteLine("Imprimindo a posição 0: " + nomes.ElementAt(0));

		// Console.WriteLine("Count: " + nomes.Count());

		// Console.WriteLine("O nome Peterson existe na lista: " + nomes.Contains("Peterson"));
		// Console.WriteLine("O nome Maria existe na lista: " + nomes.Contains("Maria"));
	
		// Console.WriteLine("Limpando a lista... ");
		// nomes.Clear();

		// Console.WriteLine("Count: " + nomes.Count());

		// Console.WriteLine("Imprimindo a primeira posição da lista, após limpar... ");
		// Console.WriteLine(nomes[0]);

		// ARRAYS - aula 04
		string[] nomes = {"Maria", "João", "José", "Marcos", "Marcelo", "Romeu"};

		Console.WriteLine(nomes.Length);

		nomes[5] = "Julieta";
		Console.WriteLine(nomes.Length);
		Console.WriteLine($"O nome na posição 5 é: {nomes[5]}");
		//nomes[0] = "Romeu";
		Console.WriteLine($"O nome Romeu existe no array? {nomes.Contains("Romeu")}");

		// int[] numeros = new int[3];


	 }
}


