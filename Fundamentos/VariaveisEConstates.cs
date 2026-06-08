using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstates {
        public static void Executar() {
            // Variavel
            double raio = 4.5;

            // Constante
            const double PI = 3.14;

            double area = PI * raio * raio;
            int idade = 20;
            bool temGato = false;
            var nome = "Neymar";

            byte idadeNeymar = 32;
            sbyte saldo = -100;
            uint populacaoBrasileira = 207600000;
            long populacaoMundial = 7000000000;
            ulong populacaoMundial2 = 7000000000;

            DateTime dataNascimento = new DateTime(1992,02,05);
            Console.WriteLine("Área é " + area);

        }
    }
}
