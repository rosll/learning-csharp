namespace exercicio_4_48_01
{
    public class ConversorDeMoeda
    {
        public static double iof = 6.0;

        public static double Calculo(double cotacao, double dolar)
        {
            double result = cotacao * dolar;
            return result + result * iof / 100;
        }
    }
}