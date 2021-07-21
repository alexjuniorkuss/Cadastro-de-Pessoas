using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        Validacao valida = new Validacao();
        public Endereco()
        {
            
        }
        public override string ToString()
        {
            return ($"Rua: {this.Rua} \nNumero: {this.Numero} \nBairro:{this.Bairro} \nCidade:{this.Cidade}  \nComplemento: {this.Complemento}" );
        }
    }

}
