using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> cidades = new Dictionary<string, int>();

        Console.Write("Quantidade de cidades: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome da cidade: ");
            string nome = Console.ReadLine();

            Console.Write("População: ");
            int populacao = int.Parse(Console.ReadLine());

            cidades[nome] = populacao;
        }

        double media = cidades.Values.Average();

        Console.WriteLine("\nCidades com população acima da média:");
        foreach (var cidade in cidades)
        {
            if (cidade.Value > media)
                Console.WriteLine(cidade.Key + " - " + cidade.Value);
        }

        string maiorCidade = cidades.First().Key;
        string menorCidade = cidades.First().Key;

        foreach (var cidade in cidades)
        {
            if (cidade.Value > cidades[maiorCidade])
                maiorCidade = cidade.Key;

            if (cidade.Value < cidades[menorCidade])
                menorCidade = cidade.Key;
        }

        Console.WriteLine("\nCidade mais populosa: " + maiorCidade);
        Console.WriteLine("Cidade menos populosa: " + menorCidade);

        Console.Write("\nDigite a população que deseja remover: ");
        int y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();

        foreach (var cidade in cidades)
        {
            if (cidade.Value == y)
                remover.Add(cidade.Key);
        }

        foreach (string nome in remover)
            cidades.Remove(nome);

        Console.WriteLine("\nDicionário atualizado:");
        foreach (var cidade in cidades)
            Console.WriteLine(cidade.Key + " - " + cidade.Value);
    }
}