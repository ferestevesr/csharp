using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {

            /* 
            Console.WriteLine("Digite um número:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número:");
            double n2 = double.Parse(Console.ReadLine());

            double total = n1 + n2;
            Console.WriteLine("O resultado da soma é: " + total);

            */

            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;

            Console.WriteLine(c >= b);
            Console.WriteLine(d < c);

            Console.WriteLine(a == d && d <= b);

            Console.WriteLine(a > d || c != d);

            /* Console.WriteLine("Digite um número para calcular a base do triangulo:");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número para calcular a altura do triangulo:");
            double n4 = double.Parse(Console.ReadLine());

            double area = (n3 * n4) / 2;
            Console.WriteLine("O resultado da área do triangulo é: " + area); */
        }
    }
}
