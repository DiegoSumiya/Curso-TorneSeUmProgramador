using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Diretorio
{
    class Arquivo
    {
        public static void Ler(int numeroArquivo)
        {
            string caminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("---------- Lendo arquivo ----------\n" + caminho + "\n --------------------");
            if (File.Exists(caminho))
            {
                using (StreamReader arquivo = File.OpenText(caminho))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string caminho2 = @"C:\arquivo\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(caminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
