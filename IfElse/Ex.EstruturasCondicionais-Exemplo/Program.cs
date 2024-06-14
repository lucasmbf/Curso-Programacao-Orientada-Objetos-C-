using System;
using System.Security.Cryptography.X509Certificates;


namespace Curso {
    class Exemplo {
        static void Main(string[] args) {

            
            Console.WriteLine("Digite um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0){ // se o resultado da divisão do numero digitado por 2 for igual a 0, então o numero é par
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Impar");//caso contrario, o numero e impar
            }

        }

    }

}