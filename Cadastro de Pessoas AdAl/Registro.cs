using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class Registro
    {
        //public int Id = 0;
        //public string name = string.Empty;
        //public decimal value = 0;
        //public string Description = string.Empty;
        Validacao valida = new Validacao();
       
        public void CreatePF(List<PessoaFisica> pessoaFisicas)
        {
            string resp;
            do
            {
                Console.WriteLine("\t\t\t\t\t ##** CADASTRO DE PESSOA FISICA* ##*");
                string nome, cpf, rg;
                DateTime data;
                Endereco end;
                CadastroUpdate(out nome, out data, out cpf, out rg, out end);
                int Id = pessoaFisicas.Count() + 1;

                Menu.PessoaFisica.Add(new PessoaFisica(Id, nome, data, end, cpf, rg));

                Console.Write("Você deseja cadastrar uma nova Pessoa Física?");
                do
                {
                    resp = valida.IssNotNull();
                    if (resp != "n" && resp != "s")
                    {
                        ModificaTexto.ColorRed("Invalid Answer! Type Again:");
                    }
                } while (resp != "n" && resp != "s");

            } while (resp == "s");
            Menu.BodyMain();
            Menu.Choise();
        }

        private void CadastroUpdate(out string nome, out DateTime data, out string cpf, out string rg, out Endereco end)
        {
            Console.Write("Nome:");
            nome = valida.IssNotNull();
            Console.Write("Data Nascimento:");
            data = valida.ValidaData();
            Console.Write("CPF:");
            cpf = valida.IssNotNull();
            Console.Write("RG:");
            rg = valida.IssNotNull();
            end = new Endereco();
        }

        public void CreatePJ(List<PessoaJuridica> pessoaJuridicas)
        {
            string resp;
            do
            {
                Console.WriteLine("Empresa:");
                string nome = valida.IssNotNull();
                Console.WriteLine("Fundação:");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("CNPJ:");
                string cnpj = valida.IssNotNull();
                Console.WriteLine("Inscrição Estadual:");
                string ie = valida.IssNotNull();
                Endereco end = new Endereco();
                int Id = pessoaJuridicas.Count() + 1;

                Menu.PessoaJuridica.Add(new PessoaJuridica(Id, nome, data, end, cnpj, ie));

                Console.WriteLine("Você deseja cadastrar uma nova Empresa?");
                do
                {
                    resp = valida.IssNotNull();
                    if (resp != "n" && resp != "s")
                    {
                        ModificaTexto.ColorRed("Invalid Answer! Type Again:");
                    }
                } while (resp != "n" && resp != "s");

            } while (resp == "s");
            
        }
        public void ReadAllPF(List<PessoaFisica> pessoaFisica)
        {
            foreach (PessoaFisica pessoa in pessoaFisica)
            {
                Console.WriteLine($" Nome:\n ID: {pessoa.Id} - {pessoa.Nome} -  { pessoa.Data.ToShortDateString()}-  { pessoa.End}-  { pessoa.CPF}-  { pessoa.RG}");
            }
        }
        public void ReadAllPJ(List<PessoaJuridica> pessoaJuridica)
        {
            foreach (PessoaJuridica empresa in pessoaJuridica)
            {
                Console.WriteLine($" Empresa:\n ID: {empresa.Id} - {empresa.Nome} -  { empresa.Data.ToShortDateString()}-  { empresa.End}-  { empresa.CNPJ}-  { empresa.IE}");
            }
        }
        public void UptadePF(List<PessoaFisica> pessoaFisica)
        {
            foreach (PessoaFisica pessoa in pessoaFisica)
            {
                Console.WriteLine($"Id: {pessoa.Id} \t Nome: {pessoa.Nome} Nascimento: {pessoa.Data}");
            }








            //Console.WriteLine("\nDigite a Id da Pessoa Física que deseja alterar");
            //int id = Convert.ToInt32(Console.ReadLine());
            //PessoaFisica pf = new PessoaFisica();
            //foreach (var pessoa in pessoaFisica)
            //{
            //    if (pessoa.Id.Equals(id))
            //    {
            //        pf = pessoa;
            //        break;
            //    }
                
            //}



        }

       
    }
}
