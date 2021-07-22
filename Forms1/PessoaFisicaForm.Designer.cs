
namespace Forms1
{
    partial class PessoaFisicaForm
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
            this.btCadastrarPf = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbRg = new System.Windows.Forms.TextBox();
            this.lbCadPf = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbCadEnd = new System.Windows.Forms.Label();
            this.dgCadPf = new System.Windows.Forms.DataGridView();
            this.lbPfCadastradas = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.btEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadPf)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrarPf
            // 
            this.btCadastrarPf.Location = new System.Drawing.Point(63, 385);
            this.btCadastrarPf.Name = "btCadastrarPf";
            this.btCadastrarPf.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarPf.TabIndex = 0;
            this.btCadastrarPf.Text = "Cadastrar";
            this.btCadastrarPf.UseVisualStyleBackColor = true;
            this.btCadastrarPf.Click += new System.EventHandler(this.btCadastrarPf_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(155, 385);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(25, 77);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(27, 102);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(25, 128);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(27, 154);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(23, 13);
            this.lbRg.TabIndex = 2;
            this.lbRg.Text = "RG";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(95, 74);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(184, 20);
            this.tbNome.TabIndex = 3;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(95, 125);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(184, 20);
            this.tbCpf.TabIndex = 3;
            // 
            // tbRg
            // 
            this.tbRg.Location = new System.Drawing.Point(95, 151);
            this.tbRg.Name = "tbRg";
            this.tbRg.Size = new System.Drawing.Size(184, 20);
            this.tbRg.TabIndex = 3;
            // 
            // lbCadPf
            // 
            this.lbCadPf.AutoSize = true;
            this.lbCadPf.Location = new System.Drawing.Point(117, 36);
            this.lbCadPf.Name = "lbCadPf";
            this.lbCadPf.Size = new System.Drawing.Size(119, 13);
            this.lbCadPf.TabIndex = 2;
            this.lbCadPf.Text = "Cadastro Pessoa Física";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(25, 237);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(27, 13);
            this.lbRua.TabIndex = 2;
            this.lbRua.Text = "Rua";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(25, 262);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 2;
            this.lbNumero.Text = "Número";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(25, 313);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 2;
            this.lbBairro.Text = "Bairro";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(27, 339);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(40, 13);
            this.lbCidade.TabIndex = 2;
            this.lbCidade.Text = "Cidade";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(95, 234);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(184, 20);
            this.tbRua.TabIndex = 3;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(95, 259);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(184, 20);
            this.tbNumero.TabIndex = 3;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(95, 310);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(184, 20);
            this.tbBairro.TabIndex = 3;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(95, 336);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(184, 20);
            this.tbCidade.TabIndex = 3;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(25, 288);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 2;
            this.lbComplemento.Text = "Complemento";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(95, 285);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(184, 20);
            this.tbComplemento.TabIndex = 3;
            // 
            // lbCadEnd
            // 
            this.lbCadEnd.AutoSize = true;
            this.lbCadEnd.Location = new System.Drawing.Point(117, 194);
            this.lbCadEnd.Name = "lbCadEnd";
            this.lbCadEnd.Size = new System.Drawing.Size(113, 13);
            this.lbCadEnd.TabIndex = 2;
            this.lbCadEnd.Text = "Cadastro de Endereço";
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
            this.clCpf,
            this.clRg,
            this.clRua,
            this.clNumero,
            this.clComplemento,
            this.clBairro,
            this.clCidade});
            this.dgCadPf.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgCadPf.Location = new System.Drawing.Point(285, 74);
            this.dgCadPf.Name = "dgCadPf";
            this.dgCadPf.Size = new System.Drawing.Size(635, 295);
            this.dgCadPf.TabIndex = 4;
            this.dgCadPf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCadPf_CellContentClick);
            // 
            // lbPfCadastradas
            // 
            this.lbPfCadastradas.AutoSize = true;
            this.lbPfCadastradas.Location = new System.Drawing.Point(500, 36);
            this.lbPfCadastradas.Name = "lbPfCadastradas";
            this.lbPfCadastradas.Size = new System.Drawing.Size(146, 13);
            this.lbPfCadastradas.TabIndex = 2;
            this.lbPfCadastradas.Text = "Pessoas Físicas Cadastradas";
            // 
            // dtData
            // 
            this.dtData.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dtData.Location = new System.Drawing.Point(95, 100);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(184, 20);
            this.dtData.TabIndex = 5;
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
            // clCpf
            // 
            this.clCpf.HeaderText = "CPF";
            this.clCpf.Name = "clCpf";
            // 
            // clRg
            // 
            this.clRg.HeaderText = "RG";
            this.clRg.Name = "clRg";
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
            // PessoaFisicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.dgCadPf);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbRg);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbPfCadastradas);
            this.Controls.Add(this.lbCadPf);
            this.Controls.Add(this.lbCadEnd);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrarPf);
            this.Name = "PessoaFisicaForm";
            this.Text = "PessoaFisicaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgCadPf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarPf;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbRg;
        private System.Windows.Forms.Label lbCadPf;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbCadEnd;
        private System.Windows.Forms.DataGridView dgCadPf;
        private System.Windows.Forms.Label lbPfCadastradas;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.DataGridViewButtonColumn btEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCidade;
    }
}