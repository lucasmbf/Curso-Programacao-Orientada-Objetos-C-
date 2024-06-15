
//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
using System;

namespace Curso {
    class Exercicio1 {
        static void Main(string[] args) {
            int x = 0;
            Console.WriteLine("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            if (x < 0) {
                Console.WriteLine("Numero negativo");
            }
            else if (x > 0){
                Console.WriteLine("Numero positivo");
            } else {
                Console.WriteLine("Numero neutro");
            }

        }
    }
}