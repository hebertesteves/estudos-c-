using System;

namespace uri1046 {
    internal class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);
            int hora = 0;

            if (horaInicial < horaFinal) {
                hora = Math.Abs(horaInicial - horaFinal);
            } else if (horaInicial > horaFinal) {
              hora =  24 - (horaInicial - horaFinal);
            } else {
                hora = 24;
            }

            Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");

        }
    }
}
