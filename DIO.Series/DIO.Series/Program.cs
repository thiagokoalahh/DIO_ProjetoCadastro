using DIO.Series.Classes;
using DIO.Series.Interfaces;
using System;
using System.Collections.Generic;

namespace DIO.Series
{
    class Program
    {
        // IService exerce contrato com os serviços disponíveis (Séries e Filmes)
        static List<IService> services = new List<IService>();

        static void Main(string[] args)
        {
            // Adicina os serviços
            services.Add(SerieService.GetInstance());
            services.Add(FilmeService.GetInstance());

            // Conteudo é responsável por alterar qual serviço está sendo utilizado
            int conteudo = EscolherServico();

            // Exibe o menu de acordo com o serviço
            string opcaoUsuario = services[conteudo].ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                Console.WriteLine();
                switch (opcaoUsuario)
                {
                    case "1":
                        services[conteudo].Listar();
                        break;
                    case "2":
                        services[conteudo].Inserir();
                        break;
                    case "3":
                        services[conteudo].Atualizar();
                        break;
                    case "4":
                        services[conteudo].Excluir();
                        break;
                    case "5":
                        services[conteudo].Visualizar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "M":
                        conteudo = EscolherServico();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = services[conteudo].ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        // Menu para a troca de serviços
        private static int EscolherServico()
        {
            Console.WriteLine();
            Console.WriteLine("DioFlix a seu dispor!!!");
            Console.WriteLine("Informe o conteúdo desejado:");

            Console.WriteLine("0- Séries");
            Console.WriteLine("1- Filmes");

            int opcaoUsuario = int.Parse(Console.ReadLine());
            return opcaoUsuario;
        }
    }
}