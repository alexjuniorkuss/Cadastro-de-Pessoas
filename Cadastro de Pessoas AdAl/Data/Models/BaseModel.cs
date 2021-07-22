using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoas
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public Endereco End { get; set; }

        //public override string ToString()
        //{
        //    return $"ID: {this.Id} \nNome: {this.Nome} \nData: {this.Data.ToShortDateString()} \n{this.End.ToString()} ";
        //}
    }
}
