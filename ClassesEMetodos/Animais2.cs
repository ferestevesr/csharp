using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Animais2 {

        // Mudamos de 'Main' para 'Executar' e tiramos a classe interna Program
        public static void Executar() {

            Animais.Animal animal = new Animais.Animal(
                "Rex",
                "Cachorro",
                "Marrom",
                "5 anos"
            );

            animal.ApresentarNoConsole();
        }
    }
}