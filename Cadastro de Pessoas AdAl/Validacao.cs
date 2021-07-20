using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class Validacao
    {
        public string IssNotNull()
        {
            string texto = String.Empty;
            while (true)
            {
                texto = Console.ReadLine().Trim();
                if (texto.Equals(""))
                {
                    ModificaTexto.ColorRed("Digite um caracter válido!");
                }
                else
                {
                    break;
                }
            }
            return texto;
        }
        public static int IntBiggerZero()
        {
            int value = -1;
            while (value < 0)
            {
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < 0)
                    {
                        ModificaTexto.ColorRed("Invalid Value. Type Again:");

                    }
                }
                catch (FormatException)
                {
                    ModificaTexto.ColorRed("Invalid Characters. Type Again:");
                }
                catch (OverflowException)
                {
                    ModificaTexto.ColorRed("Invalid Number. Type Again:");
                }
            }
            return value;
        }
        public static decimal ValueMoney()
        {
            decimal value = 0;
            while (value == 0)
            {
                try
                {
                    value = Convert.ToDecimal(Console.ReadLine());
                    if (value < 0)
                    {
                        ModificaTexto.ColorRed("Invalid Value. Type Again:");
                    }
                }
                catch (FormatException)
                {
                    ModificaTexto.ColorRed("Invalid Characters. Type Again:");
                }
                catch (OverflowException)
                {
                    ModificaTexto.ColorRed("Invalid Number. Type Again:");
                }
            }
            return value;
        }
        public DateTime ValidaData()
        {
            DateTime DataHj = DateTime.Now;
            DateTime DataUser = DateTime.Now;
            bool t = true;
            while (t == true)
            {
                try
                {
                    DataUser = Convert.ToDateTime(Console.ReadLine());
                    t = false;
                    if (DataHj < DataUser)
                    {
                        Console.WriteLine("Data Inválida! Digite Novamente:");
                        t = true;
                     }
                }
                catch (Exception)
                {
                    Console.WriteLine("Data Invalida");
                    t = true;
                }
            }
            return DataUser;
        }
        public string Cpf(int tamanho)
        {
            string docCpf = Console.ReadLine().Trim();


            if (tamanho == )
            return docCpf;
        }

    }
}
