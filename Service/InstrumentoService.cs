using AluguelInstrumentos.Core.Entidades;
using AluguelInstrumentos.Core.Interfaces;

namespace AluguelInstrumentos.Core.Servicos
{
    internal class InstrumentoService : IInstrumentoService
    {
        private readonly IInstrumentoRepositorio _repositorio;

        public InstrumentoService(IInstrumentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdicionarInstrumento(InstrumentoMusical instrumento)
        {
            _repositorio.Adicionar(instrumento);
        }

        public string ExibirDetalhesInstrumento(int codigo)
        {
            var instrumento = _repositorio.ObterPorCodigo(codigo);
            return instrumento != null ? instrumento.ExibirDetalhes() : "Instrumento não encontrado.";
        }

        public bool RemoverInstrumento(int codigo)
        {
            return _repositorio.Remover(codigo);
        }

        public IEnumerable<InstrumentoMusical> ListarInstrumentos()
        {
            return _repositorio.ListarTodos();
        }
    }
}
