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
