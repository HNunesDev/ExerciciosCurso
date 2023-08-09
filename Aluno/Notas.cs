namespace Aluno
{
    internal class Notas
    {
        public string Nome;
        public double NotaUm;
        public double NotaDois;
        public double NotaTres;

        public double Media()
        {
            double M = NotaUm + NotaDois + NotaTres;
            return M;
        }

        public override string ToString()
        {
            return "Aluno: " + Nome + "  Nota Final: " + Media().ToString("F2");
        }

    }
}
