namespace AluguelInstrumentos.Core.Entidades
{
    internal class Guitarra : InstrumentoMusical
    {
        public int NumeroTrastes { get; set; }

        // Construtor que herda da classe base InstrumentoMusical
        public Guitarra(string marca, string modelo, int ano, int codigoProduto, double valorAluguel, bool eletrico, bool premium, bool disponivelLocacao, int numeroTrastes)
            : base(marca, modelo, ano, codigoProduto, valorAluguel, eletrico, premium, disponivelLocacao)
        {
            NumeroTrastes = numeroTrastes;
        }

        // Sobrescrevendo o método ExibirDetalhes da classe base
        public override string ExibirDetalhes()
        {
            // Chamando o método ExibirDetalhes da classe base para reutilizar os detalhes gerais
            string detalhes = base.ExibirDetalhes();
            return $"{detalhes} Número de trastes: {NumeroTrastes}";
        }
    }
}
