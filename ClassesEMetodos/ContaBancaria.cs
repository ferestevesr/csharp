using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ContaCliente {
        public string Titular;
        public double Saldo;

        public ContaCliente(string titular, double saldo) {
            Titular = titular;
            Saldo = saldo;
        }
        public void Depositar(double valor) {
            Saldo += valor;
        }
        public void sacar(double valor) { 
            Saldo -= valor;
        
    }
    internal class ContaBancaria {
        public static void Executar() {
            var conta = new ContaCliente("João Silva", 1500.00);
            Console.WriteLine($"Titular: {conta.Titular}");
            Console.WriteLine($"Saldo: {conta.Saldo:C}");


        }
}
}
