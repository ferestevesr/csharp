using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio1Repeticao {
        public static void Executar() {
            Console.WriteLine("==== Contagem de Gols ====");
            Console.WriteLine("Digite a quantidade de jogos: ");
            int quantidadeJogos = int.Parse(Console.ReadLine());

            double tgols = 0;

            for (int i = 0; i < quantidadeJogos; i++) {
                Console.WriteLine("Digite a quantidade de gols do jogo " + (i + 1) + ": ");
                double gols = double.Parse(Console.ReadLine());

              tgols += gols;
            }
            Console.WriteLine($"A quantidade total de gols é: {tgols}");
            Console.WriteLine("Contagem de gols concluída.");

        }
    }
}
