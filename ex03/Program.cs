namespace ex03;
class Program
{
    static void Main(string[] args)
    {
        int a, b, c, d, x;

        Console.WriteLine("Digite o primeiro valor:");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor:");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o quarto valor:");
        d = int.Parse(Console.ReadLine());

        x = (a * b - c * d);

        Console.WriteLine($"Diferença = {x}");
    }
}
