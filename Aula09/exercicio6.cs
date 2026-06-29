using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> pessoas = new Dictionary<string, int>();

        Console.Write("Quantidade de pessoas: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            pessoas[nome] = idade;
        }

        double media = pessoas.Values.Average();

        Console.WriteLine("\nPessoas com idade acima da média:");
        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > media)
                Console.WriteLine(pessoa.Key + " - " + pessoa.Value);
        }

        string maisVelha = pessoas.First().Key;
        string maisNova = pessoas.First().Key;

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value > pessoas[maisVelha])
                maisVelha = pessoa.Key;

            if (pessoa.Value < pessoas[maisNova])
                maisNova = pessoa.Key;
        }

        Console.WriteLine("\nPessoa mais velha: " + maisVelha);
        Console.WriteLine("Pessoa mais nova: " + maisNova);

        Console.Write("\nDigite a idade que deseja remover: ");
        int y = int.Parse(Console.ReadLine());

        List<string> remover = new List<string>();

        foreach (var pessoa in pessoas)
        {
            if (pessoa.Value == y)
                remover.Add(pessoa.Key);
        }

        foreach (string nome in remover)
            pessoas.Remove(nome);

        Console.WriteLine("\nDicionário atualizado:");
        foreach (var pessoa in pessoas)
            Console.WriteLine(pessoa.Key + " - " + pessoa.Value);
    }
}