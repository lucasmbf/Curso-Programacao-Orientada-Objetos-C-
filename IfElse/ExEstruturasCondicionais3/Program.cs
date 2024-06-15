/*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
ordem crescente ou decrescente.*/
using System;

namespace Curso {
    class Exercicio3 {
        static void Main(string[] args) {
            Console.WriteLine("Digite 2 numeros inteiros: ");
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if(a % b == 0 || b % a == 0){
                           Console.WriteLine("Sao Multiplos");
            } else {
                           Console.WriteLine("Nao sao Multiplos");
              }
        }
    }

}