using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma classe:");
        Console.WriteLine("1 - Guerreira");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Arqueira");
        Console.Write("Opção: ");

        int escolha = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Classe escolhida: Guerreira");
                Console.WriteLine("Habilidades: Ataque Pesado, Defesa Total");
                break;

            case 2:
                Console.WriteLine("Classe escolhida: Mago");
                Console.WriteLine("Habilidades: Bola de Fogo, Escudo de Gelo");
                break;

            case 3:
                Console.WriteLine("Classe escolhida: Arqueira");
                Console.WriteLine("Habilidades: Flecha Precisa, Disparo Triplo");
                break;

            default:
                Console.WriteLine("Opção inválida! Escolha 1, 2 ou 3.");
                break;
        }
    }
}