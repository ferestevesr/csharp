using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaDeRepeticao {
        public static void Executar() {
            /*
            int contador = 1;
            while (contador <= 10) {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Contador: {i}");
            }
            Console.WriteLine("Digite a quantidade de torcedores:");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i >= quantidade; i++) {
                Console.WriteLine($"Torcedor {i} entrou no estadio:");
            }

            */
            int contador = 1;
            int tentativas = 3;

            Console.WriteLine("Digite a senha: ");
            string password = Console.ReadLine();

            while (password != "12fefe12" && contador != 3) {
                Console.WriteLine($"Senha incorreta, você tem {tentativas-contador} tentativas, tente novamente: ");


                   password = Console.ReadLine();
                if (password == "12fefe12") {
                    Console.WriteLine("Acesso permitido");
                    break;
                } else {
                    Console.WriteLine("Acesso negado");
                    contador++;
                }

            }

        }
    }
}
