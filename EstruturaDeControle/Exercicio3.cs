using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio3 {

        public static void Executar() {

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de ingressos: ");
            double quantidade = int.Parse(Console.ReadLine());

            double PrecoIngressos = 120;

            if (quantidade > 5) {
                double desconto = (PrecoIngressos * quantidade) * 0.10;
                Console.WriteLine($"O valor foi de R${PrecoIngressos * quantidade}");
                Console.WriteLine($"O valor do desconto é: R${desconto}");
                Console.WriteLine($"O valor total com desconto é: R${(PrecoIngressos * quantidade) - desconto}");
            }

            else {
                Console.WriteLine($"O valor total é: R${PrecoIngressos * quantidade}");
            }
        }
    }
}
