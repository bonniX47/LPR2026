using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> jogos = new Dictionary<string, string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nome do jogo: ");
            string nome = Console.ReadLine();

            Console.Write("Gênero: ");
            string genero = Console.ReadLine();

            jogos[nome] = genero;
        }

        Console.Write("\nDigite o nome do jogo que deseja buscar: ");
        string busca = Console.ReadLine();

        if (jogos.ContainsKey(busca))
            Console.WriteLine("Gênero: " + jogos[busca]);
        else
            Console.WriteLine("Jogo não cadastrado.");
    }
} 