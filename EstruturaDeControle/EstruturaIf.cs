using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            /* Console.WriteLine("Digite a nota do aluno:");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 7) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5) {
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("Reprovado!"); */


            Console.WriteLine("Digite a nota 1 do aluno:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2 do aluno:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3 do aluno:");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            if (media >= 7) {
                Console.WriteLine("Aprovado com média " + media);


            }else if (media >= 5) {
                Console.WriteLine("A média do aluno foi " + media, " Está de recuperação");

            }   else {
                Console.WriteLine("Reprovado com média " + media);
            }
        }
    }
}
