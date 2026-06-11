using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio3Repeticao {
        public static void Executar() {

            int qtndPartida = 5;
            int totalGols = 0;

            for (int partida = 1; partida <= qtndPartida; partida++) {

                Console.WriteLine($"Digite a quantidade de gols da partida {partida}: ");
                int gols = int.Parse(Console.ReadLine());

                totalGols += gols;
            }

            double media = (double)totalGols / qtndPartida;

            Console.WriteLine($"A média de gols por partida é: {media:F2}");
        }
    }
}