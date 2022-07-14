using System;

namespace Exercicio_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira sua altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira sua idade: ");
            float idade = (float)Convert.ToDouble(Console.ReadLine());

            float resultado = peso / (altura * altura);

            Console.WriteLine("Seu IMC é " + resultado);

            if (resultado <= 18)
            {
                Console.WriteLine("Abaixo do ideal");
            }
            else if (resultado > 18 && resultado <= 25)
            {
                Console.WriteLine("Dentro do ideal");
            }
            else if (resultado > 25)
                Console.WriteLine("Acima do Peso ideal");

        }
    }
}
