using System;
using System.Diagnostics.Contracts;
using System.Globalization;


namespace Curso {
    class Programa {

        static void Main(string[] args) {

            Console.WriteLine("Digite um numero:");
            int n1 = int.Parse(Console.ReadLine());//int.Parse porque o usuario digitou uma string, é preciso converter para int para poder armazenar na variavel n1

            Console.WriteLine("Digite o sexo: M ou F");
            char ch = char.Parse(Console.ReadLine());//char.Parse, mesmo raciocinio da linha acima

            Console.WriteLine("Digite outro numero: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//double.Parse, mesmo raciocinio da linha acima  

            Console.WriteLine("Digite separado por espaço: Nome, Sexo, idade, altura ");
            string[] cadastro = Console.ReadLine().Split(' ');//cria um vetor para receber uma string, o metodo Split separa a string em partes a cada espaço digitado

            string nome = cadastro[0];//atribui a primeira parte da string ao nome
            char sexo = char.Parse(cadastro[1]);//atribui a segunda parte da string ao sexo, foi necessario converter para char utilizando o Parse
            int idade = int.Parse(cadastro[2]);//atribui a terceira parte da string a idade, foi necessario converter para int utilizando o Parse
            double altura = double.Parse(cadastro[3], CultureInfo.InvariantCulture);//atribui a quarta parte da string a altura, foi necessario converter para double utilizando o Parse
            

            Console.WriteLine("Primeiro numero: " + n1);
            Console.WriteLine("Sexo: " + ch);
            Console.WriteLine("Segundo numero: " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(cadastro[0] + "\n" + cadastro[1] + "\n" + cadastro[2] + "\n" + cadastro[3],CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.Write(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
