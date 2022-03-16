namespace Clube_da_Leitura
{
    public class Revista
    {
        public string nome;
        public string colecao;
        public double edicao;
        public double ano;
        public Caixa caixa;

        public Revista(string nome, string colecao, double edicao, double ano, Caixa caixa)
        {
            this.nome = nome;
            this.colecao = colecao;
            this.edicao = edicao;
            this.ano = ano;
            this.caixa = caixa;
        }
        public override string ToString()
        {
            return $"{nome}";
        }
    }
}
