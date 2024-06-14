//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
//casas decimais conforme exemplos.
//Fórmula da área: area = π.raio2
//Considere o valor de π = 3.14159

using System;
using System.Globalization;

namespace Curso {
    public class Exercicio2 {
        public static void Main(string[] args) {

            double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o raio do circulo : ");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            area = pi * (raio*raio);
            Console.WriteLine("A area do circulo é: " + area.ToString("F4", CultureInfo.InvariantCulture));


        }
    }

}