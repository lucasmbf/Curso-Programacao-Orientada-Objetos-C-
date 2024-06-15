//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
using System;

namespace Curso {
    class Exercicio2 {
        static void Main(string[] args) {
            int x = 0;
            Console.WriteLine("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 ==0) {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Numero impar");
            }

        }
    }
}