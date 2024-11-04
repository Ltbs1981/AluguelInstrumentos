using AluguelInstrumentos.Core.Entidades;

namespace AluguelInstrumentos.Core.Interfaces
{
    internal interface IInstrumentoRepositorio
    {
        void Adicionar(InstrumentoMusical instrumento);
        InstrumentoMusical ObterPorCodigo(int codigo);
        IEnumerable<InstrumentoMusical> ListarTodos();
        bool Remover(int codigo);
    }
}
