using System;
using System.Globalization;

namespace exercicio_4_45_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo calc = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            calc.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            calc.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {calc.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {calc.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {calc.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}