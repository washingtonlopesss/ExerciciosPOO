using System;

namespace MinhaConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            Console.Write("Entre o número da conta: ");
            string numeroConta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numeroConta, titular, valorDepositoInicial);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Dados da conta:");
                conta = new Conta(numeroConta, titular);
                Console.WriteLine(conta);
            }
            Console.WriteLine("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}