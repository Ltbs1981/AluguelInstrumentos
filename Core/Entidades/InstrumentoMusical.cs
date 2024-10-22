namespace AluguelInstrumentos.Core.Entidades
{
    internal class InstrumentoMusical
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int CodigoProduto { get; set; }
        public double ValorAluguel { get; set; }
        public string Status { get; private set; }
        public bool Eletrico { get; set; }
        public bool Premium { get; set; }
        public bool DisponivelLocacao { get; set; }

        public InstrumentoMusical(string marca, string modelo, int ano, int codigoProduto, double valorAluguel, bool eletrico, bool premium, bool disponivelLocacao)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            CodigoProduto = codigoProduto;
            ValorAluguel = valorAluguel;
            Eletrico = eletrico;
            Premium = premium;
            DisponivelLocacao = disponivelLocacao;
            Status = DisponivelLocacao ? "Disponível" : "Alugado";
        }

        // Método para atualizar o status do instrumento
        public void AtualizarStatus(bool disponivel)
        {
            DisponivelLocacao = disponivel;
            Status = disponivel ? "Disponível" : "Alugado";
        }

        // Método para exibir os detalhes do instrumento
        public virtual string ExibirDetalhes()
        {
            string tipoInstrumento = Eletrico ? "elétrico" : "acústico";
            string categoria = Premium ? "premium" : "comum";

            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Código: {CodigoProduto}, Valor para aluguel: {ValorAluguel}. " +
                   $"O instrumento é {tipoInstrumento}, categoria: {categoria}. Status: {Status}.";
        }
    }
}