
namespace Forms1
{
    partial class PessoaJuridicaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtDataFundacao = new System.Windows.Forms.DateTimePicker();
            this.dgCadPf = new System.Windows.Forms.DataGridView();
            this.btEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbIe = new System.Windows.Forms.TextBox();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCnpj = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbIe = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.lbDataFundacao = new System.Windows.Forms.Label();
            this.lbPjCadastradas = new System.Windows.Forms.Label();
            this.lbCadPj = new System.Windows.Forms.Label();
            this.lbCadEnd = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrarPf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadPf)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDataFundacao
            // 
            this.dtDataFundacao.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dtDataFundacao.Location = new System.Drawing.Point(107, 130);
            this.dtDataFundacao.Name = "dtDataFundacao";
            this.dtDataFundacao.Size = new System.Drawing.Size(184, 20);
            this.dtDataFundacao.TabIndex = 29;
            // 
            // dgCadPf
            // 
            this.dgCadPf.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgCadPf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadPf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btEditar,
            this.btDeletar,
            this.clid,
            this.clNome,
            this.clData,
            this.clCnpj,
            this.clIE,
            this.clRua,
            this.clNumero,
            this.clComplemento,
            this.clBairro,
            this.clCidade});
            this.dgCadPf.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCadPf.Location = new System.Drawing.Point(297, 104);
            this.dgCadPf.Name = "dgCadPf";
            this.dgCadPf.Size = new System.Drawing.Size(635, 295);
            this.dgCadPf.TabIndex = 28;
            this.dgCadPf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCadPf_CellContentClick);
            // 
            // btEditar
            // 
            this.btEditar.HeaderText = "Editar";
            this.btEditar.MinimumWidth = 50;
            this.btEditar.Name = "btEditar";
            this.btEditar.Width = 50;
            // 
            // btDeletar
            // 
            this.btDeletar.HeaderText = "Deletar";
            this.btDeletar.MinimumWidth = 50;
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Width = 50;
            // 
            // clid
            // 
            this.clid.HeaderText = "ID";
            this.clid.Name = "clid";
            this.clid.Width = 30;
            // 
            // clNome
            // 
            this.clNome.HeaderText = "Nome";
            this.clNome.Name = "clNome";
            // 
            // clData
            // 
            this.clData.HeaderText = "Data";
            this.clData.Name = "clData";
            // 
            // clCnpj
            // 
            this.clCnpj.HeaderText = "CNPJ";
            this.clCnpj.Name = "clCnpj";
            // 
            // clIE
            // 
            this.clIE.HeaderText = "IE";
            this.clIE.Name = "clIE";
            // 
            // clRua
            // 
            this.clRua.HeaderText = "Rua";
            this.clRua.Name = "clRua";
            // 
            // clNumero
            // 
            this.clNumero.HeaderText = "Número";
            this.clNumero.Name = "clNumero";
            this.clNumero.Width = 50;
            // 
            // clComplemento
            // 
            this.clComplemento.HeaderText = "Complemento";
            this.clComplemento.Name = "clComplemento";
            // 
            // clBairro
            // 
            this.clBairro.HeaderText = "Bairro";
            this.clBairro.Name = "clBairro";
            // 
            // clCidade
            // 
            this.clCidade.HeaderText = "Cidade";
            this.clCidade.Name = "clCidade";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(107, 366);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(184, 20);
            this.tbCidade.TabIndex = 26;
            // 
            // tbIe
            // 
            this.tbIe.Location = new System.Drawing.Point(107, 181);
            this.tbIe.Name = "tbIe";
            this.tbIe.Size = new System.Drawing.Size(184, 20);
            this.tbIe.TabIndex = 25;
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(107, 315);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(184, 20);
            this.tbComplemento.TabIndex = 24;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(107, 340);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(184, 20);
            this.tbBairro.TabIndex = 23;
            // 
            // tbCnpj
            // 
            this.tbCnpj.Location = new System.Drawing.Point(107, 155);
            this.tbCnpj.Name = "tbCnpj";
            this.tbCnpj.Size = new System.Drawing.Size(184, 20);
            this.tbCnpj.TabIndex = 22;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(107, 289);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(184, 20);
            this.tbNumero.TabIndex = 21;
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(107, 264);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(184, 20);
            this.tbRua.TabIndex = 27;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(14, 369);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 16;
            this.lbCidade.Text = "Cidade";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(12, 318);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 17;
            this.lbComplemento.Text = "Complemento";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(107, 104);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(184, 20);
            this.tbNome.TabIndex = 20;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(12, 343);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 18;
            this.lbBairro.Text = "Bairro";
            // 
            // lbIe
            // 
            this.lbIe.AutoSize = true;
            this.lbIe.Location = new System.Drawing.Point(14, 184);
            this.lbIe.Name = "lbIe";
            this.lbIe.Size = new System.Drawing.Size(17, 13);
            this.lbIe.TabIndex = 19;
            this.lbIe.Text = "IE";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(12, 292);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 15;
            this.lbNumero.Text = "Número";
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(14, 158);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(34, 13);
            this.lbCnpj.TabIndex = 14;
            this.lbCnpj.Text = "CNPJ";
            // 
            // lbDataFundacao
            // 
            this.lbDataFundacao.AutoSize = true;
            this.lbDataFundacao.Location = new System.Drawing.Point(12, 136);
            this.lbDataFundacao.Name = "lbDataFundacao";
            this.lbDataFundacao.Size = new System.Drawing.Size(96, 13);
            this.lbDataFundacao.TabIndex = 13;
            this.lbDataFundacao.Text = "Data de Fundação";
            // 
            // lbPjCadastradas
            // 
            this.lbPjCadastradas.AutoSize = true;
            this.lbPjCadastradas.Location = new System.Drawing.Point(512, 66);
            this.lbPjCadastradas.Name = "lbPjCadastradas";
            this.lbPjCadastradas.Size = new System.Drawing.Size(155, 13);
            this.lbPjCadastradas.TabIndex = 12;
            this.lbPjCadastradas.Text = "Pessoas Jurídicas Cadastradas";
            // 
            // lbCadPj
            // 
            this.lbCadPj.AutoSize = true;
            this.lbCadPj.Location = new System.Drawing.Point(129, 66);
            this.lbCadPj.Name = "lbCadPj";
            this.lbCadPj.Size = new System.Drawing.Size(128, 13);
            this.lbCadPj.TabIndex = 11;
            this.lbCadPj.Text = "Cadastro Pessoa Jurídica";
            // 
            // lbCadEnd
            // 
            this.lbCadEnd.AutoSize = true;
            this.lbCadEnd.Location = new System.Drawing.Point(129, 224);
            this.lbCadEnd.Name = "lbCadEnd";
            this.lbCadEnd.Size = new System.Drawing.Size(113, 13);
            this.lbCadEnd.TabIndex = 10;
            this.lbCadEnd.Text = "Cadastro de Endereço";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(12, 267);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 9;
            this.lbRua.Text = "Rua";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(14, 107);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 8;
            this.lbNome.Text = "Nome";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(167, 415);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrarPf
            // 
            this.btCadastrarPf.Location = new System.Drawing.Point(75, 415);
            this.btCadastrarPf.Name = "btCadastrarPf";
            this.btCadastrarPf.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarPf.TabIndex = 6;
            this.btCadastrarPf.Text = "Cadastrar";
            this.btCadastrarPf.UseVisualStyleBackColor = true;
            this.btCadastrarPf.Click += new System.EventHandler(this.btCadastrarPf_Click);
            // 
            // PessoaJuridicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 504);
            this.Controls.Add(this.dtDataFundacao);
            this.Controls.Add(this.dgCadPf);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbIe);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbCnpj);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbIe);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.lbDataFundacao);
            this.Controls.Add(this.lbPjCadastradas);
            this.Controls.Add(this.lbCadPj);
            this.Controls.Add(this.lbCadEnd);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrarPf);
            this.Name = "PessoaJuridicaForm";
            this.Text = "PessoaJuridica";
            ((System.ComponentModel.ISupportInitialize)(this.dgCadPf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDataFundacao;
        private System.Windows.Forms.DataGridView dgCadPf;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbIe;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCnpj;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbIe;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.Label lbDataFundacao;
        private System.Windows.Forms.Label lbPjCadastradas;
        private System.Windows.Forms.Label lbCadPj;
        private System.Windows.Forms.Label lbCadEnd;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrarPf;
        private System.Windows.Forms.DataGridViewButtonColumn btEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCidade;
    }
}