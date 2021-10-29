using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senac.TDE.Codigo.Leitura;

namespace Senac.TDE.Codigo.Menu
{
    class Menu
    {
        public Menu() {
            IniciarMenu();
        }
        public void IniciarMenu()
        {
            foreach(var x in LerArquivo.Txt)
            {
                Console.WriteLine(x); 
            };
        }
    }
}
