using System;

namespace CursoCSharp.ClassesEMetodos {
    public class Calculadora {
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    internal class MetodosEstaticos {
        public static void Executar() {
            int resultadoSoma = Calculadora.Somar(10, 20);
            int resultadoMultiplicacao = Calculadora.Multiplicar(10, 20);

            Console.WriteLine($"Resultado da soma: {resultadoSoma}");
            Console.WriteLine($"Resultado da multiplicação: {resultadoMultiplicacao}");
        }
    }
}