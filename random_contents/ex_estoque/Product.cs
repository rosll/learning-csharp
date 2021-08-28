using System.Globalization;

namespace ex_estoque
{
	public class Product
	{
		public string Name;
		public double Price;
		public int Amount;

		public double ValorTotalEmEstoque()
		{
			return Price * Amount;
		}

		public void AdicionarProdutos(int amount)
		{
			Amount += amount;
		}

		public void RemoverProdutos(int amount)
		{
			Amount -= amount;
		}

		public override string ToString()
		{
			return Name 
			       + ", $ " 
			       + Price.ToString("F2", CultureInfo.InvariantCulture)
			       + ", "
			       + Amount
			       + " unidades, Total: $ "
			       + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}