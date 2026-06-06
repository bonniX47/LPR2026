using System;
using System.Collections.Generic;

class Exercício2
{
    static void Main()
    {
        int[] vetor = new int[10];
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
            if (vetor[i] % 2 == 0)
            {
                pares.Add(vetor[i]);
            }
            else
            {
                impares.Add(vetor[i]);
            }
        }

        Console.Write("PAR:");
        foreach (int p in pares)
        {
            Console.Write(" " + p);
        }
        Console.WriteLine();

        Console.Write("ÍMPAR:");
        foreach (int imp in impares)
        {
            Console.Write(" " + imp);
        }
        Console.WriteLine();
    }
}