using System;
using System.Globalization;

namespace exercicios_3_23
{
	class Program
	{
		static void Main(string[] args)
		{
			/* EXEMPLO 1 
			int N = int.Parse(Console.ReadLine());

			for (int i = 1; i <= 10; i++)
			{
				int resultado = i * N;
				Console.WriteLine($"{N} X {i} = {resultado}");
			}*/

			/* EXEMPLO 2 - soma dos numeros impares entre x e y.
			 
			int x, y, min, max, soma;

			x = int.Parse(Console.ReadLine());
			y = int.Parse(Console.ReadLine());

			if (x < y)
			{
				min = x;
				max = y;
			}
			else
			{
				min = y;
				max = x;
			}

			soma = 0;
			for (int i = min + 1; i < max; i++)
			{
				if (i % 2 != 0)
				{
					soma = soma + i;
				}
			}

			Console.WriteLine(soma);*/
			
			// EXERCICIO 1
			/*int value = int.Parse(Console.ReadLine());
			Console.WriteLine("--------");

			for (int i = 1; i <= value; i++)
			{
				if (i % 2 != 0)
				{
					Console.WriteLine(i);
				}
			}*/
			
			// EXERCICIO 2
			/*int N = int.Parse(Console.ReadLine());
			Console.WriteLine("-----------");

			int v_in = 0;
			int v_out = 0;
			
			
			for (int i = 0; i < N; i++)
			{
				int x = int.Parse(Console.ReadLine());
				if (x >= 10 && x <= 20)
				{
					v_in += 1;
				}
				else
				{
					v_out += 1;
				}
			}

			Console.WriteLine($"{v_in} in");
			Console.WriteLine($"{v_out} out");*/

			// EXERCICIO 3
			/*int N = int.Parse(Console.ReadLine());

			for (int i = 0; i < N; i++)
			{
				string[] values = Console.ReadLine().Split(' ');
				double val_1 = double.Parse(values[0], CultureInfo.InvariantCulture);
				double val_2 = double.Parse(values[1], CultureInfo.InvariantCulture);
				double val_3 = double.Parse(values[2], CultureInfo.InvariantCulture);
				
				double media = (val_1 * 2.0 + val_2 * 3.0 + val_3 * 5.0) / 10.0;

				Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
				Console.WriteLine("-------------");
			}*/
			
			// EXERCICIO 4
			/*int N = int.Parse(Console.ReadLine());

			for (int i = 0; i < N; i++)
			{
				string[] values = Console.ReadLine().Split(' ');
				int val_1 = int.Parse(values[0]);
				int val_2 = int.Parse(values[1]);

				if (val_2 == 0)
				{
					Console.WriteLine("divisao impossivel");
					Console.WriteLine("-------");
				}
				else
				{
					double result = (double)val_1 / val_2;
					Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture)); 
					Console.WriteLine("-------");
				}                                       
			}*/
			
			// EXERCICIO 5
			/*int N = int.Parse(Console.ReadLine());
			
			int fatorial = 1;

			for (int i = 1; i <= N; i++)
			{
				fatorial *= i;
			}

			Console.WriteLine(fatorial);*/
			
			// EXERCICIO 6
			/*int N = int.Parse(Console.ReadLine());

			for (int i = 1; i <= N; i++)
			{
				if (N % i == 0)
				{
					Console.WriteLine(i);
				}
			}*/
			
			// EXERCICIO 7
			/*int N = int.Parse(Console.ReadLine());

			for (int i = 1; i <= N; i++)
			{
				int first =  i;
				int second =  i * i;
				int three =  i * i * i;

				Console.WriteLine($"{first} {second} {three}");
			}*/
		}
	}
}