using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class PessoaJuridica : BaseModel
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public PessoaJuridica(int id,string nome,DateTime data,string cnpj,string ie,Endereco end)
        {
            this.Id = id;
            this.Nome = nome;
            this.Data = data;
            this.CNPJ = cnpj;
            this.IE = ie;
            this.End = end;
        }
        public PessoaJuridica()
        {

        }
        public override bool Equals(object pessoaJuridica)
        {
            return this.CNPJ.Equals(((PessoaJuridica)pessoaJuridica).CNPJ);
        }
        //public override string ToString()
        //{
        //    return $"\n-------------------\n{base.ToString()} \nCNPJ: {this.CNPJ} \nIE: {this.IE}";
        //}
    }
}
