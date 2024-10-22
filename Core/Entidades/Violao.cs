namespace AluguelInstrumentos.Core.Entidades
{
    internal class Violao : InstrumentoMusical
    {
        public string TipoMadeira { get; set; }

        // Construtor que herda da classe base InstrumentoMusical
        public Violao(string marca, string modelo, int ano, int codigoProduto, double valorAluguel, bool eletrico, bool premium, bool disponivelLocacao, string tipoMadeira)
            : base(marca, modelo, ano, codigoProduto, valorAluguel, eletrico, premium, disponivelLocacao)
        {
            TipoMadeira = tipoMadeira;
        }

        // Sobrescrevendo o método ExibirDetalhes da classe base
        public override string ExibirDetalhes()
        {
            // Chamando o método ExibirDetalhes da classe base para reutilizar os detalhes gerais
            string detalhes = base.ExibirDetalhes();
            return $"{detalhes} Tipo de madeira: {TipoMadeira}";
        }
    }
}
