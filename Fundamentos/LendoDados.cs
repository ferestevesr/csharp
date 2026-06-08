using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
          Console.WriteLine("Digite seu CVV: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("O CVV é ", codigo);

            double valor = 67.6767676767;

           // ARREDONDAR
            Console.WriteLine(valor.ToString("F1"));

            // VALOR MONETARIo
            Console.WriteLine(valor.ToString("C"));

            //DO JEITO Q QUISER
            Console.WriteLine(valor.ToString("#.###"));

            //Porcentagem

            Console.WriteLine(valor.ToString("P"));
        }
    }
}
