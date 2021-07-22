using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    class OperacaoPj : Crud
    {
        public OperacaoPj()
        {
            this.opCadastrar = CadPj;
            this.opListar = ListarPj;
            this.opAtualizar = AtualizarPj;
            this.opDeletar = DeletarPj;
        }
        private void CadPj()
        {
            Console.WriteLine("----------------- Cadastro Pessoa Jurídica -----------------");

            Console.Write("Digite seu Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a data de Fundação: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite seu CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.Write("Digite seu IE: ");
            string ie = Console.ReadLine();
            Console.Clear();

            Endereco endereco = new Endereco();
            Console.WriteLine("----------------- Cadastro Pessoa Jurídica -----------------");
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

            PessoaJuridica pj = new PessoaJuridica(lista.Count + 1, nome, data, cnpj, ie, endereco);
            lista.Add(pj);
        }
        private void ListarPj()
        {
            if (lista.Count > 0)
            {
                foreach (PessoaJuridica pessoa in lista)
                {
                    Console.WriteLine(pessoa.ToString());
                }
            }
            else
            {
                Console.WriteLine("Nenhuma pessoa cadastrada.");
            }
        }
        private void AtualizarPj()
        {
            ListarPj();
            Console.WriteLine("Informe o ID que você deseja Atualizar: ");
            int escolhaId = Convert.ToInt32(Console.ReadLine());
            PessoaJuridica pj = (PessoaJuridica)lista.Find(x => x.Id == escolhaId);

            Console.WriteLine("----------------- Editando Pessoa Jurídica -----------------");

            Console.Write("Digite seu Nome: ");
            pj.Nome = Console.ReadLine();
            Console.Write("Digite a data de Fundação: ");
            pj.Data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite seu CNPJ: ");
            pj.CNPJ = Console.ReadLine();
            Console.Write("Digite seu IE: ");
            pj.IE = Console.ReadLine();
            Console.Clear();

            Endereco endereco = new Endereco();
            Console.WriteLine("----------------- Editando Pessoa Jurídica -----------------");
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
            pj.End = endereco;
        }
        private void DeletarPj()
        {
            ListarPj();
            Console.WriteLine("Informe o ID que você deseja deletar: ");
            int escolhaId = Convert.ToInt32(Console.ReadLine());
            PessoaJuridica n = (PessoaJuridica)lista.Find(x => x.Id == escolhaId);
            Console.WriteLine($"Pessoa com o ID: {escolhaId} deletada.");
            lista.Remove(n);
        }
    }
}
