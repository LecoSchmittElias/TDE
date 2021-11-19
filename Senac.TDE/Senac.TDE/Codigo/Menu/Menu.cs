using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senac.TDE.Codigo.txt;

namespace Senac.TDE.Codigo.Menu
{
    class Menu
    {
        public Menu()
        {
            RequisitarInfos();
            Console.Clear();
            MostrarMontagem();
        }

        private void RequisitarInfos()
        {
            bool auxiliarMenu = false;
            while (true)
            {
                string text = auxiliarMenu == false ? text ="Digite o diretorio do txt: " : text= "Digite o divisor de conteudo: ";

                Console.WriteLine(text);
                string link = Console.ReadLine();

                if (Program.diretorio == null) { Program.diretorio = link; auxiliarMenu = true; }
                else {
                    Program.divisor = link;

                    
                    Console.WriteLine("Digite o nome da tabela do SQL Server: ");
                    link = Console.ReadLine();

                    Program.tabelaNome = link;

                    break; }
            }

            Console.WriteLine("Digite a quatidade de colunas presentes na tabela(Desconsidere a PK): ");
            int quant = int.Parse(Console.ReadLine());

            Program.tabelaQuantidade = quant;

        }

        public void MostrarMontagem()
        {
            var ler = new LerArquivo();
            var dividir = new SepararString();
            var finalizar = new FinalizarProcesso();

            var etapa1 = (Program.vetorLido = ler.RealizarLeitura());
            var etapa2 = (Program.MatrizDividida = dividir.DividirTxt());
            var etapa3 = (finalizar.RealizarMontagem());


            foreach (var x in  etapa1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n\nPrimeira etapa realizada com sucesso\n\n");
            Console.ReadKey();
            Console.Clear();

            
            foreach(var x in etapa2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n\nSegunda etapa realizada com sucesso\n\n");
            Console.ReadKey();
            Console.Clear();

            foreach (var x in etapa3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n\nTerceira etapa realizada com sucesso\n\n");
            Console.ReadKey();
            Console.Clear();

            finalizar.RealizarTXT(etapa3);
            Console.WriteLine("PROCESSO CONCLUIDO COM EXITO");
        }
    }
}
