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
        public static List<PessoaFisica> PessoaFisica = new List<PessoaFisica>();
        public static List<PessoaJuridica> PessoaJuridica = new List<PessoaJuridica>();
        Validacao valida = new Validacao();
       
        public void RegistroPF()
        {
            string resp;
            do
            {
                Console.WriteLine("\t\t\t\t\t ##** CADASTRO DE PESSOA FISICA* ##*");
                Console.Write("Nome:");
                string nome = valida.IssNotNull();
                Console.Write("Data Nascimento:");
                DateTime data = valida.ValidaData();
                Console.Write("CPF:");
                string cpf = valida. IssNotNull();
                Console.Write("RG:");
                string rg = valida.IssNotNull();
                Endereco end = new Endereco();
                int Id = PessoaFisica.Count() + 1;

                PessoaFisica.Add(new PessoaFisica(Id, nome, data, end, cpf, rg));

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
        public void RegistroPJ()
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
                int Id = PessoaJuridica.Count() + 1;

                PessoaJuridica.Add(new PessoaJuridica(Id, nome, data, end, cnpj, ie));

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
        public void ReadAllPF()
        {
            foreach (PessoaFisica pessoa in PessoaFisica)
            {
                Console.WriteLine($"ID:     {pessoa.Id},     Nome: {pessoa.Nome}, Nascimento: { pessoa.Data.ToShortDateString()}, CPF{ pessoa.CPF}, RG: { pessoa.RG}\n" +
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
       
    }
}
