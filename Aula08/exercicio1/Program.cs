using System;

namespace Exercicio1
{
    readonly struct Film
    {
        public string Titulo { get; }
        public string Diretor { get; }
        public int AnoLancamento { get; }
        public int DuracaoMin { get; }

        public Film(string titulo, string diretor, int anoLancamento, int duracaoMin)
        {
            Titulo = titulo;
            Diretor = diretor;
            AnoLancamento = anoLancamento;
            DuracaoMin = duracaoMin;
        }

        public override string ToString()
        {
            return $"{Titulo} {Diretor}, {AnoLancamento}, {DuracaoMin} min";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Film[] filmes = new Film[3];

            for (int i = 0; i < 3; i++)
            {
            Console.WriteLine("Digite o título do filme:");
            string? titulo = Console.ReadLine() ?? string.Empty; 

            Console.WriteLine("Digite o nome do diretor:");
            string? diretor = Console.ReadLine() ?? string.Empty; 

            Console.WriteLine("Digite o ano de lançamento:");
            string? anoInput = Console.ReadLine();
            int anoLancamento = int.Parse(anoInput ?? "0");

            Console.WriteLine("Digite a duração do filme em minutos:");
            string? duracaoInput = Console.ReadLine();
            int duracaoMin = int.Parse(duracaoInput ?? "0");
        
            filmes[i] = new Film(titulo, diretor, anoLancamento, duracaoMin);
            
        }
        Array.Sort(filmes, (f1, f2) => f1.AnoLancamento.CompareTo(f2.AnoLancamento));
        
            Console.WriteLine("\nFilmes cadastrados em ordem crescente de ano de lançamento:");
            foreach (var filme in filmes)
            {
                Console.WriteLine(filme);
            }
        }
    }
}
