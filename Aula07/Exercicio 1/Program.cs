using System;

class Exercício1
{
    static void Main()
    {
        int[] vetor = new int[5];

        for (int i = 0; i < 5; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int maior = vetor[0];
        int posicao = 0;

        Console.Write("Vetor:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(" " + vetor[i]);
            if (vetor[i] > maior)
            {
                maior = vetor[i];
                posicao = i;
            }
        }
        Console.WriteLine();

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Posição: " + posicao);
    }
} 