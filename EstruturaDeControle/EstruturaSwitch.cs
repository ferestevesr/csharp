using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Escolha uma seleção: ");
            Console.WriteLine("1 - Brasil");
            Console.WriteLine("2 - Argentina");
            Console.WriteLine("3 - Espanha");
            Console.WriteLine("4 - França");
            int selecao = int.Parse(Console.ReadLine());

            switch (selecao) {
                case 1: 
                    Console.WriteLine("Você escolheu o Brasil!"); 
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a Argentina!");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a Espanha!");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a França!");
                    break;
            }
                



        }
    }
}

