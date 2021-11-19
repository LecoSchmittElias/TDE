using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Senac.TDE.Codigo.txt
{
    class FinalizarProcesso
    {
        public string[] RealizarMontagem()
        {

            var z = new string[Program.vetorLido.Length];
            for (int x = 0; Program.vetorLido.Length > x; x++)
            {
                string branco = "";
                for (int y = 0; Program.tabelaQuantidade > y; y++)
                {
                    char final;

                    final = y < (Program.tabelaQuantidade - 1) ? final = ',' : final = ' ';

                    branco = branco + "'" + Program.MatrizDividida[x, y] + "'" + final;
                }
                z[x] = branco;
            }
            return z;
        }
        public void RealizarTXT(string[] txt)
        {
            string fim = ".txt";
            string origemPasta = Path.GetDirectoryName(Program.diretorio);
            string destinoPasta = origemPasta + @"\TDEF";
            string destinoArquivo = destinoPasta + @"\Divirta-se";
            int cont = 1, aux = 1;
            do
            {
                if (File.Exists(destinoArquivo + fim))
                {
                    if (aux != 1) destinoArquivo.Substring(destinoArquivo.Length);
                    cont++;
                    destinoArquivo = destinoArquivo + " " + cont;
                    aux--;
                }
                else
                {
                    break;
                }


            } while (true);

            Directory.CreateDirectory(destinoPasta);
            

            using (StreamWriter sw = File.AppendText(destinoArquivo + fim))
            {
                int roll = 0;
                int contar;
                while (true)
                {
                    sw.WriteLine("\nINSERT INTO " + Program.tabelaNome);
                    sw.Write("VALUES ");
                    for (int x = 0; txt.Length > x; x++)
                    {
                        contar = x + (roll * 500);
                        if (contar == txt.Length)
                        {
                            return;
                        }
                        else
                        {
                            if (x == 500)
                            {
                                roll++;
                                break;
                            }
                        }
                        char final = ((contar == txt.Length-1) || (x==499)) ? final = ';' : final = ',';
                        sw.WriteLine($"({txt[contar]}){ final}");
                       
                    }
                }
            }
        }
    }
}


