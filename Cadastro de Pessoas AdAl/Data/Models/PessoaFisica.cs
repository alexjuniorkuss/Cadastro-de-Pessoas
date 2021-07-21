using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class PessoaFisica : BaseModel
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public PessoaFisica()
        {

        }
        public PessoaFisica(int id,string nome,DateTime data,string cpf,string rg,Endereco end)
        {
            this.Id = id;
            this.Nome = nome; 
            this.Data = data;
            this.CPF = cpf;
            this.RG = rg;
            this.End = end;
        }
        public override bool Equals(object pessoaFisica)
        {
            return this.CPF.Equals(((PessoaFisica)pessoaFisica).CPF);
        }
        public override string ToString()
        {
            return $"{base.ToString()} \nRG: {this.RG} \nCPF:{this.CPF}";
        }
    }
}
