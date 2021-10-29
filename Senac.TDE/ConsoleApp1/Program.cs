using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("entre com o camminho do arquivo: ");
            string origemArquivo = Console.ReadLine();

            try
            {
                string[] linha = File.ReadAllLines(origemArquivo);

                string origemPasta = Path.GetDirectoryName(origemArquivo);
                string destinoPasta = origemPasta + @"\C#";
                string destinoArquivo = destinoPasta + @"\string.txt";

                Directory.CreateDirectory(destinoPasta);

                using (StreamWriter sw = File.AppendText(destinoArquivo))
                {
                    foreach (string x in linha)
                    {

                        string[] campo = x.Split('-');

                        sw.WriteLine(x);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
