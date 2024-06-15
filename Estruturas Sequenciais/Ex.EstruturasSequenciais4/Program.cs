//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

using System;
using System.Globalization;

namespace Curso {
    public class Exercicio4 {
        static void Main(string[] args) { 

        int numFuncionario;
        double horas, valorHora,salario;

        Console.WriteLine("Digite o número do funcionário: ");
            numFuncionario = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine("Digite o valor da hora: ");
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        salario = horas * valorHora;

            Console.WriteLine("O funcionario de numero: " + numFuncionario + "recebe: " + "R$"+salario.ToString("F2"),CultureInfo.InvariantCulture);

        }
    }



}