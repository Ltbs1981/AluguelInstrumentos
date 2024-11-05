using AluguelInstrumentos.Core.Entidades;
using AluguelInstrumentos.Core.Interfaces;

namespace AluguelInstrumentos.Core.Controllers
{
    internal class InstrumentoController
    {
        private readonly IInstrumentoService _service;

        public InstrumentoController(IInstrumentoService service)
        {
            _service = service;
        }

        public void AdicionarInstrumento(InstrumentoMusical instrumento)
        {
            _service.AdicionarInstrumento(instrumento);
            Console.WriteLine("Instrumento adicionado com sucesso!");
        }

        public void ExibirDetalhes(int codigo)
        {
            Console.WriteLine(_service.ExibirDetalhesInstrumento(codigo));
        }

        public void ListarInstrumentos()
        {
            var instrumentos = _service.ListarInstrumentos();
            if (!instrumentos.Any())
            {
                Console.WriteLine("Nenhum instrumento cadastrado.");
                return;
            }
            foreach (var instrumento in instrumentos)
            {
                Console.WriteLine(instrumento.ExibirDetalhes());
            }
        }

        public void RemoverInstrumento(int codigo)
        {
            if (_service.RemoverInstrumento(codigo))
                Console.WriteLine("Instrumento removido com sucesso!");
            else
                Console.WriteLine("Instrumento não encontrado.");
        }
    }
}
