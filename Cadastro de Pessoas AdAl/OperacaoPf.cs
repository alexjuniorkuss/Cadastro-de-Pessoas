using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class OperacaoPf : Crud
    {

        public OperacaoPf()
        {
            this.createOperation = Cadastrar;
            this.readOperation = Listar;
           // this.updateOperation = Atualizar;
            //this.deleteOperation = Deletar;
        }


        private void Cadastrar()
        {
            Console.WriteLine("----------------- Cadastro Pessoa Física -----------------");

            Console.Write("Digite seu Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a data de nascimento: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite seu RG: ");
            string rg = Console.ReadLine();
            Console.Clear();

            Endereco endereco = new Endereco();
            Console.WriteLine("----------------- Cadastro Pessoa Física -----------------");
            Console.WriteLine("----------------- Cadastro de Endereço -----------------");
            Console.Write("Digite sua Cidade: ");
            endereco.Cidade = Console.ReadLine();
            Console.Write("Digite seu Rua: ");
            endereco.Rua = Console.ReadLine();
            Console.Write("Digite seu Bairro: ");
            endereco.Bairro = Console.ReadLine();
            Console.Write("Digite o Número: ");
            endereco.Numero = Console.ReadLine();
            Console.Write("Complemento: ");
            endereco.Complemento = Console.ReadLine();

            PessoaFisica pf = new PessoaFisica(listPf.Count + 1, nome, data, endereco, cpf, rg);
            listPf.Add(pf);

        }
        private void Listar()
        {
            if (listPf.Count > 0)
            {
                foreach (PessoaFisica pessoa in listPf)
                {
                    Console.WriteLine(pessoa.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma pessoa cadastro.");
            }
        }
        //private void Atualizar()
        //{
        //    PessoaFisica pf = new PessoaFisica();
        //    Listar();
        //    Console.Write("Escolha um ID para alterar: ");
        //    int escolhaId = Convert.ToInt32(Console.ReadLine());

        //    foreach (PessoaFisica pessoaF in listPf)
        //    {
        //        if (escolhaId.Equals(pessoaF.Id))
        //        {
        //            pf = pessoaF;
        //            Console.WriteLine($"Pessoa Física {pessoaF.Nome} encontrado!!!");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Nenhuma Pessoa Física com este ID '{escolhaId}' encontrado");
        //        }
        //    }
        //    if (pf.Id == 0)
        //    {
        //        Console.WriteLine("Pessoa não encontrada.");
        //    }
       // }
    }
}
