using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroPessoas;

namespace Forms1
{   

    public partial class PessoaFisicaForm : Form
    {
        public List<PessoaFisica> ListaPf { get; set; }
        public PessoaFisicaForm()
        {
            InitializeComponent();
            ListaPf = new List<PessoaFisica>();
        }

        private void btCadastrarPf_Click(object sender, EventArgs e)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            Endereco endereco = new Endereco();

            pessoaFisica.Id = this.ListaPf.Count + 1;
            pessoaFisica.Nome = tbNome.Text;
            pessoaFisica.Data = Convert.ToDateTime(tbData.Text);
            pessoaFisica.CPF = tbCpf.Text;
            pessoaFisica.RG = tbRg.Text;

            endereco.Rua = tbRua.Text;
            endereco.Numero = Convert.ToInt32(tbNumero.Text);
            endereco.Complemento = tbComplemento.Text;
            endereco.Bairro = tbBairro.Text;
            endereco.Cidade = tbCidade.Text;

            pessoaFisica.End = endereco;

            this.ListaPf.Add(pessoaFisica);

            MessageBox.Show($"{pessoaFisica.Nome} Cadastrado(a) com Sucesso!!!");
        }
    }
}
