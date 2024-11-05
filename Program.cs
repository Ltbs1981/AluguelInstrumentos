using AluguelInstrumentos.Core.Controllers;
using AluguelInstrumentos.Core.Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AluguelInstrumentos
{
    class Program
    {
        static void Main()
        {
            // config dos serviços
            var serviceProvider = Startup.ConfigureServices();

            // criando um obj do controller para operar
            var controller = serviceProvider.GetService<InstrumentoController>();

            // chamada no main

            // Criar e adicionar instrumentos
            var guitarra = new Guitarra("Fender", "Stratocaster", 2020, 101, 250.00, true, true, true, 22);
            var violao = new Violao("Yamaha", "C40", 2018, 102, 150.00, false, false, true, "Cedro");
            var baixo = new ContraBaixo("Ibanez", "SR300", 2019, 103, 200.00, true, true, true, "0.45");

            controller.AdicionarInstrumento(guitarra);
            controller.AdicionarInstrumento(violao);
            controller.AdicionarInstrumento(baixo);

            // Listar todos os instrumentos
            Console.WriteLine("\n--- Lista de Instrumentos ---");
            controller.ListarInstrumentos();

            // Exibir detalhes de um instrumento específico
            Console.WriteLine("\n--- Detalhes da Guitarra ---");
            controller.ExibirDetalhes(101);

            // Remover um instrumento
            Console.WriteLine("\n--- Removendo o Violão ---");
            controller.RemoverInstrumento(102);

            // Listar instrumentos novamente
            Console.WriteLine("\n--- Lista de Instrumentos Atualizada ---");
            controller.ListarInstrumentos();
        }
    }
}
