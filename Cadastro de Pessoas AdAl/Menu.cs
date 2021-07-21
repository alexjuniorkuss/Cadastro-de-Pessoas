using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class Menu
    {
        public static void Main(string[] args)
        {
            BodyMain();
            Choise();
        }
        //descom
        public static void BodyMain()
        {
            Console.Clear();
            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine("|                                  © HAVAN LABS  - 2021                              |");
            Console.WriteLine("| [1] - Cadastrar Pessoa Física                                                      |");
            Console.WriteLine("| [2] - Cadastrar Pessoa Jurídica                                                    |");
            Console.WriteLine("| [3] - Listagem de Pessoas Física                                                   |");
            Console.WriteLine("| [4] - Listagem de Pessoas Jurídicas                                                |");
            Console.WriteLine("| [5] - Editar PF                                                                    |");
            Console.WriteLine("| [0] - Sair do Programa                                                             |");
            Console.WriteLine("|____________________________________________________________________________________|");
        }
        public static void Choise()
        {
            int choise = 0;
            Registro reg = new Registro();
            do
            {
                Console.Write("Digite uma das opções acima:");
                try
                {
                    choise = Int32.Parse(Console.ReadLine());
                    if (choise < 0 || choise > 5)
                    {
                        Console.Clear();
                        BodyMain();
                        Console.WriteLine("Somente uma das opções listadas acima");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Numero Invalido! Digite um Número Válido:");
                }
            } while (choise < 0 || choise > 5);
            Console.Clear();
            switch (choise)
            {
                case 0:
                    {
                        Console.Clear();
                        ModificaTexto.ColorRed("Aperte qualquer tecla para encerrar o sistema!");
                        Console.ReadLine();
                        break;
                    }
                case 1:
                    {
                        reg.RegistroPF();
                        BodyMain();
                        Choise();
                        break;
                    }
                case 2:
                    {
                        reg.RegistroPJ();
                        BodyMain();
                        Choise();
                        break;
                    }
                case 3:
                    {
                        reg.ReadAllPF();
                        Console.ReadLine();
                        BodyMain();
                        Choise();

                        break;
                    }
                case 4:
                    {
                        reg.ReadAllPJ();
                        Console.ReadLine();
                        BodyMain();
                        Choise();
                        break;
                    }
                case 5:
                    {
                        reg.UpdatePF();
                        Console.ReadLine();
                        BodyMain();
                        Choise();
                        break;
                    }

                default:
                    Console.WriteLine("Erro Desconhecido Consulte o Desenvolvedor do Software!");
                    break;
            }
        }
    }
}
