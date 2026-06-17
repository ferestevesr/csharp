using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Membros {


        public static void Executar() {
          Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Neymar";
            pessoa1.Idade = "34";


            Pessoa pessoa2 = new Pessoa();

            pessoa2.Nome = "Cristiano Ronaldo";
            pessoa2.Idade = "42";

            pessoa1.ApresentarNoConsole();
            pessoa2.ApresentarNoConsole();
        }
    }
}
