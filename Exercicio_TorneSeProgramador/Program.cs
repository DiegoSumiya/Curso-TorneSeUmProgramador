using System;

namespace Exercicio_TorneSeProgramador
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número desejado para a tabuáda: ");
            int numero = int.Parse(Console.ReadLine());
            CalculoTabuada(numero);
        }

       

       
    }
}
