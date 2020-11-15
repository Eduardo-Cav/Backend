using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano que você nasceu: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            int anoatual = int.Parse(Console.ReadLine());

            int idade = anoatual - ano;

            Console.WriteLine($"A sua idade é: {idade} anos");
            
            int semanas = 52;

            int idadeSemana = idade * semanas;
            Console.WriteLine($"A sua idade em semanas é de: {idadeSemana} semanas aproximadamente.");
            
        }
    }
} 
