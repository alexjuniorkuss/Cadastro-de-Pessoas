using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public PessoaFisica()
        {

        }
        public PessoaFisica(int id, string nome, DateTime data, Endereco end, string cpf, string rg)
        {
            this.Id = id;
            this.Data = data;
            this.End = end;
            this.CPF = cpf;
            this.Nome = nome; 
            this.RG = rg;
        }
        public override bool Equals(object pessoaFisica)
        {
            return this.CPF.Equals(((PessoaFisica)pessoaFisica).CPF);
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nRG: {this.RG} \nCPF:{this.CPF}  " ;
        }
    }
}
