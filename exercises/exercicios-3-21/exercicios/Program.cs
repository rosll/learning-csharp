using System;
using System.Globalization;

namespace exercicios
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1º EXEMPLO
			/*int x, y;

			string[] vet = Console.ReadLine().Split(' ');
			x = int.Parse(vet[0]);
			y = int.Parse(vet[1]);

			while (x != y)
			{
				if (x < y)
				{
					Console.WriteLine("Crescente");
				}
				else
				{
					Console.WriteLine("Decrescente");
				}

				vet = Console.ReadLine().Split(' ');
				x = int.Parse(vet[0]);
				y = int.Parse(vet[1]);
			}*/
			
			
			// 2º EXEMPLO
			/*double idade, soma, media;
			int cont;

			idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			soma = 0.0;
			cont = 0;

			while (idade >= 0)
			{
				soma = soma + idade;
				cont = cont + 1;
				idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			}

			if (cont == 0)
			{
				Console.WriteLine("Impossível Calcular");
			}
			else
			{
				media = soma / cont;
				Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
			}*/
			
			// 1º EXERCÍCIO
			/*int password = int.Parse(Console.ReadLine());

			while (password != 2002)
			{
				Console.WriteLine("Senha Inválida");
				password = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Acesso Permitido");*/
			
			// 2º EXERCÍCIO
			/*string[] values = Console.ReadLine().Split(' ');
			int x = int.Parse(values[0]);
			int y = int.Parse(values[1]);

			while (x != 0 && y != 0)
			{
				if (x > 0 && y > 0)
				{
					Console.WriteLine("primeiro");
				} 
				else if (x < 0 && y > 0)
				{
					Console.WriteLine("segundo");	
				}
				else if (x < 0 && y < 0)
				{
					Console.WriteLine("terceiro");
				}
				else
				{
					Console.WriteLine("quarto");
				}

				values = Console.ReadLine().Split(' ');
				x = int.Parse(values[0]);
				y = int.Parse(values[1]);
			}*/
			
			// 3º EXERCÍCIO
			/*int alcool = 0;
			int gasolina = 0;
			int diesel = 0;

			int type = int.Parse(Console.ReadLine());

			while (type != 4)
			{
				if (type == 1)
				{
					alcool += 1;
				}
				else if (type == 2)
				{
					gasolina += 1;
				}
				else if (type == 3)
				{
					diesel += 1;
				}

				type = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("MUITO OBRIGADO");
			Console.WriteLine($"Alcool : {alcool}");
			Console.WriteLine($"Gasolina: {gasolina}");
			Console.WriteLine($"Diesel: {diesel}");*/
			
		}
	}
}