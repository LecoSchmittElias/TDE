using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senac.TDE.Codigo.txt;
using System.IO;
namespace Senac.TDE.Codigo.txt
{
   public class SepararString
    {
       public string[,] DividirTxt()
        {
            string[,] txtDividido = new string[Program.vetorLido.Length, Program.tabelaQuantidade];

            for(int i = 0; i < Program.vetorLido.Length; i++)
            {
                string[] x = Program.vetorLido[i].Split(Program.divisor); 

                for(int y = 0; y<Program.tabelaQuantidade; y++)
                {
                    txtDividido[i, y] = x[y];
                }
            }

            return txtDividido;
        }
    }
}
