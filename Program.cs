using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
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
                {"Exercicio 8 If e Else - Estrutura de Controle", Exercicio8.Executar },
                { "Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar },
                { "Estrutura Repetição - Estrutura de Controle", EstruturaDeRepeticao.Executar },
                {"Estrutura Repetição Ex1 - Estrutura de Controle", Exercicio1Repeticao.Executar },
                {"Estrutura Repetição Ex2 (11/06) - Estrutura de Controle", Exercicio2Repeticao.Executar },
                {"Estrutura Repetição Ex3 (11/06) - Estrutura de Controle", Exercicio3Repeticao.Executar },
                {"Estrutura Repetição Ex4 (11/06) - Estrutura de Controle", Exercicio4Repeticao.Executar },
                {"Estrutura Repetição Ex5 (11/06) - Estrutura de Controle", Exercicio5Repeticao.Executar },
                // classes e metodos
                
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Exericio1oe - Classes e Metodos", Exercicio1jogador.Executar },
                {"Animais - Classes e Metodos", Animais2.Executar }



            });

            central.SelecionarEExecutar();
        }
    }
}