using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class Menu
    {
        OperacaoPf opPf;
        OperacaoPj opPj;
        public Menu()
        {
            opPf = new OperacaoPf();
            opPj = new OperacaoPj();
        }
        public void MontarMenu()
        {
            Cabecalho();
            Escolha();
        }
        public void Cabecalho()
        {
            Console.Clear();
            ModificaTexto.ColorBlue   ("______________________________________________________________________________________");
            ModificaTexto.ColorBlue   ("|                                  © HAVAN LABS  - 2021                              |");
            ModificaTexto.ColorBlue   ("|                                                                                    |");
            ModificaTexto.ColorGreen  ("| [1] - Cadastrar Pessoa Física                                                      |");
            ModificaTexto.ColorGreen  ("| [2] - Cadastrar Pessoa Jurídica                                                    |");
            ModificaTexto.ColorBlue   ("|                                                                                    |");
            ModificaTexto.ColorCyan   ("| [3] - Listagem de Pessoas Física                                                   |");
            ModificaTexto.ColorCyan   ("| [4] - Listagem de Pessoas Jurídicas                                                |");
            ModificaTexto.ColorBlue   ("|                                                                                    |");
            ModificaTexto.ColorYellow ("| [5] - Editar PF                                                                    |");
            ModificaTexto.ColorYellow ("| [6] - Editar PJ                                                                    |");
            ModificaTexto.ColorBlue   ("|                                                                                    |");
            ModificaTexto.ColorRed    ("| [7] - Excluir Pessoa Física                                                        |");
            ModificaTexto.ColorRed    ("| [8] - Excluir Pessoa Jurídica                                                      |");
            ModificaTexto.ColorBlue   ("|                                                                                    |");
            ModificaTexto.ColorMagenta("| [0] - Sair do Programa                                                             |");
            ModificaTexto.ColorBlue   ("|____________________________________________________________________________________|");
        }
        public void Escolha()
        {
            int escolha = 0;
            do
            {
                Console.Write("Digite uma das opções acima:");
                try
                {
                    escolha = Int32.Parse(Console.ReadLine());
                    if (escolha < 0 || escolha > 9)
                    {
                        Console.Clear();
                        Cabecalho();
                        Console.WriteLine("Somente uma das opções listadas acima");
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Numero Invalido! Digite um Número Válido:");
                }
            } while (escolha < 0 || escolha > 9);
            Console.Clear();
            switch (escolha)
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
                        opPf.Cadastrar();
                        MontarMenu();
                        break;
                    }
                case 2:
                    {
                        opPj.Cadastrar();
                        MontarMenu();
                        break;
                    }
                case 3:
                    {
                        opPf.Listar();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu: ");
                        Console.ReadKey();
                        MontarMenu();
                        break;
                    }
                case 4:
                    {
                        opPj.Listar();
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu: ");
                        Console.ReadKey();
                        MontarMenu();
                        break;
                    }
                case 5:
                    {
                        opPf.Atualizar();
                        Console.ReadLine();
                        MontarMenu();
                        break;
                    }
                case 6:
                    {
                        opPj.Atualizar();
                        Console.ReadLine();
                        MontarMenu();
                        break;
                    }
                case 7:
                    {
                        opPf.Deletar();
                        Console.ReadLine();
                        MontarMenu();
                        break;
                    }
                case 8:
                    {
                        opPj.Deletar();
                        Console.ReadLine();
                        MontarMenu();
                        break;
                    }
                default:
                    Console.WriteLine("Erro Desconhecido Consulte o Desenvolvedor do Software!");
                    break;
            }
        }
    }
}
