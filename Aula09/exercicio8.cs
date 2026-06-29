using System;
using System.Collections.Generic;
using System.Linq;

struct Livro
{
    public string Titulo;
    public string Autor;
    public int AnoPublicacao;
    public int QuantidadeDisponivel;
}

class Program
{
    static Dictionary<int, Livro> biblioteca = new Dictionary<int, Livro>();

    static void CadastrarLivro()
    {
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Livro livro = new Livro();

        Console.Write("Título: ");
        livro.Titulo = Console.ReadLine();

        Console.Write("Autor: ");
        livro.Autor = Console.ReadLine();

        Console.Write("Ano de publicação: ");
        livro.AnoPublicacao = int.Parse(Console.ReadLine());

        Console.Write("Quantidade disponível: ");
        livro.QuantidadeDisponivel = int.Parse(Console.ReadLine());

        biblioteca[codigo] = livro;
    }

    static void BuscarLivro()
    {
        Console.Write("Código do livro: ");
        int codigo = int.Parse(Console.ReadLine());

        if (biblioteca.ContainsKey(codigo))
        {
            Livro livro = biblioteca[codigo];

            Console.WriteLine("Título: " + livro.Titulo);
            Console.WriteLine("Autor: " + livro.Autor);
            Console.WriteLine("Ano: " + livro.AnoPublicacao);
            Console.WriteLine("Quantidade: " + livro.QuantidadeDisponivel);
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void EmprestarLivro()
    {
        Console.Write("Código do livro: ");
        int codigo = int.Parse(Console.ReadLine());

        if (biblioteca.ContainsKey(codigo))
        {
            Livro livro = biblioteca[codigo];

            if (livro.QuantidadeDisponivel > 0)
            {
                livro.QuantidadeDisponivel--;
                biblioteca[codigo] = livro;
                Console.WriteLine("Empréstimo realizado.");
            }
            else
            {
                Console.WriteLine("Não há exemplares disponíveis.");
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void ExibirRelatorio()
    {
        Console.WriteLine("\nTotal de livros: " + biblioteca.Count);

        int codigoMaisAntigo = biblioteca.First().Key;
        int codigoMaiorQuantidade = biblioteca.First().Key;

        foreach (var item in biblioteca)
        {
            if (item.Value.AnoPublicacao < biblioteca[codigoMaisAntigo].AnoPublicacao)
                codigoMaisAntigo = item.Key;

            if (item.Value.QuantidadeDisponivel > biblioteca[codigoMaiorQuantidade].QuantidadeDisponivel)
                codigoMaiorQuantidade = item.Key;
        }

        Console.WriteLine("\nLivro mais antigo:");
        Console.WriteLine(biblioteca[codigoMaisAntigo].Titulo);

        Console.WriteLine("\nLivro com maior quantidade disponível:");
        Console.WriteLine(biblioteca[codigoMaiorQuantidade].Titulo);

        Console.WriteLine("\nQuantidade de livros por autor:");

        Dictionary<string, int> autores = new Dictionary<string, int>();

        foreach (var item in biblioteca)
        {
            if (!autores.ContainsKey(item.Value.Autor))
                autores[item.Value.Autor] = 0;

            autores[item.Value.Autor]++;
        } 

        foreach (var autor in autores)
            Console.WriteLine(autor.Key + ": " + autor.Value);
    }

    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nLivro " + (i + 1));
            CadastrarLivro();
        }

        BuscarLivro();
        EmprestarLivro();
        ExibirRelatorio();
    }
} 