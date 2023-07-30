using System;

namespace Fluxo
{
	class Program
	{
		static void Main(string[] arg)
		{
			Alugueis[] alugueis = new Alugueis[10];
			Console.Write("Digite a quantidade de quartos a serem alugados: ");
			int qtd = int.Parse(Console.ReadLine());
			for (int i = 0; i < qtd; i++)
			{
                Console.Write("Nome: ");
				string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quart = int.Parse(Console.ReadLine());
				alugueis[quart] = new Alugueis();
				alugueis[quart].Nome = nome;
				alugueis[quart].Email = email;
				alugueis[quart].Quart = quart;
			}

			Console.WriteLine("Todos os quartos: ");
			for (int i = 0; i < 10; i++)
			{
				if (alugueis[i] != null)
				{
					Console.WriteLine(alugueis[i]);
				}
			}
		}
	}
}