using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMini.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int AnoPublicacao { get; set; }
        public bool Disponivel { get; set; }
        public string ISBN { get; set; }
        public int NumeroPaginas { get; set; }

        public Livro(int id, string titulo, string autor, string genero, int anoPublicacao, bool disponivel = true, string isbn = "", int numeroPaginas = 0)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            AnoPublicacao = anoPublicacao;
            Disponivel = disponivel;
            ISBN = isbn;
            NumeroPaginas = numeroPaginas;
        }

        public override string ToString()
        {
            return $"[{Id}] {Titulo} - {Autor} ({AnoPublicacao}) - {Genero} - {(Disponivel ? "Disponível" : "Emprestado")}";
        }

        // Array de dados para preencher a biblioteca
        public static Livro[] ObterLivrosIniciais()
        {
            return new Livro[]
            {
                new Livro(1, "1984", "George Orwell", "Ficção Científica", 1949, true, "978-0-452-28423-4", 328),
                new Livro(2, "Dom Casmurro", "Machado de Assis", "Romance", 1899, true, "978-85-359-0277-5", 256),
                new Livro(3, "O Senhor dos Anéis: A Sociedade do Anel", "J.R.R. Tolkien", "Fantasia", 1954, true, "978-0-547-92822-7", 423),
                new Livro(4, "Harry Potter e a Pedra Filosofal", "J.K. Rowling", "Fantasia", 1997, false, "978-0-439-70818-8", 309),
                new Livro(5, "O Código Da Vinci", "Dan Brown", "Suspense", 2003, true, "978-0-307-47427-5", 454),
                new Livro(6, "Cem Anos de Solidão", "Gabriel García Márquez", "Realismo Mágico", 1967, true, "978-0-06-088328-7", 417),
                new Livro(7, "O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Infantil", 1943, false, "978-0-156-01219-2", 96),
                new Livro(8, "Orgulho e Preconceito", "Jane Austen", "Romance", 1813, true, "978-0-14-143951-8", 432),
                new Livro(9, "O Hobbit", "J.R.R. Tolkien", "Fantasia", 1937, true, "978-0-547-92822-7", 304),
                new Livro(10, "Fahrenheit 451", "Ray Bradbury", "Ficção Científica", 1953, true, "978-1-451-67331-9", 194),
                new Livro(11, "A Revolução dos Bichos", "George Orwell", "Fábula", 1945, false, "978-0-452-28424-1", 112),
                new Livro(12, "O Cortiço", "Aluísio Azevedo", "Naturalismo", 1890, true, "978-85-359-0123-5", 264),
                new Livro(13, "Capitães da Areia", "Jorge Amado", "Romance", 1937, true, "978-85-359-0098-6", 280),
                new Livro(14, "O Alquimista", "Paulo Coelho", "Ficção", 1988, true, "978-0-06-112241-5", 163),
                new Livro(15, "Memórias Póstumas de Brás Cubas", "Machado de Assis", "Realismo", 1881, true, "978-85-359-0278-2", 208),
                new Livro(16, "O Nome da Rosa", "Umberto Eco", "Mistério", 1980, false, "978-0-15-644756-9", 536),
                new Livro(17, "Cem Anos de Solidão", "Gabriel García Márquez", "Realismo Mágico", 1967, true, "978-0-06-088328-7", 417),
                new Livro(18, "Crime e Castigo", "Fiódor Dostoiévski", "Romance", 1866, true, "978-0-14-044913-6", 671),
                new Livro(19, "O Guarani", "José de Alencar", "Romance", 1857, true, "978-85-359-0145-7", 312),
                new Livro(20, "Iracema", "José de Alencar", "Romance", 1865, true, "978-85-359-0146-4", 144),
                new Livro(21, "Senhora", "José de Alencar", "Romance", 1875, false, "978-85-359-0147-1", 208),
                new Livro(22, "O Ateneu", "Raul Pompéia", "Romance", 1888, true, "978-85-359-0148-8", 184),
                new Livro(23, "Quincas Borba", "Machado de Assis", "Realismo", 1891, true, "978-85-359-0279-9", 256),
                new Livro(24, "Lucíola", "José de Alencar", "Romance", 1862, true, "978-85-359-0149-5", 192),
                new Livro(25, "Drácula", "Bram Stoker", "Terror", 1897, true, "978-0-14-143984-6", 418),
                new Livro(26, "Frankenstein", "Mary Shelley", "Terror", 1818, true, "978-0-14-143947-1", 280),
                new Livro(27, "O Retrato de Dorian Gray", "Oscar Wilde", "Ficção", 1890, false, "978-0-14-143957-0", 254),
                new Livro(28, "Alice no País das Maravilhas", "Lewis Carroll", "Infantil", 1865, true, "978-0-14-143761-3", 192),
                new Livro(29, "As Aventuras de Sherlock Holmes", "Arthur Conan Doyle", "Mistério", 1892, true, "978-0-14-143682-1", 307),
                new Livro(30, "Moby Dick", "Herman Melville", "Aventura", 1851, true, "978-0-14-243724-7", 635)
            };
        }
    }
}
