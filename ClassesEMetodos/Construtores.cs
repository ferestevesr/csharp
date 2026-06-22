using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Construtores {

        class Cliente {
            public string Nome;
            public int Idade;
            public string Cpf;
            public string Email;
            public string Endereço;

            public Cliente(string nome, int idade, string cpf, string email, string endereço) {
                Nome = nome;
                Idade = idade;
                Cpf = cpf;
                Email = email;
                Endereço = endereço;
            }
        }
        public static void Executar() {
            var cliente1 = new Cliente(
                "João",
                30,
                "123.456.789-00",
                "Joao@gmail.com",
                "Rua A, 123");
            Console.WriteLine($"Nome: {0}", cliente1.Nome);
        }

    }
}
