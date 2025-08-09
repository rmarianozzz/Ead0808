using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Aqui temos a class ContaBancaria,separei em 3 funções depositar onde vão botar dinheiro tendo a ideia q o deposito tem q ser maior que $1 usando o if q tem q ser maior q 1 e uso atribuição += soma
//no sacar uso if para impor um limite q só pode sacar se tiver saldo q seja maior q 0 e uso o -= para tirar tirar dinheiro ,ele subtrai
// e por fim o void mostrar dados,faço ali para mostrar o texto/informações final q mostrará pro cliente do banco e no final só pra chamar na program e rodar no while

//fiz desse jeito pq é o jeito q vejo mais facil de entendimento e é o jeito q foi me ensinado a ordem dos metodos para mlr organização
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


