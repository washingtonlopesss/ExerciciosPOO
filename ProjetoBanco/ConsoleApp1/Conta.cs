using System;

namespace MinhaConta
{
    internal class Conta
    {
        private string _numeroConta;
        private string _titular;
        private double _saldo;

        public Conta()
        {
        }

        public Conta(string numeroConta, string titular, double saldo) : this(numeroConta, titular)
        {
            _saldo = saldo;
        }

        public Conta(string? numeroConta, string? titular)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            _saldo = 0;
        }

        public double Depositar(double saldo)
        {
            return _saldo += saldo;
        }

        public double Saque(double saque)
        {
            return _saldo = _saldo - saque - 5;
        }
             
        public override string ToString()
        {
            return "Conta: " + _numeroConta + ", Titular: " + _titular + ", Saldo: $ " + _saldo.ToString("F2");
        }
    }
}