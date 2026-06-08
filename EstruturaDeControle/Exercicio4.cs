using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio4 {

        public static void Executar() {
            Console.WriteLine("Nome da seleção: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Pontos feitos: ");
            int pontos = int.Parse(Console.ReadLine());
            if (pontos < 4 && pontos >= 0) {
                Console.WriteLine($"{nome} ELIMINADO(A).");
            } else if (pontos > 3 && pontos < 7) {
                Console.WriteLine($"Verificar saldo de gols.");
                Console.WriteLine("Saldo de gols: ");
                int saldoGols = int.Parse(Console.ReadLine());
                if (saldoGols > 3) {
                    Console.WriteLine($"{nome} CLASSIFICADO(A).");
                } else {
                    Console.WriteLine($"{nome} REPESCAGEM.");
                }

            } else if (pontos >= 7 && pontos < 10) {
                Console.WriteLine($"{nome} CLASSIFICADO(A).");


            } else {
                Console.WriteLine("Pontos inválidos. Por favor, insira um valor entre 0 e 9.");
            }
        }
    }
}
