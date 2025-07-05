using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMini.Models;

namespace BibliotecaMini.Views
{
    public class LivroView
    {
        public string ObterOpcaoDoMenu()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("    MINI BIBLIOTECA C# - SISTEMA MVC");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Listar todos os livros");
            Console.WriteLine("2 - Listar livros disponíveis");
            Console.WriteLine("3 - Buscar livro por título");
            Console.WriteLine("4 - Buscar livro por autor");
            Console.WriteLine("5 - Emprestar livro");
            Console.WriteLine("6 - Devolver livro");
            Console.WriteLine("7 - Cadastrar novo livro");
            Console.WriteLine("8 - Sair");
            Console.Write("Opção: ");

            return Console.ReadLine();
        }

        public void ExibirLivros(List<Livro> livros, string titulo = "LIVROS")
        {
            Console.Clear();
            Console.WriteLine($"========== {titulo} ==========");
            Console.WriteLine();

            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro encontrado.");
            }
            else
            {
                Console.WriteLine($"Total de livros: {livros.Count}");
                Console.WriteLine("".PadRight(80, '-'));
                foreach (var livro in livros)
                {
                    Console.WriteLine(livro.ToString());
                }
            }
        }

        public string SolicitarTexto(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        public int SolicitarNumero(string mensagem)
        {
            Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                return numero;
            }
            return 0;
        }

        public void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void PausarEVoltarAoMenu()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public Livro SolicitarDadosNovoLivro()
        {
            Console.Clear();
            Console.WriteLine("========== CADASTRAR NOVO LIVRO ==========");
            Console.WriteLine();

            int id = SolicitarNumero("ID do livro: ");
            string titulo = SolicitarTexto("Título: ");
            string autor = SolicitarTexto("Autor: ");
            string genero = SolicitarTexto("Gênero: ");
            int ano = SolicitarNumero("Ano de publicação: ");
            string isbn = SolicitarTexto("ISBN: ");
            int paginas = SolicitarNumero("Número de páginas: ");

            return new Livro(id, titulo, autor, genero, ano, true, isbn, paginas);
        }
    }
}
