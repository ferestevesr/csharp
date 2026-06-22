using System;

namespace CursoCSharp.ClassesEMetodos {
    class Selecao {
        public string Pais;
        public string Continente;
        public int Titulos;

        public Selecao(string pais, string continente, int titulos) {
            Pais = pais;
            Continente = continente;
            Titulos = titulos;
        }

        public void GanharTitulo() {
            Titulos++;
        }

        public void PerderTitulo() {
            if (Titulos > 0) {
                Titulos--;
            }
        }

        public void MostrarDados() {
            Console.WriteLine($"País: {Pais}");
            Console.WriteLine($"Continente: {Continente}");
            Console.WriteLine($"Títulos: {Titulos}");
        }
    }

    internal class ExercicioSelecaoCopa {
        public static void Executar(){
            Selecao brasil = new Selecao("Brasil", "América do Sul", 5);

            brasil.MostrarDados();
            brasil.GanharTitulo();
            brasil.MostrarDados();
            brasil.PerderTitulo();
            brasil.MostrarDados();

            Console.ReadLine();
        }
    }
}