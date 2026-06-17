using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Animais {


        public class Animal {
            public string Nome;
            public string Especie;
            public string Cor;
            public string Idade;
          


            public Animal(string nome, string especie, string cor, string idade) {
                Nome = nome;
                Especie = especie;
                Cor = cor;
                Idade = idade;
            }

            public void ApresentarNoConsole() {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Espécie: {Especie}");
                Console.WriteLine($"Cor: {Cor}");
                Console.WriteLine($"Idade: {Idade}");

            }
        }


    }
}
