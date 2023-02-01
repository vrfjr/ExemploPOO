using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Ola sou o {Nome}, tenho {Idade} anos e sou um professor com salario de {Salario}");
        }
    }
}