using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstates.Executar },
                {"Notacão Ponto - Fundamentos",NotacaoPonto.Executar },
                {"Lendo dados - Fundamentos", LendoDados.Executar  },
                { "Exercicio1 - Fundamentos", Exercicio1.Executar },
                {"Operadores Aritméticos - fundamentos", OperadoresAritmeticos.Executar  },
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar },
                {"Exercicio 1 e 2 If e Else - Estrutura de Controle", exercicio1.Executar },
                {"Exercicio 3 If e Else - Estrutura de Controle", Exercicio3.Executar },
                {"Exercicio 4 If e Else - Estrutura de Controle", Exercicio4.Executar },
                { "Exercicio 5 If e Else - Estrutura de Controle", Exercicio5.Executar },
                {"Exercicio 6 If e Else - Estrutura de Controle", Exercicio6.Executar },
                {"Exercicio 7 If e Else - Estrutura de Controle", Exercicio7.Executar },
                {"Exercicio 8 If e Else - Estrutura de Controle", Exercicio8.Executar }


            });

            central.SelecionarEExecutar();
        }
    }
}