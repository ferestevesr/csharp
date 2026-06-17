using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class JogadorOE {

        public string Nome;
        public string Selecao;
        public string NumeroCamisa;
        public string Continente;
        public string ComidaTipica;


        public string Apresentar() {

            return string.Format($"Olá! sou {Nome}, da seleção {Selecao} e sou o {NumeroCamisa}. {Nome} fica na {Continente} e a comida tipica é {ComidaTipica}");


        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
