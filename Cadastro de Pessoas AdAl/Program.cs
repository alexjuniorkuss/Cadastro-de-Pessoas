using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Cabecalho();
            menu.Escolha();            
        }
    }
}
