using System;

namespace BancoDosProgramadores
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = null;
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("\n--- Banco dos Programadores ---");
                Console.WriteLine("1 - Criar nova conta");
                Console.WriteLine("2 - Depositar");
                Console.WriteLine("3 - Sacar");
                Console.WriteLine("4 - Mostrar dados da conta");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o nome completo: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite o número da conta: ");
                        int numeroConta = int.Parse(Console.ReadLine());

                        Console.Write("Digite o valor inicial: ");
                        double valorInicial = double.Parse(Console.ReadLine());

                        conta = new ContaBancaria(nome, numeroConta, valorInicial);
                        Console.WriteLine("Conta criada com sucesso!");
                        break;

                    case "2":
                        if (conta == null)
                        {
                            Console.WriteLine("Nenhuma conta criada.");
                            break;
                        }
                        Console.Write("Valor do depósito: ");
                        double deposito = double.Parse(Console.ReadLine());
                        conta.Depositar(deposito);
                        break;

                    case "3":
                        if (conta == null)
                        {
                            Console.WriteLine("Nenhuma conta criada.");
                            break;
                        }
                        Console.Write("Valor do saque: ");
                        double saque = double.Parse(Console.ReadLine());
                        conta.Sacar(saque);
                        break;

                    case "4":
                        if (conta == null)
                        {
                            Console.WriteLine("Nenhuma conta criada.");
                            break;
                        }
                        conta.MostrarDados();
                        break;

                    case "5":
                        sair = true;
                        Console.WriteLine("Saindo do sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
