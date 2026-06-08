using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Exercicio7 {
        public static void Executar() {
                Console.WriteLine("==== Convocação da Seleção ====");

                Console.Write("Digite a idade do jogador: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de gols: ");
                int gols = int.Parse(Console.ReadLine());

                if (idade >= 18 && idade <= 35) {
                    if (gols >= 20) {
                        Console.WriteLine("Convocado!");
                    } else {
                        Console.WriteLine("Lista de espera.");
                    }
                } else {
                    Console.WriteLine("Não convocado.");
                }
            }
        }
    }


