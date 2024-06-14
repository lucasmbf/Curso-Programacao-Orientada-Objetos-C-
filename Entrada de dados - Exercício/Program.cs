using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite seu nome comleto: ");
            string nome = Console.ReadLine();//Console.ReadLine() le o que o usuario digitou
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());//int.Parse converte a string para inteiro
            Console.WriteLine("Digite o preco de um produto");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);//CultureInfo.InvariantCulture é para o programa aceitar ponto ao inves de virgula
            Console.WriteLine("Digite seu ultimo nome, idade e altura na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');//Split(' ') separa os elementos da string por espaço e depois é possivel atribuir uma variavel pra cada indice
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }


}