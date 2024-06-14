/*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B.*/

using System;
using System.Globalization;

namespace Curso {
    class Exercicio6 {
        static void Main(string[] args) {

            double a, b, c, trianguloRetangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

            Console.WriteLine("Digite as dimensoes de A,B e C separados por espaço: ");
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0],CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            trianguloRetangulo = a * c / 2;
            circulo = pi * (c * c);
            trapezio = (a + b) * c / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("a área do triângulo retângulo que tem A por base e C por altura = "+ trianguloRetangulo.ToString("F3",CultureInfo.InvariantCulture) + "\n" +
                "a área do círculo de raio C =" + circulo.ToString("F3", CultureInfo.InvariantCulture) + "\n" +
                "a área do trapézio que tem A e B por bases e C por altura = " + trapezio.ToString("F3", CultureInfo.InvariantCulture) + "\n" +
                "a área do quadrado que tem lado B = " + quadrado.ToString("F3", CultureInfo.InvariantCulture) + "\n" +
                "a área do retângulo que tem lados A e B = " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }

    }

}