using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Exercicio1jogador {

        public static void Executar() {
            JogadorOE Neymar = new JogadorOE();
            Neymar.Nome = "Neymar";
            Neymar.Selecao = "Brasil";
            Neymar.NumeroCamisa = "10";
            Neymar.Continente = "América do Sul";
            Neymar.ComidaTipica = "Feijoada";

            JogadorOE Cristiano = new JogadorOE();
            Cristiano.Nome = "Cristiano Ronaldo";
            Cristiano.Selecao = "Portugal";
            Cristiano.NumeroCamisa = "7";
            Cristiano.Continente = "Europa";
            Cristiano.ComidaTipica = "Cacete";



            Neymar.ApresentarNoConsole();
            Cristiano.ApresentarNoConsole();
        }
    }
}
