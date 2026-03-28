using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número entre 1 e 100:");
        Random random = new Random();
        int numero = random.Next(1, 101);    
        int tentativas = 0;
        bool acertou = false; 
        Console.WriteLine("Tente adivinhar o número secreto!"); 
        while (!acertou)
        {
            Console.Write("Digite seu palpite: ");
            int chute = int.Parse(Console.ReadLine());
            tentativas++;
            if (chute == numero)
            {
                acertou = true;
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
            }
            else if (chute < numero)
                Console.WriteLine("O número secreto é maior. Tente novamente!");
            
        
            else
            {
                Console.WriteLine("O número secreto é menor. Tente novamente!");
            }
        }
    }
} 
