using System;

namespace Reajuste_de_salário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua renda mensal?");
            int salario = int.Parse(Console.ReadLine());
            if(salario<500){
                double aumento = salario*1.30;
                Console.WriteLine("Seu salário será reajustado e você receberá um aumento de 30% em sua renda, que agora será de: " + aumento);
            }else{
                Console.WriteLine("Seu salário não condiz com os termos para receber um reajuste");
            }
        }   
    
    }

}
