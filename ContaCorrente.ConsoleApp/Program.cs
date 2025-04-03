using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria(12, 500, 500);
            ContaBancaria conta2 = new ContaBancaria(13, 300, 300);
            ContaBancaria contaAtual = null;

            while (true)
            {
                Console.WriteLine("Escolha uma conta:");
                Console.WriteLine("   1 - Conta 1:   ");
                Console.WriteLine("   2 - Conta 2:   ");
                Console.WriteLine("    0 - Sair      ");
                string escolhaConta = Console.ReadLine();

                if (escolhaConta == "1") contaAtual = conta1;
                else if (escolhaConta == "2") contaAtual = conta2;
                else if (escolhaConta == "0") return;
                else
                {
                    Console.WriteLine("Inválido");
                    continue;
                }
                bool voltarParaContas = false;

                while (!voltarParaContas)
                {
                    Console.WriteLine("Escolha uma operação:");
                    Console.WriteLine("1 - Saque");
                    Console.WriteLine("2 - Depósito");
                    Console.WriteLine("3 - Consulta de Saldo");
                    Console.WriteLine("4 - Emissão de Extrato");
                    Console.WriteLine("5 - Transferência entre Contas");
                    Console.WriteLine("6 - Voltar");
                    Console.WriteLine("0 - Sair");

                    string escolha = Console.ReadLine();
                    decimal valor;

                    switch (escolha)
                    {
                        case "1":
                            Console.Write("Informe o valor do saque: ");
                            valor = Convert.ToDecimal(Console.ReadLine());
                            contaAtual.Sacar(valor);
                            break;
                        case "2":
                            Console.Write("Informe o valor do depósito: ");
                            valor = Convert.ToDecimal(Console.ReadLine());
                            contaAtual.Depositar(valor);
                            break;
                        case "3":
                            Console.Write("Saldo Atual: ");
                            contaAtual.ConsultarSaldo();
                            break;
                        case "4":
                            contaAtual.EmitirExtrato();
                            break;
                        case "5":
                            Console.Write("Informe o valor da transferência: ");
                            valor = Convert.ToDecimal(Console.ReadLine());
                            ContaBancaria destino = contaAtual == conta1 ? conta2 : conta1;
                            contaAtual.Transferir(destino, valor);
                            break;

                        case "6":
                            Console.WriteLine("Voltando à seleção de contas...");
                            voltarParaContas = true;
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
}