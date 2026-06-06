using System;
using System.Collections.Generic;

class Exercício3
{
    static void Main()
    {
        int[] vetor = new int[10];

        for (int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int numeroPesquisa = int.Parse(Console.ReadLine());
        List<int> posicoes = new List<int>();
        int ocorrencias = 0;

        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] == numeroPesquisa)
            {
                posicoes.Add(i);
                ocorrencias++;
            }
        }

        if (ocorrencias > 0)
        {
            Console.Write("Posições onde aparece:");
            foreach (int pos in posicoes)
            {
                Console.Write(" " + pos);
            }
            Console.WriteLine();
            Console.WriteLine("Total de ocorrências: " + ocorrencias);
        }
        else
        {
            Console.WriteLine("O número não existe no vetor.");
        }
    }
}