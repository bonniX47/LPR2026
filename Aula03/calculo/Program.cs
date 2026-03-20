using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        int C = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de D: ");
        int D = int.Parse(Console.ReadLine());

        int diferenca = (A * B) - (C * D);

        Console.WriteLine("A diferença é de: " + diferenca);
    }
}