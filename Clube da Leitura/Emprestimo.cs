namespace Clube_da_Leitura
{
    public class Emprestimo
    {
        public Amigo Amigo;
        public Revista Revista;
        public string DataEmprestimo;
        public string DataDevolucao;

        public Emprestimo(Amigo amigo, Revista revista, string dataEmprestimo, string dataDevolucao)
        {
            Amigo = amigo;
            Revista = revista;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }
    }
}
