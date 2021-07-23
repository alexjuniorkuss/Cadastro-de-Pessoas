using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPf_Click(object sender, EventArgs e)
        {
            PessoaFisicaForm pessoaFform = new PessoaFisicaForm();
            pessoaFform.Show();
        }

        private void btPj_Click(object sender, EventArgs e)
        {
            PessoaJuridicaForm pessoaJform = new PessoaJuridicaForm();
            pessoaJform.Show();
        }
    }
}
