/*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

using System;
using System.Globalization;

namespace Curso {
    public class Exercicio5 {
        static void Main(string[]args) {

            int cod1, cod2, qt1, qt2;
            double preco1, preco2, total;

            Console.WriteLine("Digite o codigo da peça 1, a quantidade e o preço, separados por espaço: ");
            string[]valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qt1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture) ;

            Console.WriteLine("Digite o codigo da peça 2, a quantidade e o preço, separados por espaço: ");
            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qt2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = (preco1 * qt1) + (preco2 * qt2);

            Console.WriteLine("Valor a pagar: R$" + total.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}