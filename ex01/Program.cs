using System;

namespace ex01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine("Vamos fazer a soma de dois número.");

            Console.WriteLine("Digite o primeiro número:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine($"Soma = {soma}");
        }
    }
}