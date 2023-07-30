using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva o valor de A, B e C:");
        string[] valores = Console.ReadLine().Split(' ');
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int c = int.Parse(valores[2]);

        double x1 = (double)(-(b) + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
        double x2 = (double)(-(b) - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);

        Console.WriteLine($"O valor de X1 é: {x1}");
        Console.WriteLine($"O valor de X2 é: {x2}");
    }
}
