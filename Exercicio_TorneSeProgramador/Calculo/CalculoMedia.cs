using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno" + nome);

            List<double> notas = new List<double>();
            double totalNotas = 0;
            for(int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Digite a nota numero: " + i);
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                totalNotas += nota;
                notas.Add(nota);
            }

            double media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + "é: " + media);
            Console.WriteLine("Suas notas são: \n");
            foreach(double nota in notas)
            {
                Console.WriteLine(nota);
            }

        }
    }
}
