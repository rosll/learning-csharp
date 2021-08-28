using System;

namespace for_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Quantos números inteiros voce vai digitar? ");
			int N = int.Parse(Console.ReadLine());

			int sum = 0;
			for (int i = 1; i <= N; i++)
			{
				Console.Write($"Valor #{i}: ");
				int value = int.Parse(Console.ReadLine());
				sum += value;
			}

			Console.WriteLine($"Soma = {sum}");
		}
	}
}