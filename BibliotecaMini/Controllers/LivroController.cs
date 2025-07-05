using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMini.Data;
using BibliotecaMini.Models;
using BibliotecaMini.Views;

namespace BibliotecaMini.Controllers
{
    public class LivroController
    {
        private readonly LivroRepositorio _repositorio;
        private readonly LivroView _view;

        public LivroController()
        {
            _repositorio = new LivroRepositorio();
            _view = new LivroView();
        }

        public void IniciarSistema()
        {
            bool continuar = true;

            while (continuar)
            {
                string opcao = _view.ObterOpcaoDoMenu();

                switch (opcao)
                {
                    case "1":
                        ListarTodosOsLivros();
                        break;
                    case "2":
                        ListarLivrosDisponiveis();
                        break;
                    case "3":
                        BuscarLivroPorTitulo();
                        break;
                    case "4":
                        BuscarLivroPorAutor();
                        break;
                    case "5":
                        EmprestarLivro();
                        break;
                    case "6":
                        DevolverLivro();
                        break;
                    case "7":
                        CadastrarNovoLivro();
                        break;
                    case "8":
                        continuar = false;
                        _view.ExibirMensagem("Obrigado por usar a Mini Biblioteca!");
                        break;
                    default:
                        _view.ExibirMensagem("Opção inválida!");
                        _view.PausarEVoltarAoMenu();
                        break;
                }
            }
        }

        private void ListarTodosOsLivros()
        {
            var livros = _repositorio.ObterTodosOsLivros();
            _view.ExibirLivros(livros, "TODOS OS LIVROS");
            _view.PausarEVoltarAoMenu();
        }

        private void ListarLivrosDisponiveis()
        {
            var livros = _repositorio.ObterLivrosDisponiveis();
            _view.ExibirLivros(livros, "LIVROS DISPONÍVEIS");
            _view.PausarEVoltarAoMenu();
        }

        private void BuscarLivroPorTitulo()
        {
            Console.Clear();
            string titulo = _view.SolicitarTexto("Digite o título (ou parte dele): ");
            var livros = _repositorio.BuscarLivrosPorTitulo(titulo);
            _view.ExibirLivros(livros, "BUSCA POR TÍTULO");
            _view.PausarEVoltarAoMenu();
        }

        private void BuscarLivroPorAutor()
        {
            Console.Clear();
            string autor = _view.SolicitarTexto("Digite o nome do autor (ou parte dele): ");
            var livros = _repositorio.BuscarLivrosPorAutor(autor);
            _view.ExibirLivros(livros, "LIVROS POR AUTOR");
            _view.PausarEVoltarAoMenu();
        }

        private void EmprestarLivro()
        {
            Console.Clear();
            var livrosDisponiveis = _repositorio.ObterLivrosDisponiveis();
            _view.ExibirLivros(livrosDisponiveis, "LIVROS DISPONÍVEIS PARA EMPRÉSTIMO");

            int id = _view.SolicitarNumero("\nDigite o ID do livro que deseja emprestar: ");
            
            if (_repositorio.EmprestarLivro(id))
            {
                _view.ExibirMensagem("Livro emprestado com sucesso!");
            }
            else
            {
                _view.ExibirMensagem("Livro não encontrado ou já está emprestado!");
            }
            
            _view.PausarEVoltarAoMenu();
        }

        private void DevolverLivro()
        {
            Console.Clear();
            var livrosEmprestados = _repositorio.ObterTodosOsLivros().Where(l => !l.Disponivel).ToList();
            _view.ExibirLivros(livrosEmprestados, "LIVROS EMPRESTADOS");

            int id = _view.SolicitarNumero("\nDigite o ID do livro que deseja devolver: ");
            
            if (_repositorio.DevolverLivro(id))
            {
                _view.ExibirMensagem("Livro devolvido com sucesso!");
            }
            else
            {
                _view.ExibirMensagem("Livro não encontrado ou não está emprestado!");
            }
            
            _view.PausarEVoltarAoMenu();
        }

        private void CadastrarNovoLivro()
        {
            var novoLivro = _view.SolicitarDadosNovoLivro();
            _repositorio.AdicionarLivro(novoLivro);
            _view.ExibirMensagem("Livro cadastrado com sucesso!");
            _view.PausarEVoltarAoMenu();
        }
    }
}
