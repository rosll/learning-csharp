namespace exercicio_4_45_03
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaTotal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaTotal() >= 60.0)
            {
                return true;
            }

            return false;
        }

        public double PontoPendente()
        {
            if (Aprovado())
            {
                return 0.0;
            }

            return 60.0 - NotaTotal();
        }
    }
}