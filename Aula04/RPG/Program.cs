using System;
     class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao RPG!");
            Console.WriteLine("Escolha seu personagem:");
            Console.WriteLine("1. Guerreiro");
            Console.WriteLine("2. Mago");
            Console.WriteLine("3. Arqueiro");

            int personagem  = int.Parse(Console.ReadLine());
            Personagem personagem;

            switch (personagem)
            {
                case 1:
                    personagem = new Guerreiro();
                    break;
                case 2:
                    personagem = new Mago();
                    break;
                case 3:
                    personagem = new Arqueiro();
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Criando um Guerreiro por padrão.");
                    personagem = new Guerreiro();
                    break;
            }

            Console.WriteLine($"Você escolheu: {personagem.Nome}");
            Console.WriteLine($"Vida: {personagem.Vida}");
            Console.WriteLine($"Ataque: {personagem.Ataque}");
        }
    }