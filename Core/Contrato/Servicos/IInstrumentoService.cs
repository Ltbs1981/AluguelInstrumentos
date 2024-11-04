using AluguelInstrumentos.Core.Entidades;

namespace AluguelInstrumentos.Core.Interfaces
{
    internal interface IInstrumentoService
    {
        void AdicionarInstrumento(InstrumentoMusical instrumento);
        string ExibirDetalhesInstrumento(int codigo);
        bool RemoverInstrumento(int codigo);
        IEnumerable<InstrumentoMusical> ListarInstrumentos();
    }
}
