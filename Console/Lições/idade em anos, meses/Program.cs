using System;

namespace idade_em_anos__meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int meses = idade * 12;
            int dias = meses * 360;
            int horas = dias *24;
            int minutos = horas * 60;

            Console.WriteLine("Voce ja viveu: " + meses + " meses, " + dias + " dias, " + horas + " horas, " + minutos + " minutos, ");
        }
    }
}
