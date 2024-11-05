using AluguelInstrumentos.Core.Controllers;
using AluguelInstrumentos.Core.Interfaces;
using AluguelInstrumentos.Core.Servicos;
using AluguelInstrumentos.Infraestrutura;
using Microsoft.Extensions.DependencyInjection;

namespace AluguelInstrumentos
{
    public static class Startup
    {
        public static ServiceProvider ConfigureServices()
        {
            // config as DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IInstrumentoRepositorio, InstrumentoRepositorio>()
                .AddSingleton<IInstrumentoService, InstrumentoService>()
                .AddSingleton<InstrumentoController>()
                .BuildServiceProvider();

            return serviceProvider;
        }
    }
}
