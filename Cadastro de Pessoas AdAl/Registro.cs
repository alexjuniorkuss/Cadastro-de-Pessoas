using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class Registro
    {
        public static List<PessoaFisica> PessoaFisica = new List<PessoaFisica>();
        public static List<PessoaJuridica> PessoaJuridica = new List<PessoaJuridica>();
        Menu menu;
        PessoaFisica pessoaPF = new PessoaFisica();
        Validacao valida = new Validacao();
        public Registro()
        {
            menu = new Menu();
        }
        public void RegistroPF()
        {
            string resp;
            do
            {

                Console.WriteLine("\t\t\t\t\t ##** CADASTRO DE PESSOA FISICA* ##*");
                PessoaFisica pessoa = new PessoaFisica();
                CadastroUpdate(pessoa);
                pessoa.Id = PessoaFisica.Count() + 1;
                PessoaFisica.Add(pessoa);
                Console.Write("Você deseja cadastrar uma nova Pessoa Física?");
                do
                {
                    resp = Validacao.IssNotNull();
                    if (resp != "n" && resp != "s")
                    {
                        ModificaTexto.ColorRed("Invalid Answer! Type Again:");
                    }
                } while (resp != "n" && resp != "s");

            } while (resp == "s");
            menu.MontarMenu();
        }

        private static void CadastroUpdate(PessoaFisica pessoa)
        {
            Console.Write("Nome:");
            pessoa.Nome = Validacao.IssNotNull();
            Console.Write("Data Nascimento:");
            pessoa.Data = Validacao.ValidaData();
            Console.Write("CPF:");
            pessoa.CPF = Validacao.IssNotNull();
            Console.Write("RG:");
            pessoa.RG = Validacao.IssNotNull();
            pessoa.End = new Endereco();
        }

        public void RegistroPJ()
        {
            string resp;
            do
            {
                Console.WriteLine("Empresa:");
                string nome = Validacao.IssNotNull();
                Console.WriteLine("Fundação:");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("CNPJ:");
                string cnpj = Validacao.IssNotNull();
                Console.WriteLine("Inscrição Estadual:");
                string ie = Validacao.IssNotNull();
                Endereco end = new Endereco();
                int Id = PessoaJuridica.Count() + 1;
                

                PessoaJuridica.Add(new PessoaJuridica(Id, nome, data, cnpj, ie, end));

                Console.WriteLine("Você deseja cadastrar uma nova Empresa?");
                do
                {
                    resp = Validacao.IssNotNull();
                    if (resp != "n" && resp != "s")
                    {
                        ModificaTexto.ColorRed("Invalid Answer! Type Again:");
                    }
                } while (resp != "n" && resp != "s");

            } while (resp == "s");
            
        }
        public void ReadAllPF()
        {
            foreach (PessoaFisica pessoa in PessoaFisica)
            {
                Console.WriteLine($"ID:  {pessoa.Id},     Nome: {pessoa.Nome}, Nascimento: { pessoa.Data.ToShortDateString()}, CPF{ pessoa.CPF}, RG: { pessoa.RG}\n" +
                                  $"{ pessoa.End}");
            }
        }
        public void ReadAllPJ()
        {
            foreach (PessoaJuridica empresa in PessoaJuridica)
            {
                Console.WriteLine($"Empresa:\n ID: {empresa.Id} - {empresa.Nome} -  { empresa.Data.ToShortDateString()}-  { empresa.End}-  { empresa.CNPJ}-  { empresa.IE}");
            }
        }
        public void UpdatePF()
        {
            UpdateDeletar();
            CadastroUpdate(pessoaPF);
        }

        private void UpdateDeletar()
        {
            ReadAllPF();
            Console.WriteLine("Digite um Id para Alteração:");
            int idPF = Convert.ToInt32(Console.ReadLine());
            foreach (PessoaFisica pessoa in PessoaFisica)
            {
                if (idPF.Equals(pessoa.Id))
                {
                    pessoaPF = pessoa;
                    Console.WriteLine("Id Localizada!");
                    break;
                }
                Console.WriteLine("Id não localizada!");
            }
            if (pessoaPF.Id == 0)
            {
                Console.WriteLine("Não tem nada aqui");
            }
        }

        public void DeletePF()
        {
            UpdateDeletar();
            Console.WriteLine("Deseja realmente excluir o registro?");
            string resp = Validacao.IssNotNull();
            if (resp == "s")
            {
                PessoaFisica.Remove(pessoaPF);
                Console.WriteLine("Cadastro removido!");
            }
        }
       
    }
}
