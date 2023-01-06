using System;
using System.Globalization;

namespace ex02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            Console.WriteLine("Digite o raio do círculo:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine($"A área desse círculo é = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}