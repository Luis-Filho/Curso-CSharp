namespace Exercicio_aluno
{
    class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];

        public double SomaNotas()
        {
            return Notas[0] + Notas[1] + Notas[2];
        }
    }
}
