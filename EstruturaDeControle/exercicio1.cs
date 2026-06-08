using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.EstruturaDeControle {
    internal class exercicio1 {

        // Exercício 1 & 2 - Estrutura de Controle
        public static void Executar() {

                Console.WriteLine("==== CONVOCAÇÃO SELEÇÃO ====");
                Console.WriteLine();

                Console.Write("Digite o nome do jogador: ");
                string nome = Console.ReadLine();

                Console.Write($"Digite a idade de {nome}: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18 && idade <= 40) {
                    Console.WriteLine($"\nO jogador {nome} tem a idade ideal para participar da convocação.");
                } else {
                    Console.WriteLine($"\nO jogador {nome} não tem a idade ideal para participar da convocação.");
                    return;
                }

                Console.Write($"\nDigite quantos jogos {nome} fez: ");
                int jogos = int.Parse(Console.ReadLine());

                Console.Write($"Digite quantos gols {nome} fez: ");
                int gols = int.Parse(Console.ReadLine());

                Console.WriteLine("\n===== DADOS DO JOGADOR =====");
                Console.WriteLine($"Jogador: {nome}");
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine($"Jogos: {jogos}");
                Console.WriteLine($"Gols: {gols}");

                Console.WriteLine();

                if (gols <= 4) {
                    Console.WriteLine($"O jogador {nome} não foi classificado.");
                } else if (gols <= 9) {
                    Console.WriteLine($"O jogador {nome} é reserva.");
                } else {
                    Console.WriteLine($"O jogador {nome} é titular!");
                }


                Console.WriteLine("O jogador tem lesão? (S/N)");
                string lesao = Console.ReadLine().ToUpper();

                if (lesao == "S") {
                Console.WriteLine($"O jogador {nome} não foi classificado por ter lesão.");
            } else {
                Console.WriteLine($"O jogador {nome} está apto para jogar!");
            }


        }   
    }
}