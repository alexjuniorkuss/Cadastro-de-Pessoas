using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas_AdAl
{
    public delegate void Operacoes();
    class Crud
    {
        internal List<PessoaFisica> listPf = new List<PessoaFisica>();
        protected List<PessoaJuridica> listPj = new List<PessoaJuridica>():
        protected Operacoes createOperation;
        protected Operacoes readOperation;
        protected Operacoes updateOperation;
        protected Operacoes deleteOperation;

        public void Create()
        {
            createOperation();
        }
        public void Read()
        {
            readOperation();
        }
        public void Update()
        {
            updateOperation();
        }
        public void Delete()
        {
            deleteOperation();
        }
    }

}
