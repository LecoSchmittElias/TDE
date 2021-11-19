using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.TDE.Codigo.txt
{
    public class LerArquivo
    {
        public string[] RealizarLeitura()=> System.IO.File.ReadAllLines(Program.diretorio);

    }
}
