using System;
using System.Globalization;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            int x = 10;
            Console.WriteLine("Digite um numero inteiro de 1 a 20: ");
            x = int.Parse(Console.ReadLine());

            if (x < 10) {
                Console.WriteLine("Bom Dia");
            } else if (x == 10){
                Console.WriteLine("Boa tarde");
            } else if (x > 10) {
                Console.WriteLine("Boa noite");
            }            

        }

    }


}