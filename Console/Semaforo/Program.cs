using System;

namespace Semaforo
{
    class Semaforo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O sinal está vermelho?");
            bool red = bool.Parse(Console.ReadLine());


            string consequencia = "";

            if (red)
            {
                consequencia = "Pare o carro";
            }else{
                Console.WriteLine("O sinal está amarelo?");
                bool yellow = bool.Parse(Console.ReadLine());
                if(yellow){
                    consequencia = "Reduza a velocidade e pare o carro";
                }else{
                    consequencia = "Continue andando";
                }
            }
            Console.WriteLine(consequencia);
        }
    }
}
