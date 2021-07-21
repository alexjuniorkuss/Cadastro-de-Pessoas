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
            this.opCadastrar = CadPf;
            this.opListar = ListarPf;
            this.opAtualizar = AtualizarPf;
            this.opDeletar = DeletarPf;
        }
        private void CadPf()
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
            endereco.Numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Complemento: ");
            endereco.Complemento = Console.ReadLine();

            PessoaFisica pf = new PessoaFisica(lista.Count + 1, nome, data,cpf, rg, endereco);
            lista.Add(pf);
        }
        private void ListarPf()
        {
            if (lista.Count > 0)
            {
                foreach (PessoaFisica pessoa in lista)
                {
                    Console.WriteLine(pessoa.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma pessoa cadastro.");
            }
        }
        private void AtualizarPf()
        {
            ListarPf();
            Console.WriteLine("Informe o ID que você deseja Atualizar: ");
            int escolhaId = Convert.ToInt32(Console.ReadLine());
            PessoaFisica pf = (PessoaFisica)lista.Find(x => x.Id == escolhaId);

            Console.WriteLine("----------------- Editando Pessoa Física -----------------");

            Console.Write("Digite seu Nome: ");
            pf.Nome = Console.ReadLine();
            Console.Write("Digite a data de nascimento: ");
            pf.Data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite seu CPF: ");
            pf.CPF= Console.ReadLine();
            Console.Write("Digite seu RG: ");
            pf.RG = Console.ReadLine();
            Console.Clear();

            Endereco endereco = new Endereco();
            Console.WriteLine("----------------- Editando Pessoa Física -----------------");
            Console.WriteLine("----------------- Editando o Endereço -----------------");
            Console.Write("Digite sua Cidade: ");
            endereco.Cidade = Console.ReadLine();
            Console.Write("Digite seu Rua: ");
            endereco.Rua = Console.ReadLine();
            Console.Write("Digite seu Bairro: ");
            endereco.Bairro = Console.ReadLine();
            Console.Write("Digite o Número: ");
            endereco.Numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Complemento: ");
            endereco.Complemento = Console.ReadLine();
            pf.End = endereco;
        }
        private void DeletarPf()
        {
            ListarPf();
            Console.WriteLine("Informe o ID que você deseja deletar: ");
            int escolhaId = Convert.ToInt32(Console.ReadLine());
            PessoaFisica n = (PessoaFisica)lista.Find(x => x.Id == escolhaId);
            Console.WriteLine($"Pessoa com o ID: {escolhaId} deletada.");
            lista.Remove(n);
        }
    }
}
