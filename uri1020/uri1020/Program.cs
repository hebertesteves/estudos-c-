using System;

namespace uri1020 {
    internal class Program {
        static void Main(string[] args) {
            int idadeDias = int.Parse(Console.ReadLine());
            int ano, meses, dias;

            ano = idadeDias / 365;
            idadeDias %= 365;

            meses = idadeDias / 30;
            idadeDias %= 30;

            dias = idadeDias;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
