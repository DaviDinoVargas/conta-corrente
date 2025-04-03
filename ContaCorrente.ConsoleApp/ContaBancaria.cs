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
            if (valor > 0 && (Saldo + Limite) >= valor)
            {
                Saldo -= valor;
                if (Saldo < 0)
                {
                    Limite += Saldo;
                    if (Limite < 0) Limite = 0;
                }
                RegistrarMovimentacao($"Saque: -{valor:C}");
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Operação não permitida: saldo insuficiente considerando o limite.");
            }
        }
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                if (Saldo < 0)
                {
                    decimal valorRestaurado = Math.Min(-Saldo, valor);
                    Limite += valorRestaurado;
                    Saldo += valorRestaurado;
                    valor -= valorRestaurado;
                }
                Saldo += valor;
                RegistrarMovimentacao($"Depósito: +{valor:C}");
                Console.WriteLine("Depósito realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
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
            Console.WriteLine("_____________________________");
            Console.WriteLine($"Extrato da Conta {IndexConta}");
            Console.WriteLine($"Saldo Atual: {Saldo:C}");
            Console.WriteLine("_____________________________");

            for (int i = 0; i < IndexMovimentacoes; i++)
            {
                Console.WriteLine(Movimentacoes[i]+"\n");
            }
        }
        public void Transferir(ContaBancaria destino, decimal valor)
        {
            if (valor > 0 && valor <= (Saldo + Limite))
            {
                Saldo -= valor;
                destino.Depositar(valor);
                RegistrarMovimentacao($"Valor enviado: -{valor:C} para conta: {destino.IndexConta}\n");
                Console.WriteLine("Concluído com Sucesso!\n");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente ou Inválido\n");
            }
        }
    }
}