using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu peso:");
            var pesoDigitado = Console.ReadLine();
            double peso = Convert.ToDouble(pesoDigitado);

            Console.WriteLine("Entre com sua altura:");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Peso da pessoa: "+ peso);
            Console.WriteLine($"Altura da pessoa: {altura}");

            double result = peso / (altura * altura);

            if (result < 18)
            {
                Console.WriteLine("Magro");
            }
            else if (result >= 18 && result < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (result >= 25 && result <30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (result >= 30 && result <39)
            {
                Console.WriteLine("Obesidade");
            }
            else if (result >= 40 )
            {
                Console.WriteLine("mórbido");
            }
        }
    }       
}   
