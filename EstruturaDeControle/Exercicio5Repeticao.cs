using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio5Repeticao {
        public static void Executar() {

            int totalTorcedores = 0;

            while (true) {

                Console.WriteLine("Digite o nome do torcedor (ou 'fim' para encerrar): ");
                string nomeTorcedor = Console.ReadLine();

                if (nomeTorcedor.ToLower() == "fim") {
                    break;
                }

                Console.WriteLine("Digite a seleção favorita: ");
                string selecaoFavorita = Console.ReadLine();

                totalTorcedores++;
            }

            Console.WriteLine($"\nTotal de torcedores cadastrados: {totalTorcedores}");
        }
    }
}