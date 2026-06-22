using System;
public struct Produto {
     public string Nome;
    public int Codigo;
    public int Preço;
    public int Quantidade;
}
class Program {
    static void Main(string[] args) {
        Produto[] produtos = new Produto[3];
        for (int i = 0; i < 3; i++) {
            Console.WriteLine("Digite o nome do produto:");
            produtos[i].Nome = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Digite o código do produto:");
            string? codigoInput = Console.ReadLine();
            produtos[i].Codigo = int.Parse(codigoInput ?? "0");

            Console.WriteLine("Digite o preço do produto:");
            string? precoInput = Console.ReadLine();
            produtos[i].Preço = int.Parse(precoInput ?? "0");

            Console.WriteLine("Digite a quantidade do produto:");
            string? quantidadeInput = Console.ReadLine();
            produtos[i].Quantidade = int.Parse(quantidadeInput ?? "0");
        }

       Console.WriteLine("\nProdutos cadastrados:");

int valorTotalEstoque = 0;

foreach (var produto in produtos)
{
    Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Preço: {produto.Preço}, Quantidade: {produto.Quantidade}");

    valorTotalEstoque += produto.Preço * produto.Quantidade;
}

Console.WriteLine($"\nValor total em estoque: {valorTotalEstoque}");
        }
    }
