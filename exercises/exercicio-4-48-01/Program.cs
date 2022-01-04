using System;
using System.Globalization;

namespace exercicio_4_48_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares voce vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Calculo(cotacao, dolar);
            Console.WriteLine($"Valor a ser pago em reais = {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}