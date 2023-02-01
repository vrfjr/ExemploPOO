using ExemploPOO.Models;
using System;
using ExemploPOO.interfaces;






using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema.
class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                
                System.Console.WriteLine("divisão impossivel");
            } else {
                Console.WriteLine("{0:0.0}", X / Y);
            }
        }
    }
}   


// using System;

// namespace Start {
//   class Program {
//     static void Main(string[] args) {
//       double A, B, C;
      
//    //preencha a a leitura dos dados aqui
//       A = double.Parse(Console.ReadLine());
//       B = double.Parse(Console.ReadLine());
//       C = double.Parse(Console.ReadLine());
      
//       Console.WriteLine("MEDIA = " + String.Format("{0:0.0}", ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5)));
//       Console.ReadKey();
//     }
//   }
// }



















// using System; 

// class TESTE {

//     static void Main(string[] args)
//     {
//         //TODO: Complete os espaços em branco com uma possível solução para o desafio
//         int n;
//         int maior = 0;
//         int posicao = 0;
//         for (int i = 1; i <= 20; i++)
//         {
//             n = Convert.ToInt32(Console.ReadLine());
//             if (n > maior)
//             {
//                 maior = n;
//                 posicao = i;
//             }
//         }
//         Console.WriteLine($"maior é {maior}");

//         Console.WriteLine($"sua posição é {posicao}");
//     }
// }














// ICalculadora calc = new Calculadora();

// System.Console.WriteLine(calc.Multiplicar(3, 9));
// System.Console.WriteLine(calc.Dividir(3, 9));
// System.Console.WriteLine(calc.Somar(3, 9));
// System.Console.WriteLine(calc.Subtrair(3, 9));










// Computador c = new Computador();
// System.Console.WriteLine(c.ToString());













// Pessoa p1 = new Pessoa("Vagner");
// Alunos a1 = new Alunos("Vagner2");
// p1.Apresentar();
// a1.Apresentar();











// Corrente c1 = new Corrente();

// c1.Creditar(550);
// c1.ExibirSaldo();
















// Alunos a1 = new Alunos();

// a1.Nome = "Wenio";
// a1.Idade = 96;
// a1.Nota = 9;
// a1.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Weniozada";
// p1.Salario = 1500;
// p1.Idade = 98;
// p1.Apresentar();









// ContaCorrente c1 = new ContaCorrente(133, 1000);

// c1.ExibirSaldo();
// c1.Sacar(1500);
// c1.ExibirSaldo();











// Pessoa p1 = new Pessoa();
// p1.Nome = "Wenio";
// p1.Idade = 86;

// p1.Apresentar();