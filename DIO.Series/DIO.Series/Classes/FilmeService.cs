using DIO.Series.Interfaces;
using System;

namespace DIO.Series.Classes
{
    // Classe implementada com o Design Pattern Singleton
    // Segue a mesma ideia de uma Controller.
    // Todos os métodos que interagem com Filme e FilmeRepositorio ficam armazenados aqui.
    public class FilmeService : IService
    {
        private FilmeRepositorio repositorio = new FilmeRepositorio();
        private static FilmeService filmeService;

        // Singleton
        private FilmeService()
        {
        }

        public static FilmeService GetInstance()
        {
            if (filmeService == null)
            {
                filmeService = new FilmeService();
            }
            return filmeService;
        }

        public void Excluir()
        {
            Console.Write("EXCLUIR - Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceFilme);
        }

        public void Visualizar()
        {
            Console.Write("VISUALIZAR - Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorio.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);
        }

        public void Atualizar()
        {
            Console.Write("ATUALIZAR - Digite o id ddo filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(indiceFilme, atualizaFilme);
        }
        public void Listar()
        {
            Console.WriteLine("Listar Filmes");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.RetornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", filme.RetornaId(), filme.RetornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        public void Inserir()
        {
            Console.WriteLine("Inserir novo filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Insere(novoFilme);
        }

        // Exibe o menu
        public string ObterOpcaoUsuario()
        {
                Console.WriteLine();
                Console.WriteLine("DIO Filmes a seu dispor!!!");
                Console.WriteLine("Informe a opção desejada:");

                Console.WriteLine("1- Listar filmes");
                Console.WriteLine("2- Inserir novo filme");
                Console.WriteLine("3- Atualizar filme");
                Console.WriteLine("4- Excluir filme");
                Console.WriteLine("5- Visualizar filme");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("M- Mudar de Serviço");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
        }
    }
}
