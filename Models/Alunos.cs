using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Alunos : Pessoa
    {
        public Alunos()
        {
            
        }
        public Alunos(string nome) : base(nome)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Ola sou o {Nome}, tenho {Idade} anos e sou um aluno nota {Nota} ");
        }
    }
}