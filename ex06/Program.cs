using System;
using System.Globalization;

namespace ex06;
class Program
{
    static void Main(string[] args)
    {
        float a, b, c, pi = 3.14159f, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;

        Console.WriteLine("Digite o valor de A, B e C consecutivamente (separe os valores com espaço):");
        string[] valores = Console.ReadLine().Split();

        a = float.Parse(valores[0], CultureInfo.InvariantCulture);
        b = float.Parse(valores[1], CultureInfo.InvariantCulture);
        c = float.Parse(valores[2], CultureInfo.InvariantCulture);

        areaTriangulo = (a * c) / 2;
        areaCirculo = pi * (c * c);
        areaTrapezio = ((a + b) * c) / 2;
        areaQuadrado = b * b;
        areaRetangulo = a * b;

        Console.WriteLine($"Triângulo: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Círculo: {areaCirculo.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Trapézio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Quadrado: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Retângulo: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}
