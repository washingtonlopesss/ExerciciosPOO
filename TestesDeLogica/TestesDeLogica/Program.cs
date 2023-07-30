using System;
using TestesDeLogica;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1, p2;
        p1 = new Pessoa();
        p2 = new Pessoa();

        Console.WriteLine("Digite os dados da primeira pessoa: ");
        Console.Write("Nome: ");
        p1.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        p1.Salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite os dados da segunda pessoa: ");
        Console.Write("Nome: ");
        p2.Nome = Console.ReadLine();
        Console.Write("Salário: ");
        p2.Salario = double.Parse(Console.ReadLine());

        

    }

}