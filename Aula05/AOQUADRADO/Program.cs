using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para descobrir seu quadrado: ");
        int numero = int.Parse(Console.ReadLine());
        int quadrado = numero * numero;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"O quadrado de {i} é {i * i}");
        }
        Console.WriteLine($"O quadrado de {numero} é {quadrado}");
    }
}
