using System;

class Program
{
    static void Main()
    {
        int inter = 0;
        int i;
        Console.WriteLine("Digite os números separados por vírgula:");
        string input = Console.ReadLine();
        int[] numeros = Array.ConvertAll(input.Split(','), int.Parse);

        double soma = 0;
        int qtdPares = 0;

        while (inter < 1)
        {
            for (i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    soma += numeros[i];
                    qtdPares++;
                }
            }

            if (qtdPares > 0)
            {
                double media = soma / qtdPares;
                Console.WriteLine("A média dos números pares é: " + media);
            }
            else
            {
                Console.WriteLine("Nenhum número par foi digitado.");
            }

            inter++;
        }
    }
} 