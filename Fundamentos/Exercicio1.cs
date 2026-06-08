using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Exercicio1 {
        public static void Executar() {
            Console.WriteLine("Nome do jogador: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Idade do Jogador: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Número da camisa do jogador: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário do jogador: ");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos gols o jogador fez na última temporada? ");
            int gols = int.Parse(Console.ReadLine());

            Console.WriteLine("Nascimento do jogador: ");
            string nascimento = Console.ReadLine();

            const int Convocados = 26;

            Console.WriteLine("O jogador {0} tem {1} anos, é o número {2} do time, tem um salário de R${3}, fez {4} gols na última temporada e nasceu em {5}. O time tem {6} jogadores convocados.", nome, idade, numero, salario, gols, nascimento, Convocados);

        }
    }
}
