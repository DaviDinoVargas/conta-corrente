using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{

    public class ContaBancaria
    {
        public int IndexConta { get; set; }
        public decimal Saldo { get; private set; }
        public decimal Limite { get; set; }
        private string[] Movimentacoes = new string[100];
        private int IndexMovimentacoes = 0;

        public ContaBancaria(int numero, decimal saldoInicial, decimal limite)
        {
            IndexConta = numero;
            Saldo = saldoInicial;
            Limite = limite;

        }
        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= (Saldo + Limite))
            {
                Saldo -= valor;
                RegistrarMovimentacao($"Saque: -{valor:C}");
                Console.Clear();
                Console.WriteLine("Saque realizado.\n");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido.\n");
            }
        }
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                RegistrarMovimentacao($"Depósito: +{valor:C}");
                Console.Clear();
                Console.WriteLine("Depósito Realizado com Sucesso\n");
            }
            else
            {
                Console.WriteLine("Inválido");
            }
        }
        public void ConsultarSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Saldo atual: {Saldo:C} | Limite: {Limite:C}\n");
        }

        public void RegistrarMovimentacao(string detalhesConta)
        {
            if (IndexMovimentacoes < Movimentacoes.Length)
            {
                Movimentacoes[IndexMovimentacoes++] = detalhesConta;
            }
        }
        public void EmitirExtrato()
        {
            Console.Clear();
            Console.WriteLine("Extrato da Conta:");
            for (int i = 0; i < IndexMovimentacoes; i++)
            {
                Console.WriteLine(Movimentacoes[i]);
            }
        }
        public void Transferir(ContaBancaria destino, decimal valor)
        {
            if (valor > 0 && valor <= (Saldo + Limite))
            {
                Saldo -= valor;
                destino.Depositar(valor);
                RegistrarMovimentacao($"\nValor enviado: -{valor:C} para conta: {destino.IndexConta}\n");
                Console.WriteLine("Concluído com Sucesso!\n");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente ou Inválido\n");
            }
        }
    }
}