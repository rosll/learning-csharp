using System;
using System.Globalization;
using System.Threading.Channels;

namespace exercicio_4_40_02
{
	class Program
	{
		static void Main(string[] args)
		{  
			Employee values1 = new Employee();
			Employee values2 = new Employee();

			Console.WriteLine("Dados do primeiro funcionário");
			Console.Write("Nome: ");
			values1.Name = Console.ReadLine();
			Console.Write("Salário: ");
			values1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			Console.WriteLine("Dados do segundo funcionário");
			Console.Write("Nome: ");
			values2.Name = Console.ReadLine();
			Console.Write("Salário: ");
			values2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			
			double mean = (values1.Salary + values2.Salary) / 2.0;
			
			Console.Write($"Salário médio: {mean.ToString("F2", CultureInfo.InvariantCulture)}");
		}
	}
}