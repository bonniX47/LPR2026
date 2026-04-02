using System;

class Program
{
    static string herois = "";
    static string e1="", e2="", e3="";
    static int e1Pt=0, e2Pt=0, e3Pt=0;

    static void Main() { menu(); }

    static void cadastrar()
    {
        int quantidade = herois == "" ? 0 : herois.Split(';').Length;
        if (quantidade >= 5)
        {
            Console.WriteLine("Limite de 5 heróis atingido");
            return;
        }

        Console.Write("Nome: ");
        string n = Console.ReadLine();
        Console.Write("Poder: ");
        string p = Console.ReadLine();
        Console.Write("Pontuação: ");
        int pt = int.Parse(Console.ReadLine());

        string novo = n + "|" + p + "|" + pt;

        if (herois == "") herois = novo;
        else herois += ";" + novo;

        Console.WriteLine("Herói cadastrado");
    }

    static void selecionar()
    {
        Console.WriteLine("Seleção da Equipe");
        mostrarHerois();

        Console.Write("Herói 1: ");
        pegar(int.Parse(Console.ReadLine()), 1);
        Console.Write("Herói 2: ");
        pegar(int.Parse(Console.ReadLine()), 2);
        Console.Write("Herói 3: ");
        pegar(int.Parse(Console.ReadLine()), 3);

        Console.WriteLine("Equipe selecionada");
    }

    static void pegar(int pos, int destino)
    {
        string[] lista = herois.Split(';');
        if (pos < 1 || pos > lista.Length) return;

        string[] dados = lista[pos-1].Split('|');
        string nome = dados[0];
        int pontos = int.Parse(dados[2]);

        if (destino == 1){ e1 = nome; e1Pt = pontos; }
        if (destino == 2){ e2 = nome; e2Pt = pontos; }
        if (destino == 3){ e3 = nome; e3Pt = pontos; }
    }

    static int total()
    {
        return e1Pt + e2Pt + e3Pt;
    }

    static void exibirEquipe()
    {
        Console.WriteLine("Equipe:");
        Console.WriteLine("1 - " + e1 + " | " + e1Pt);
        Console.WriteLine("2 - " + e2 + " | " + e2Pt);
        Console.WriteLine("3 - " + e3 + " | " + e3Pt);
        Console.WriteLine("Total: " + total());
    }

    static void mostrarHerois()
    {
        if (herois == "")
        {
            Console.WriteLine("Nenhum herói cadastrado");
            return;
        }

        string[] lista = herois.Split(';');
        int i = 1;

        foreach (string s in lista)
        {
            string[] d = s.Split('|');
            Console.WriteLine(i + " - " + d[0] + " | " + d[1] + " | " + d[2]);
            i++;
        }
    }

    static void menu()
    {
        int op=0;
        while (op != 4)
        {
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            if (op==1) cadastrar();
            if (op==2) selecionar();
            if (op==3) exibirEquipe();
            if (op==4) Console.WriteLine("Saindo...");
        }
    }
}