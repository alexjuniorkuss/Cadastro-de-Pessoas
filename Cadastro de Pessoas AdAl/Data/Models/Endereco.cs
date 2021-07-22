using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        //public override string ToString()
        //{
        //    return ($"-------Endereço-------" +
        //            $"\nRua: {this.Rua} \nNumero: {this.Numero}" +
        //            $"\nBairro: {this.Bairro} \nCidade:{this.Cidade}  " +
        //            $"\nComplemento: {this.Complemento}" );
        //}
    }

}
