﻿using System;
using System.Globalization;

namespace ExMembroEstatico_01
{
    class Program
    {
        static double pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine($"Circunferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {pi.ToString(CultureInfo.InvariantCulture)}");
        }

        static double Circunferencia(double r)
        {
            return 2.0 * pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }
    }
}