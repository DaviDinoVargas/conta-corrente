using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria(12, 1000, 0);
            ContaBancaria conta2 = new ContaBancaria(13, 300, 0);

            while (true)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Saque");
                Console.WriteLine("2 - Depósito");
                Console.WriteLine("3 - Consulta de Saldo");
                Console.WriteLine("4 - Emissão de Extrato");
                Console.WriteLine("5 - Transferência entre Contas");
                Console.WriteLine("0 - Sair");

                string escolha = Console.ReadLine();
                decimal valor;

                switch (escolha)
                {
                    case "1":
                        Console.Write("Informe o valor do saque: ");
                        valor = Convert.ToDecimal(Console.ReadLine());
                        conta1.Sacar(valor);
                        break;
                    case "2":
                        Console.Write("Informe o valor do depósito: ");
                        valor = Convert.ToDecimal(Console.ReadLine());
                        conta1.Depositar(valor);
                        break;
                    case "3":
                        Console.Write("Saldo Atual: ");
                        conta1.ConsultarSaldo();
                        break;
                    case "4":
                        Console.WriteLine("Extrato Bancário: ");
                        conta1.EmitirExtrato();
                        break;
                    case "5":
                        Console.Write("Informe o valor da transferência: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
