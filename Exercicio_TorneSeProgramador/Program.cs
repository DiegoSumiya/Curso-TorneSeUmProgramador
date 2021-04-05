using System;

namespace Exercicio_TorneSeProgramador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número desejado para a tabuáda: ");
            int numero = int.Parse(Console.ReadLine());
            CalculoTabuada(numero);
        }

        public static void CalculoTabuada(int numero)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
        }

        public static void CalculoMedia(double notas)
        {

        }
    }
}
