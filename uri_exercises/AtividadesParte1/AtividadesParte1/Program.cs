using System;
using System.Globalization;

namespace AtividadesParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            // URI 1001
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
       
            int X = A + B;
            Console.WriteLine($"X = {X}");
            
            // Exercício 01 - URI 1003
            /*int n1, n2, SOMA;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            SOMA = n1 + n2;
            Console.WriteLine($"SOMA = {SOMA}");*/
            

            // Exercício 02  - URI 1002
            /*double raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));*/

            // Exercício 03   URI 1007
            /*int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = a * b - c * d;

            Console.WriteLine($"DIFERENCA = {diferenca}");*/
            
            // Exercício 04 - URI 1008
            /*int numero, horastrab;
            double valorporhora, salario;

            numero = int.Parse(Console.ReadLine());
            horastrab = int.Parse(Console.ReadLine());
            valorporhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horastrab * valorporhora;

            Console.WriteLine($"NUMBER = {numero}");
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));*/

            // Exercício 05 - URI 1010
            /*int cod1, qtde1, cod2, qtde2;
            double val1, val2, total;

            string[] dados = Console.ReadLine().Split(' ');
            cod1 = int.Parse(dados[0]);
            qtde1 = int.Parse(dados[1]);
            val1 = double.Parse(dados[2], CultureInfo.InvariantCulture);

            dados = Console.ReadLine().Split(' ');
            cod2 = int.Parse(dados[0]);
            qtde2 = int.Parse(dados[1]);
            val2 = double.Parse(dados[2], CultureInfo.InvariantCulture);

            total = qtde1 * val1 + qtde2 * val2;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));*/

            // Exercício 6 - URI 1012
            /*double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] dados = Console.ReadLine().Split(' ');
            a = double.Parse(dados[0], CultureInfo.InvariantCulture);
            b = double.Parse(dados[1], CultureInfo.InvariantCulture);
            c = double.Parse(dados[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = 3.14159 * Math.Pow(c, 2);
            trapezio = (a + b) / 2.0 * c;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));*/
        }
    }
}