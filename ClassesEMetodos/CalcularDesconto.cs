using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraDeDesconto {
        public static double CalcularDesconto(double valor, double percentual) {
            return valor - (valor * percentual / 100);
        }
    }
    internal class CalcularDesconto {
        public static void Executar() {
            double valorOriginal = 100.0;
            double percentualDesconto = 15.0;
            double valorComDesconto = CalculadoraDeDesconto.CalcularDesconto(valorOriginal, percentualDesconto);
            Console.WriteLine($"Valor original: {valorOriginal:C}");
            Console.WriteLine($"Percentual de desconto: {percentualDesconto}%");
            Console.WriteLine($"Valor com desconto: {valorComDesconto:C}");

        }
    }
}
