using System.Globalization;

namespace exercicio_5_60
{
    public class Conta
    {
        public int Num { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int num, string titular)
        {
            Num = num;
            Titular = titular;
        }
        
        public Conta(int num, string titular, double valorDepositoInicial) : this(num, titular) 
        {
            Depositar(valorDepositoInicial);
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Sacar(double valorSaque)
        {
            Saldo -= valorSaque + 5.00;
        }

        public override string ToString()
        {
            return $"Conta {Num}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}