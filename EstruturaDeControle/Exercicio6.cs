using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
	internal class Exercicio6 {
		public static void Executar() {

			Console.WriteLine("Quantas camisetas você deseja comprar? ");
			int quantidade = int.Parse(Console.ReadLine());
			double soma = 0;
            double sdesc = 0;

            if (quantidade <= 2) {
				soma = quantidade * 199;

                Console.WriteLine($"Valor total: R${soma} ");
				Console.WriteLine("Desconto: 0%");
				Console.WriteLine($"Valor final: R${soma} ");
            }
			else if (quantidade <= 5 && quantidade >= 3) {
                sdesc = quantidade * 199;
                soma = (quantidade * 199) * 0.05;
                Console.WriteLine($"Valor total: R${sdesc} ");
                Console.WriteLine("Desconto: 5%");
                Console.WriteLine($"Valor final: R${soma} ");
            }
			else if (quantidade > 5) {
                sdesc = quantidade * 199;
                soma = (quantidade * 199) * 0.10;
                Console.WriteLine($"Valor total: R${sdesc} ");
                Console.WriteLine("Desconto: 0%");
                Console.WriteLine($"Valor final: R${soma} ");
            } 
			else {
                Console.WriteLine("Quantidade inválida. Por favor, insira um valor positivo.");
            }
        }
	}
}