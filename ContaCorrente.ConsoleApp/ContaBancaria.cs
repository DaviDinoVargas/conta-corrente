using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    
    public class ContaBancaria
    {
        public int Numero { get; set; }
        public decimal Saldo { get; private set; }
        public decimal Limite { get; set; }
        private string[] Movimentacoes = new string[100];
        private int IndexMovimentacoes = 0;

        public ContaBancaria(int numero, decimal saldoInicial, decimal limite)
        {
            Numero = numero;
            Saldo = saldoInicial;
            Limite = limite;
        
        }



    }
}
