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
    public partial class PessoaJuridicaForm : Form
    {
        public List<PessoaJuridica> ListaPj { get; set; }
        public PessoaJuridicaForm()
        {
            InitializeComponent();
            ListaPj = new List<PessoaJuridica>();
            dgCadPf.AutoGenerateColumns = false;
            dgCadPf.AllowUserToAddRows = false;

            ListarCadastro();
        }

        int id = 1;
        int idEdicao = 0;
        private void btCadastrarPf_Click(object sender, EventArgs e)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            Endereco endereco = new Endereco();

            pessoaJuridica.Id = idEdicao;
            pessoaJuridica.Nome = tbNome.Text;
            pessoaJuridica.Data = Convert.ToDateTime(dtDataFundacao.Text);
            pessoaJuridica.CNPJ = tbCnpj.Text;
            pessoaJuridica.IE = tbIe.Text;

            endereco.Rua = tbRua.Text;
            endereco.Numero = Convert.ToInt32(tbNumero.Text);
            endereco.Complemento = tbComplemento.Text;
            endereco.Bairro = tbBairro.Text;
            endereco.Cidade = tbCidade.Text;

            pessoaJuridica.End = endereco;

            int indexId = ListaPj.FindIndex(x => x.Id == pessoaJuridica.Id);
            if (indexId == -1)
            {
                pessoaJuridica.Id = id;
                this.ListaPj.Add(pessoaJuridica);
                MessageBox.Show($"{pessoaJuridica.Nome} Cadastrado(a) com Sucesso!!!");
            }
            else
            {
                this.ListaPj[indexId] = pessoaJuridica;
                MessageBox.Show($"Cadastro {pessoaJuridica.Nome} Editado(a) com Sucesso!!!");
            }
            id++;

            ListarCadastro();

            LimparCadastro();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparCadastro();
        }
        private void LimparCadastro()
        {
            tbNome.Text = String.Empty;
            dtDataFundacao.Text = String.Empty;
            tbCnpj.Text = String.Empty;
            tbIe.Text = String.Empty;

            tbRua.Text = String.Empty;
            tbNumero.Text = String.Empty;
            tbComplemento.Text = String.Empty;
            tbBairro.Text = String.Empty;
            tbCidade.Text = String.Empty;
        }
        private void ListarCadastro()
        {
            dgCadPf.Rows.Clear();

            foreach (PessoaJuridica pessoaJ in ListaPj)
            {
                dgCadPf.Rows.Add("Editar", "Deletar", pessoaJ.Id, pessoaJ.Nome, pessoaJ.Data.ToShortDateString(), pessoaJ.CNPJ, pessoaJ.IE, pessoaJ.End.Rua, pessoaJ.End.Numero, pessoaJ.End.Complemento, pessoaJ.End.Bairro, pessoaJ.End.Cidade);
            }

            dgCadPf.Refresh();
        }
        private void dgCadPf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.ColumnIndex;

            if (indice == 0)
            {
                PessoaJuridica pessoaJ = this.ListaPj[e.RowIndex];
                idEdicao = pessoaJ.Id;
                CarregarCadastro(pessoaJ);
            }
            else if (indice == 1)
            {
                PessoaJuridica pessoaJ = this.ListaPj[e.RowIndex];
                this.ListaPj.Remove(pessoaJ);
                MessageBox.Show("Removido com sucesso");
                ListarCadastro();
            }
        }
        private void CarregarCadastro(PessoaJuridica pessoaJ)
        {
            this.tbNome.Text = pessoaJ.Nome;
            this.dtDataFundacao.Text = pessoaJ.Data.ToShortDateString();
            this.tbCnpj.Text = pessoaJ.CNPJ;
            this.tbIe.Text = pessoaJ.IE;

            this.tbRua.Text = pessoaJ.End.Rua;
            this.tbNumero.Text = pessoaJ.End.Numero.ToString();
            this.tbComplemento.Text = pessoaJ.End.Complemento;
            this.tbBairro.Text = pessoaJ.End.Bairro;
            this.tbCidade.Text = pessoaJ.End.Cidade;
        }
    }
}
