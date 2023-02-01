using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(saldo >= valor)
              {
            saldo -= valor;
                System.Console.WriteLine($"saque de {valor} realizado com sucesso");
         
            }
            else{
                System.Console.WriteLine("Saldo insuficiente");
            }
        }
        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é de {saldo}");
        }
    }
}