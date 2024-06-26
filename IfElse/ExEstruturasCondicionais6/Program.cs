﻿/* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”*/

using System;
using System.Globalization;
namespace Curso {
    class Exercicio6 {
        static void Main(string[] args) {
            double valor;
            Console.WriteLine("Digite um valor: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0){
                Console.WriteLine("Fora de intervalo");
            } else if(valor <= 25.0){
                Console.WriteLine("Intervalo [0,25]");
            }else if (valor <= 50.0) {
                Console.WriteLine("Intervalo [25,50]");
            }else if (valor <= 750.0) {
                Console.WriteLine("Intervalo [50,75]");
                }else {
                       Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}