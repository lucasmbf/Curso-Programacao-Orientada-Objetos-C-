/*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
seguir, calcule e mostre o valor da conta a pagar
cod       especificao        preco
1        cachorro quente     4.00
2        x-salada            4.50
3        x-bacon             5.00
4        torrada simples     2.00
5        Refrigerante        1.50
 
 */

using System;
using System.Globalization;
namespace Curso { 
    class Exercicio5 {
        static void Main(string[] args) {
            Console.WriteLine("Digite o codigo do produto e a quantidade, separados por espaco simples: ");
            string[] prod = Console.ReadLine().Split(' ');

            int cod = int.Parse(prod[0]);
            int qtd = int.Parse(prod[1]);
            double total = 0;
            string produto = String.Empty;

            if (cod == 1) {
                total = qtd * 4.00;
                produto = "Cachorro Quente";
            }
            else if (cod == 2) {
                total = qtd * 4.50;
                produto = "X-Salada";
            }
            else if (cod == 3) {
                total = qtd * 5.00;
                produto = "X-Bacon";
            }
            else if (cod == 4) {
                total = qtd * 2.00;
                produto = "Torrada Simples";
            }
            else if (cod == 5) {
                total = qtd * 1.50;
                produto = "Refrigerante";
            }
             
            Console.WriteLine("Produto: " + produto + "\n" + 
                "Quantidade: " + qtd+ "\n" + 
                "Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
                
            

        }
    }
}