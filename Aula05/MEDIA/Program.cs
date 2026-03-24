using System;

class Program
{
    static void Main()
    {
    
    Console.WriteLine("Digite os numeros separados por virgula:");
    string input = Console.ReadLine();
    int[]   numeros = Array.ConvertAll(input.Split(','), int.Parse);

    var par = numeros.Where(x => x % 2 == 0);
    if (par.Any())
        {
            double mediaPar = par.Average();
            Console.WriteLine($"A média dos números pares é: {mediaPar}");
        }
        else
        {
            Console.WriteLine("Não há números pares na lista.");
        }

     
        
    }
}
