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
            Console.WriteLine("Digite a Rua:");
            this.Rua = valida.IssNotNull();
            Console.WriteLine("Digite o Número:");
            this.Numero = valida.IssNotNull();
            Console.WriteLine("Digite o Complemento:");
            this.Complemento = valida.IssNotNull();
            Console.WriteLine("Digite o Bairro:");
            this.Bairro = valida.IssNotNull();
            Console.WriteLine("Digite a Cidade:");
            this.Cidade = valida.IssNotNull();
        }
        public override string ToString()
        {
            return ($"Rua : {this.Rua} Numero : {this.Numero} -Complemento : {this.Complemento} -Bairro : {this.Bairro} Cidade : {this.Bairro}" );
        }
    }

}
