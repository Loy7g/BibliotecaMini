using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMini.Models;

namespace BibliotecaMini.Data
{
    public class LivroRepositorio
    {
        private readonly List<Livro> _livros = new List<Livro>();

        public LivroRepositorio()
        {
            // Carrega os livros iniciais do array
            _livros.AddRange(Livro.ObterLivrosIniciais());
        }

        public List<Livro> ObterTodosOsLivros()
        {
            return _livros;
        }

        public Livro BuscarLivroPorId(int id)
        {
            return _livros.FirstOrDefault(l => l.Id == id);
        }

        public List<Livro> BuscarLivrosPorTitulo(string titulo)
        {
            return _livros.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Livro> BuscarLivrosPorAutor(string autor)
        {
            return _livros.Where(l => l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Livro> ObterLivrosDisponiveis()
        {
            return _livros.Where(l => l.Disponivel).ToList();
        }

        public void AdicionarLivro(Livro livro)
        {
            _livros.Add(livro);
        }

        public bool EmprestarLivro(int id)
        {
            var livro = BuscarLivroPorId(id);
            if (livro != null && livro.Disponivel)
            {
                livro.Disponivel = false;
                return true;
            }
            return false;
        }

        public bool DevolverLivro(int id)
        {
            var livro = BuscarLivroPorId(id);
            if (livro != null && !livro.Disponivel)
            {
                livro.Disponivel = true;
                return true;
            }
            return false;
        }
    }
}
