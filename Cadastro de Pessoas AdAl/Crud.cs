using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    public delegate void Operacao();
    class Crud
    {
        protected List<BaseModel> lista = new List<BaseModel>();
        protected Operacao opCadastrar;
        protected Operacao opListar;
        protected Operacao opAtualizar;
        protected Operacao opDeletar;
        public void Cadastrar()
        {
            opCadastrar();
        }
        public void Listar()
        {
            opListar();
        }
        public void Atualizar()
        {
            opAtualizar();
        }
        public void Deletar()
        {
            opDeletar();
        }
    }
}
