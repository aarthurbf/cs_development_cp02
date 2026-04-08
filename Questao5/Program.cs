using System;

namespace Questao5
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Titulo} - {Autor} ({AnoPublicacao})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Gerenciamento de Livros ===\n");

            Livro livro1 = new Livro(
                "1984",
                "George Orwell",
                1949
            );

            Livro livro2 = new Livro(
                "Dom Casmurro",
                "Machado de Assis",
                1899
            );

            Livro livro3 = new Livro(
                "O Senhor dos Anéis",
                "J.R.R. Tolkien",
                1954
            );

            Livro livro4 = new Livro(
                "Harry Potter e a Pedra Filosofal",
                "J.K. Rowling",
                1997
            );

            Console.WriteLine("Livros cadastrados:\n");
            
            livro1.ExibirInformacoes();
            livro2.ExibirInformacoes();
            livro3.ExibirInformacoes();
            livro4.ExibirInformacoes();

            Console.WriteLine("\n=== Acesso às Propriedades ===\n");

            Console.WriteLine($"Título do primeiro livro: {livro1.Titulo}");
            Console.WriteLine($"Autor do segundo livro: {livro2.Autor}");
            Console.WriteLine($"Ano de publicação do terceiro livro: {livro3.AnoPublicacao}");

            Console.WriteLine("\nModificando o ano de publicação do livro 4...");
            livro4.AnoPublicacao = 1998; 
            Console.Write("Informação atualizada: ");
            livro4.ExibirInformacoes();

            Console.WriteLine("\n=== Criando mais livros ===\n");

            Livro livro5 = new Livro("Clean Code", "Robert C. Martin", 2008);
            Livro livro6 = new Livro("O Hobbit", "J.R.R. Tolkien", 1937);

            livro5.ExibirInformacoes();
            livro6.ExibirInformacoes();

            Console.WriteLine("\n=== Fim do Programa ===");
        }
    }
}