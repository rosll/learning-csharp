using System;

namespace exercicio_4_40_01
{
	class Program
	{
		static void Main(string[] args)
		{
			People values1 = new People();
			People values2 = new People();

			Console.WriteLine("Dados da primeira pessoa");
			Console.Write("Nome: ");
			values1.Name = Console.ReadLine();
			Console.Write("Idade: ");
			values1.Idade = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Dados da segunda pessoa");
			Console.Write("Nome: ");
			values2.Name = Console.ReadLine();
			Console.Write("Idade: ");
			values2.Idade = int.Parse(Console.ReadLine());

			if (values1.Idade > values2.Idade)
			{
				Console.Write($"Pessoa mais velha: {values1.Name}");
			}
			else
			{
				Console.Write($"Pessoa mais velha: {values2.Name}");
			}
		}
	}
}