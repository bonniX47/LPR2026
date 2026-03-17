using System;
namespace RaiodoCirculo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o valor do raio do seu circulo: ");
            if (double.TryParse(Console.ReadLine(), out double raio))

            {
                if (raio < 0)
                {
                    Console.WriteLine("O raio de seu circulo é negativo, isso está incorreto!!!");
                }
                else if (raio > 0)
                {
                    double area = Math.PI * Math.Pow(raio, 2);
                    Console.WriteLine($"A area de seu circulo é de {area}");
                }

                else
                {
                    Console.WriteLine("Este caracter é invalido");
                }
            }
            }
        }
    }
    
