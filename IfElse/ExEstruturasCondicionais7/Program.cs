/*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas 
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o 
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a 
situação. 


Q2 | Q1
_________

Q3 | Q4
 */

using System;
using System.ComponentModel.Design;
using System.Globalization;
namespace Curso {
    class Exercicio7 {
        static void Main(string[]args) {
            double x, y;
            Console.WriteLine("Digite a posição do ponto x e a posição do ponto y respectivamente, separados por espaço simples: ");
            string[]vet = Console.ReadLine().Split(' ');
            x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("O ponto está na origem");
            } else if(x == 0.0 && y != 0.0) {
                Console.WriteLine("O ponto está no eixo Y");
            }else if(x != 0.0 && y == 0.0) {
                Console.WriteLine("O ponto está no eixo X");
            }

            if(x > 0.0 && y > 0.0){
                Console.WriteLine("O ponto esta no quadrante 1");
            }else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("O ponto esta no quadrante 2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("O ponto esta no quadrante 3");
            }
            else if(x > 0.0 && y < 0.0) {
                Console.WriteLine("O ponto esta no quadrante 4");
            }
        }
    }
}