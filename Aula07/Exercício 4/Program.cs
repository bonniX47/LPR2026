using System;

class Exercício4
{
    static string ClassificarAluno(int nota)
    {
        if (nota < 60) return "Reprovado";
        if (nota <= 79) return "Recuperação";
        return "Aprovado";
    }

    static void Main()
    {
        string[] nomes = new string[10];
        int[] notas = new int[10];
        int aprovados = 0, recuperacao = 0, reprovados = 0;
        double somaNotas = 0;

        for (int i = 0; i < 10; i++)
        {
            nomes[i] = Console.ReadLine();
            notas[i] = int.Parse(Console.ReadLine());
            somaNotas += notas[i];

            string situacao = ClassificarAluno(notas[i]);
            if (situacao == "Aprovado") aprovados++;
            else if (situacao == "Recuperação") recuperacao++;
            else reprovados++;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{nomes[i]} - {notas[i]} - {ClassificarAluno(notas[i])}");
        }

        Console.WriteLine("Aprovados: " + aprovados);
        Console.WriteLine("Recuperação: " + recuperacao);
        Console.WriteLine("Reprovados: " + reprovados);
        Console.WriteLine("Média da turma: " + (somaNotas / 10).ToString("F1"));
    }
} 