using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BancoDosProgramadores
{
    public class ContaBancaria
    {
        public string NomeTitular { get; private set; }
        public int NumeroConta { get; private set; }
        private double saldo;

        public ContaBancaria(string nomeTitular, int numeroConta, double valorInicial)
        {
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
            if (valorInicial >= 0)
                saldo = valorInicial;
            else
                saldo = 0;
        }

        public void Depositar(double valor)
        {
            if (valor >= 1)
            {
                saldo += valor;
                Console.WriteLine("Depósito realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Depósito mínimo é de R$ 1,00.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor inválido para saque.");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("\n=== Dados da Conta ===");
            Console.WriteLine($"Titular: {NomeTitular}");
            Console.WriteLine($"Número da Conta: {NumeroConta}");
            Console.WriteLine($"Saldo: {saldo.ToString("C")}");
            Console.WriteLine("======================\n");
        }
    }
}
