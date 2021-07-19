using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class Menu
    {
        public static List<PessoaFisica> PessoaFisica = new List<PessoaFisica>();
        public static List<PessoaJuridica> PessoaJuridica = new List<PessoaJuridica>();
        public static void Main(string[] args)
        {
            BodyMain();
            Choise();
        }
        public static void BodyMain()
        {
            string TamanhoTela;
            Console.Clear();
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("______________________________________________________________________________________");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("|                                                                                    |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("|                                  © HAVAN LABS  - 2021                              |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("|                                                                                    |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("|____________________________________________________________________________________|");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("______________________________________________________________________________________");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("| [1] - Cadastrar Pessoa Física                                                      |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("| [2] - Cadastrar Pessoa Jurídica                                                    |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("|____________________________________________________________________________________|");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("______________________________________________________________________________________");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("| [3] - Listagem de Pessoas Física                                                   |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("| [4] - Listagem de Pessoas Jurídicas                                                |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("| [0] - Sair do Programa                                                             |");
            Console.Write(TamanhoTela);
            TamanhoTela = Cadastro_de_Pessoas_AdAl.ModificaTexto.CenterText("|____________________________________________________________________________________|");
            Console.Write(TamanhoTela);
        }
        public static void Choise()
        {
            int choise = 0;
            Registro reg = new Registro();
            do
            {
                Console.WriteLine("Digite uma das opções acima:");
                try
                {
                    choise = Int32.Parse(Console.ReadLine());
                    if (choise < 0 || choise > 4)
                    {
                        Console.Clear();
                        BodyMain();
                        Console.WriteLine("Somente uma das opções listadas acima");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero Invalido! Digite um Número Válido:");
                }
            } while (choise < 0 || choise > 4);
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
                        reg.RegistroPF(PessoaFisica);
                        BodyMain();
                        Choise();
                        break;
                    }
                case 2:
                    {
                        reg.RegistroPJ(PessoaJuridica);
                        BodyMain();
                        Choise();
                        break;
                    }
                case 3:
                    {
                      
                        reg.ReadAllPF(PessoaFisica);
                        Console.ReadLine();
                        BodyMain();
                        Choise();

                        break;
                    }
                case 4:
                    {
                        reg.ReadAllPJ(PessoaJuridica);
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
