using AluguelInstrumentos.Core.Entidades;
using AluguelInstrumentos.Core.Interfaces;

namespace AluguelInstrumentos.Infraestrutura
{
    internal class InstrumentoRepositorio : IInstrumentoRepositorio
    {
        private readonly Dictionary<int, InstrumentoMusical> _instrumentos = new();

        public void Adicionar(InstrumentoMusical instrumento)
        {
            if (!_instrumentos.ContainsKey(instrumento.CodigoProduto))
            {
                _instrumentos[instrumento.CodigoProduto] = instrumento;
            }
        }

        public InstrumentoMusical ObterPorCodigo(int codigo)
        {
            _instrumentos.TryGetValue(codigo, out var instrumento);
            return instrumento;
        }

        public IEnumerable<InstrumentoMusical> ListarTodos()
        {
            return _instrumentos.Values;
        }

        public bool Remover(int codigo)
        {
            return _instrumentos.Remove(codigo);
        }
    }
}
