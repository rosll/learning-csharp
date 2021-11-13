using System;

namespace Construct {
    class Program {
        static void Main(string[] args)
        {

            Produto p = new Produto("Tv", 500.00, 10);
            
            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}