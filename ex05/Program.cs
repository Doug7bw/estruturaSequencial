using System;
using System.Globalization;

namespace ex05;
class Program
{
    static void Main(string[] args)
    {
        int codigo1, codigo2, quantidade1, quantidade2;
        double valorUnidade1, valorUnidade2, valorTotal1, valorTotal2, somaTotal;

        Console.WriteLine("Digite o código, quantidade de peças e valor únitário de cada peça do primeiro produto(Separe por espaço):");
        string[] produto1 = Console.ReadLine().Split(' ');

        codigo1 = int.Parse(produto1[0]);
        quantidade1 = int.Parse(produto1[1]);
        valorUnidade1 = double.Parse(produto1[2], CultureInfo.InvariantCulture);
        valorTotal1 = valorUnidade1 * quantidade1;

        Console.WriteLine("Digite o código, quantidade de peças e valor únitário de cada peça do segundo produto(Separe por espaço):");;
        string[] produto2 = Console.ReadLine().Split(' ');

        codigo2 = int.Parse(produto2[0]);
        quantidade2 = int.Parse(produto2[1]);
        valorUnidade2 = double.Parse(produto2[2], CultureInfo.InvariantCulture);
        valorTotal2 = valorUnidade2 * quantidade2;

        somaTotal = valorTotal1 + valorTotal2;

        Console.WriteLine($"Valor total a pagar em {quantidade1} unidades do produto {codigo1} e {quantidade2} unidades do produto {codigo2}:");
        Console.WriteLine($"R$ {somaTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
