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
            dgCadPf.AutoGenerateColumns = false;
            dgCadPf.AllowUserToAddRows = false;

            ListarCadastro();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCadastro();
        }

        int id = 1;
        int idEdicao = 0;
        private void btCadastrarPf_Click(object sender, EventArgs e)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            Endereco endereco = new Endereco();

            pessoaFisica.Id = idEdicao;
            pessoaFisica.Nome = tbNome.Text;
            pessoaFisica.Data = Convert.ToDateTime(dtData.Text);
            pessoaFisica.CPF = tbCpf.Text;
            pessoaFisica.RG = tbRg.Text;

            endereco.Rua = tbRua.Text;
            endereco.Numero = Convert.ToInt32(tbNumero.Text);
            endereco.Complemento = tbComplemento.Text;
            endereco.Bairro = tbBairro.Text;
            endereco.Cidade = tbCidade.Text;

            pessoaFisica.End = endereco;

            int indexId = ListaPf.FindIndex(x => x.Id == pessoaFisica.Id);
            if(indexId == -1)
            {
                pessoaFisica.Id = id;
                this.ListaPf.Add(pessoaFisica);
                MessageBox.Show($"{pessoaFisica.Nome} Cadastrado(a) com Sucesso!!!");
            }
            else
            {
                this.ListaPf[indexId] = pessoaFisica;
                MessageBox.Show($"Cadastro {pessoaFisica.Nome} Editado(a) com Sucesso!!!");
            }
            id++;

            ListarCadastro();

            LimparCadastro();
        }
        private void dgCadPf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.ColumnIndex;

            if(indice == 0)
            {
                PessoaFisica pessoaF = this.ListaPf[e.RowIndex];
                idEdicao =  pessoaF.Id;
                CarregarCadastro(pessoaF);
            }
            else if(indice == 1)
            {
                PessoaFisica pessoaF = this.ListaPf[e.RowIndex];
                this.ListaPf.Remove(pessoaF);
                MessageBox.Show("Removido com sucesso");
                ListarCadastro();
            }

        }

        
        private void LimparCadastro()
        {
            tbNome.Text = String.Empty;
            dtData.Text = String.Empty;
            tbCpf.Text = String.Empty;
            tbRg.Text = String.Empty;

            tbRua.Text = String.Empty;
            tbNumero.Text = String.Empty;
            tbComplemento.Text = String.Empty;
            tbBairro.Text = String.Empty;
            tbCidade.Text = String.Empty;
        }
        private void ListarCadastro()
        {
            dgCadPf.Rows.Clear();

            foreach (PessoaFisica pessoaF in ListaPf)
            {
                dgCadPf.Rows.Add("Editar", "Deletar", pessoaF.Id, pessoaF.Nome, pessoaF.Data.ToShortDateString(), pessoaF.CPF, pessoaF.RG, pessoaF.End.Rua, pessoaF.End.Numero, pessoaF.End.Complemento, pessoaF.End.Bairro, pessoaF.End.Cidade);
            }

            dgCadPf.Refresh();
        }
        private void CarregarCadastro(PessoaFisica pessoaF)
        {
            this.tbNome.Text = pessoaF.Nome;
            this.dtData.Text = pessoaF.Data.ToShortDateString();
            this.tbCpf.Text = pessoaF.CPF;
            this.tbRg.Text = pessoaF.RG;
            
            this.tbRua.Text = pessoaF.End.Rua;
            this.tbNumero.Text = pessoaF.End.Numero.ToString();
            this.tbComplemento.Text = pessoaF.End.Complemento;
            this.tbBairro.Text = pessoaF.End.Bairro;
            this.tbCidade.Text = pessoaF.End.Cidade;
        }
    }
}
