/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas*/
using System;

namespace Curso {
    class Exercicio4 {
        static void Main(string[] args) {
            Console.WriteLine("Digite a hora inicial e a hora final do jogo separadas por espaço simples: ");
            string[] vet = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);
            int duracao = 0;

            if(horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}