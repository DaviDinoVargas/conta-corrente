﻿using System;
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
        public void Sacar(decimal valor)
        {
            if (valor > 0 && valor <= (Saldo + Limite))
            {
                Saldo -= valor;
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
            if  (valor > 0)
            { 
                Saldo += valor;
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


    } 
} 