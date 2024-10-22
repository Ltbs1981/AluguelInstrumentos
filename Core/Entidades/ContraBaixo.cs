namespace AluguelInstrumentos.Core.Entidades
{
    internal class ContraBaixo : InstrumentoMusical
    {
        public string CalibreCorda { get; set; }

        // Construtor que herda da classe base InstrumentoMusical
        public ContraBaixo(string marca, string modelo, int ano, int codigoProduto, double valorAluguel, bool eletrico, bool premium, bool disponivelLocacao, string calibreCorda)
            : base(marca, modelo, ano, codigoProduto, valorAluguel, eletrico, premium, disponivelLocacao)
        {
            CalibreCorda = calibreCorda;
        }

        // Sobrescrevendo o método ExibirDetalhes da classe base
        public override string ExibirDetalhes()
        {
            // Chamando o método ExibirDetalhes da classe base para reutilizar os detalhes gerais
            string detalhes = base.ExibirDetalhes();
            return $"{detalhes} Calibre das cordas: {CalibreCorda}";
        }
    }
}
