using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio2Repeticao {
        public static void Executar() {
            Console.WriteLine("Digite a quantidade de dias que falta para o jogo: ");
            int dias = int.Parse(Console.ReadLine());

            for (int i = 0; i < dias; i++) {
            Console.WriteLine("Faltam {0} dias para o jogo", dias - i);
            }

        }
    }
}
