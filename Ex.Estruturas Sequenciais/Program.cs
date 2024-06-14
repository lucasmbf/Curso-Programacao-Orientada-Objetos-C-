// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
//mensagem explicativa, conforme exemplos
using System;
using System.Runtime.InteropServices;

namespace Curso { 
    public class Exercicio1 {
        public static void Main(string[] args) {
            
            int A,B,SOMA;

            A= int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
             
            SOMA = A + B;

            Console.WriteLine("SOMA = "+ SOMA);

        }
    }


}