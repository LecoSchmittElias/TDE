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
        public Menu()
        {
            RequisitarDiretorio();
            IniciarMenu();
        }

        private void RequisitarDiretorio()
        {
            bool auxiliarMenu = false;
            while (true)
            {
                Console.Clear();
                string text = auxiliarMenu == false ? text ="Digite o diretorio do txt: " : text="Digite o nome da sua tabela no SQL Server: ";

                Console.WriteLine(text);
                string link = Console.ReadLine();

                if (Program.diretorio == null) { Program.diretorio = link; auxiliarMenu = true; }
                else { Program.tabelaNome = link;return; }

            }
        }

        public void IniciarMenu()
        {

        }
    }
}
