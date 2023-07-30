using System;

namespace FluxoPrincipal
{
    class Program
    {
        public static void Main(string[] args)
        {   
            int i = 0;
            var alunoOBJ = new Aluno();
            string? nome = null;
            string? sobrenome = null;
            while (i == 0)
            {
                Console.WriteLine("Adicione um aluno");
                Console.WriteLine("-------------------------------------");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                sobrenome = Console.ReadLine();
                if (nome == "" || sobrenome == "")
                {
                    Console.WriteLine(alunoOBJ);
                }
                else
                {
                    alunoOBJ.Nome = nome;
                    alunoOBJ.Sobrenome = sobrenome;
                    Console.WriteLine(alunoOBJ);
                    i++;
                } 
            }

            i--;

            while (i == 0)
            {
                Console.WriteLine("\nAltere o aluno\n");
                Console.WriteLine("-------------------------------------");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                sobrenome = Console.ReadLine();
                if (nome == "" || sobrenome == "")
                {
                    Console.WriteLine(alunoOBJ);
                }
                else
                {
                    alunoOBJ.Nome = nome;
                    alunoOBJ.Sobrenome = sobrenome;
                    Console.WriteLine(alunoOBJ);
                    i++;
                }
            }
        }
    }
}