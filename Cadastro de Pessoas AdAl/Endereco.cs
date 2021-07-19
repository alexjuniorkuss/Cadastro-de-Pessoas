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
        public Endereco()
        {
            Console.WriteLine("Digite a Rua:");
            this.Rua = Validacao.IssNotNull();
            Console.WriteLine("Digite o Número:");
            this.Numero = Validacao.IssNotNull();
            Console.WriteLine("Digite o Complemento:");
            this.Complemento = Validacao.IssNotNull();
            Console.WriteLine("Digite o Bairro:");
            this.Bairro = Validacao.IssNotNull();
            Console.WriteLine("Digite a Cidade:");
            this.Cidade = Validacao.IssNotNull();
        }
        public override string ToString()
        {
            return ($"Rua : {this.Rua} Numero : {this.Numero} -Complemento : {this.Complemento} -Bairro : {this.Bairro} Cidade : {this.Bairro}" );
        }
    }

}
