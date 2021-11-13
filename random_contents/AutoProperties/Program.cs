using System;

namespace Construct {
    class Program {
        static void Main(string[] args)
        {

            Produto p = new Produto("Tv", 500.00, 10);
            
            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}