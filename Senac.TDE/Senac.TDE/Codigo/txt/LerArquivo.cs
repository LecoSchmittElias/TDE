using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.TDE.Codigo.Leitura
{
    public class LerArquivo
    {

        public static string[] Txt = System.IO.File.ReadAllLines($@"C:\Users\Elias\Documents\Projeto P\TDE\Converter.txt");
    }
}
