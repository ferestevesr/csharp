using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio4Repeticao {
        public static void Executar() {

            int jogador = 5;
            string nomeArtilheiro = "";
            int maiorGols = 0;

            for (int i = 1; i <= jogador; i++) {
                Console.WriteLine($"Digite o nome do jogador {i}: ");
                string nomeJogador = Console.ReadLine();
                Console.WriteLine($"Digite a quantidade de gols do jogador {nomeJogador}: ");
                int gols = int.Parse(Console.ReadLine());
                Console.WriteLine($"O jogador {nomeJogador} marcou {gols} gols.");

                if (gols > maiorGols) {
                    maiorGols = gols;
                    nomeArtilheiro = nomeJogador;

                }
            }
            Console.WriteLine($"Artilheiro: {nomeArtilheiro} Gols: {maiorGols}");

        }
    }
}
