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
       
        public void RegistroPF(List<PessoaFisica> pessoaFisicas)
        {
            string resp;
            do
            {
                Console.WriteLine("Nome:");
                string nome = Validacao.IssNotNull();
                Console.WriteLine("Data Nascimento:");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("CPF:");
                string cpf = Validacao.IssNotNull();
                Console.WriteLine("RG:");
                string rg = Validacao.IssNotNull();
                Endereco end = new Endereco();
                int Id = pessoaFisicas.Count() + 1;

                Menu.PessoaFisica.Add(new PessoaFisica(Id, nome, data, end, cpf, rg));

                Console.WriteLine("Você deseja cadastrar uma nova Pessoa Física?");
                do
                {
                    resp = Validacao.IssNotNull();
                    if (resp != "n" && resp != "s")
                    {
                        ModificaTexto.ColorRed("Invalid Answer! Type Again:");
                    }
                } while (resp != "n" && resp != "s");

            } while (resp == "s");
            Menu.BodyMain();
            Menu.Choise();
        }
        public void RegistroPJ(List<PessoaJuridica> pessoaJuridicas)
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
                int Id = pessoaJuridicas.Count() + 1;

                Menu.PessoaJuridica.Add(new PessoaJuridica(Id, nome, data, end, cnpj, ie));

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
       
    }
}
