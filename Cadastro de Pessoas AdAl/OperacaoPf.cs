using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class OperacaoPf : Crud
    {
        List<PessoaFisica> listPf = new List<PessoaFisica>();

        public OperacaoPf()
        {
            this.createOperation = Create;
            this.readOperation = Listar;
            this.updateOperation = Alterar;
            this.deleteOperation = Deletar;
        }

        private void Create()
        {
            Endereco endereco = new Endereco();
            int id = 1;

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

            PessoaFisica pf = new PessoaFisica(id, nome, data, endereco, cpf, rg);
            listPf.Add(pf);
            id++;
        }

    }
}
