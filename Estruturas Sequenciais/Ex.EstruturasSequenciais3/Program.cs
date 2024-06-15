//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)

using System;
using System.Globalization;

namespace Curso {
    public class Exercicio3 {
        static void Main(string[] args) {

            int a, b, c, d, dif;
            Console.WriteLine("Digite 4 valores inteiros separados por espaço: ");
            string[]vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);
            d = int.Parse(vet[3]);
            dif = ((a*b)-(c*d));

            Console.WriteLine("A diferença do produto de A e B pelo produto de C e D = " + dif);

        }

    }


}