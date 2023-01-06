using System;
using System.Globalization;

namespace ex04;
class Program
{
    static void Main(string[] args)
    {
        int number, hour;
        double valor, salary;

        Console.WriteLine("Digite o seu número, a quantidade de horas trabalhadas e o valor que recebe por hora (Separe os item por espaço):");
        string[] date = Console.ReadLine().Split(' ');

        number = int.Parse(date[0]);
        hour = int.Parse(date[1]);
        valor = double.Parse(date[2], CultureInfo.InvariantCulture);
        salary = valor * hour;
        
        Console.WriteLine($"NUMBER = {number}");
        Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
