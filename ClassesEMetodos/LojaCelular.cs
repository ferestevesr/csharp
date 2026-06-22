using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {


    class Servico {

        public string Cliente;
        public string ModeloCelular;
        public double ValorCelular;
        public double Quantidade;

        public Servico(string cliente, string modelo, double valorCelular, double quantidade) {
            Cliente = cliente;
            ModeloCelular = modelo;
            ValorCelular = valorCelular;
            Quantidade = quantidade;
        }
        // metodos
        public double CalcularSubTotal() {

            return ValorCelular * Quantidade;
          
        }
        public double CalcularDesconto() {
            double total = CalcularSubTotal();
            if (Quantidade >= 3) {
                return total * 0.15; // 15%
            } else {
                return total * 0.05; // 5%
            }
        }

        public double ValorFinal() {
            return CalcularSubTotal() - CalcularDesconto();
        }

        public void MostrarVenda() {
            Console.WriteLine($"Cliente: {Cliente}");
            Console.WriteLine($"Modelo do Celular: {ModeloCelular}");
            Console.WriteLine($"Valor Celular: {ValorCelular}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Valor Total: {CalcularSubTotal()}");
            Console.WriteLine($"Desconto: {CalcularDesconto()}");
            Console.WriteLine($"Valor Final {ValorFinal()}");
        }
    }

    internal class LojaCelular {
        public static void Executar() {
            Servico servico1 = new Servico("Neymar", "Sansung", 1.599, 1);

            Servico servico2 = new Servico("Messi", "Iphone", 5.000, 10);
            servico1.MostrarVenda();
            servico2.MostrarVenda();
        }

    }
}
