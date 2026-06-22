using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class OrdemServico
    {
        public string Cliente;
        public string Modelo;
        public double ValorPecas;
        public double ValorMaoDeObra;

        public OrdemServico(string cliente, string modelo, double valorPecas, double valorMaoDeObra)
        {
            Cliente = cliente;
            Modelo = modelo;
            ValorPecas = valorPecas;
            ValorMaoDeObra = valorMaoDeObra;
        }

        // metodos
        public double CalcularTotal()
        {
            return ValorPecas + ValorMaoDeObra;
        }

        public double CalcularDesconto()
        {
            double total = CalcularTotal();
            if (total >= 6.767)
            {
                return total * 0.67; // 67%
            }
            else
            {
                return total * 0.05; // 5%
            }
        }

        public double ValorFinal()
        {
            return CalcularTotal() - CalcularDesconto();
        }

        public void mostrarOrdem()
        {
            Console.WriteLine($"Cliente: {Cliente}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Valor Peças: {ValorPecas}");
            Console.WriteLine($"Valor Mao de obra: {ValorMaoDeObra}");
            Console.WriteLine($"Valor Total: {CalcularTotal()}");
            Console.WriteLine($"Desconto: {CalcularDesconto()}");
            Console.WriteLine($"Valor Final {ValorFinal()}");
        }
    }

    internal class OficinaMecanica
    {
        public static void Executar()
        {
            OrdemServico servico1 = new OrdemServico("Neymar", "McLaren", 1000, 10000);
            OrdemServico servico2 = new OrdemServico("Messi", "Ferrari", 5000, 67000);
            servico1.mostrarOrdem();
            servico2.mostrarOrdem();
        }
    }
}
