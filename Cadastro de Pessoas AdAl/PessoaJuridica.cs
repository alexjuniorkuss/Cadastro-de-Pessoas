using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public PessoaJuridica(int id, string nome, DateTime data, Endereco end, string cnpj, string ie)
        {
            this.Id = id;
            this.Data = data;
            this.End = end;
            this.CNPJ = cnpj;
            this.Nome = nome;
            this.IE = ie;
        }
        public override bool Equals(object pessoaJuridica)
        {
            return this.CNPJ.Equals(((PessoaJuridica)pessoaJuridica).CNPJ);
        }

    }
}
