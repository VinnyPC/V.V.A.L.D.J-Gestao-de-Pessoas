
namespace Gestão_de_Pessoas_V.V.A.L.D.J
{
    partial class FormAdicionarFuncionario
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
            lblAddFuncionariosTitle = new Label();
            lblAddFuncionarioNome = new Label();
            lblAddFuncionarioCpf = new Label();
            lblAddFuncionarioNascimento = new Label();
            lblAddFuncionarioEndereco = new Label();
            lblAddFuncionarioAdmissao = new Label();
            lblAddFuncionarioFuncao = new Label();
            lblAddFuncionarioQualificacao = new Label();
            lblAddFuncionarioSalarioInicial = new Label();
            txtAddFuncionarioNome = new TextBox();
            txtAddFuncionarioCpf = new TextBox();
            txtAddFuncionarioFuncao = new TextBox();
            dateAddFuncionarioAdmissao = new DateTimePicker();
            dtpAddFuncionarioNascimento = new DateTimePicker();
            txtAddFuncionarioEndereco = new TextBox();
            txtAddFuncionarioQualificacao = new TextBox();
            txtAddFuncionarioSalarioInicial = new TextBox();
            gbStatusFuncionario = new GroupBox();
            dtpAddFuncionarioDataDesligamentoAfastamento = new DateTimePicker();
            lblAddFuncionarioDataDesligamentoAfastamento = new Label();
            rbAddFuncionarioStatusAfastado = new RadioButton();
            rbAddFuncionarioStatusDesligado = new RadioButton();
            rbAddFuncionarioStatusAtivo = new RadioButton();
            gbDadosProfissionais = new GroupBox();
            gbDadosPessoais = new GroupBox();
            btnAddFuncionarioSalvar = new Button();
            gbStatusFuncionario.SuspendLayout();
            gbDadosProfissionais.SuspendLayout();
            gbDadosPessoais.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddFuncionariosTitle
            // 
            lblAddFuncionariosTitle.AutoSize = true;
            lblAddFuncionariosTitle.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddFuncionariosTitle.Location = new Point(40, 9);
            lblAddFuncionariosTitle.Name = "lblAddFuncionariosTitle";
            lblAddFuncionariosTitle.Size = new Size(565, 58);
            lblAddFuncionariosTitle.TabIndex = 1;
            lblAddFuncionariosTitle.Text = "Adicionar funcionários";
            lblAddFuncionariosTitle.Click += lblFuncionarios_Click;
            // 
            // lblAddFuncionarioNome
            // 
            lblAddFuncionarioNome.AutoSize = true;
            lblAddFuncionarioNome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioNome.Location = new Point(32, 42);
            lblAddFuncionarioNome.Name = "lblAddFuncionarioNome";
            lblAddFuncionarioNome.Size = new Size(75, 30);
            lblAddFuncionarioNome.TabIndex = 2;
            lblAddFuncionarioNome.Text = "Nome:";
            lblAddFuncionarioNome.Click += lblAddFuncionarioNome_Click;
            // 
            // lblAddFuncionarioCpf
            // 
            lblAddFuncionarioCpf.AutoSize = true;
            lblAddFuncionarioCpf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioCpf.Location = new Point(32, 83);
            lblAddFuncionarioCpf.Name = "lblAddFuncionarioCpf";
            lblAddFuncionarioCpf.Size = new Size(53, 30);
            lblAddFuncionarioCpf.TabIndex = 3;
            lblAddFuncionarioCpf.Text = "CPF:";
            lblAddFuncionarioCpf.Click += lblAddFuncionarioCpf_Click;
            // 
            // lblAddFuncionarioNascimento
            // 
            lblAddFuncionarioNascimento.AutoSize = true;
            lblAddFuncionarioNascimento.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioNascimento.Location = new Point(653, 42);
            lblAddFuncionarioNascimento.Name = "lblAddFuncionarioNascimento";
            lblAddFuncionarioNascimento.Size = new Size(204, 30);
            lblAddFuncionarioNascimento.TabIndex = 4;
            lblAddFuncionarioNascimento.Text = "Data de nascimento:";
            lblAddFuncionarioNascimento.Click += lblAddFuncionarioNascimento_Click;
            // 
            // lblAddFuncionarioEndereco
            // 
            lblAddFuncionarioEndereco.AutoSize = true;
            lblAddFuncionarioEndereco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioEndereco.Location = new Point(653, 83);
            lblAddFuncionarioEndereco.Name = "lblAddFuncionarioEndereco";
            lblAddFuncionarioEndereco.Size = new Size(104, 30);
            lblAddFuncionarioEndereco.TabIndex = 5;
            lblAddFuncionarioEndereco.Text = "Endereço:";
            lblAddFuncionarioEndereco.Click += lblAddFuncionarioEndereco_Click;
            // 
            // lblAddFuncionarioAdmissao
            // 
            lblAddFuncionarioAdmissao.AutoSize = true;
            lblAddFuncionarioAdmissao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioAdmissao.Location = new Point(32, 35);
            lblAddFuncionarioAdmissao.Name = "lblAddFuncionarioAdmissao";
            lblAddFuncionarioAdmissao.Size = new Size(184, 30);
            lblAddFuncionarioAdmissao.TabIndex = 6;
            lblAddFuncionarioAdmissao.Text = "Data de admissão:";
            // 
            // lblAddFuncionarioFuncao
            // 
            lblAddFuncionarioFuncao.AutoSize = true;
            lblAddFuncionarioFuncao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioFuncao.Location = new Point(32, 87);
            lblAddFuncionarioFuncao.Name = "lblAddFuncionarioFuncao";
            lblAddFuncionarioFuncao.Size = new Size(85, 30);
            lblAddFuncionarioFuncao.TabIndex = 7;
            lblAddFuncionarioFuncao.Text = "Função:";
            // 
            // lblAddFuncionarioQualificacao
            // 
            lblAddFuncionarioQualificacao.AutoSize = true;
            lblAddFuncionarioQualificacao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioQualificacao.Location = new Point(653, 42);
            lblAddFuncionarioQualificacao.Name = "lblAddFuncionarioQualificacao";
            lblAddFuncionarioQualificacao.Size = new Size(133, 30);
            lblAddFuncionarioQualificacao.TabIndex = 8;
            lblAddFuncionarioQualificacao.Text = "Qualificação:";
            // 
            // lblAddFuncionarioSalarioInicial
            // 
            lblAddFuncionarioSalarioInicial.AutoSize = true;
            lblAddFuncionarioSalarioInicial.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioSalarioInicial.Location = new Point(653, 87);
            lblAddFuncionarioSalarioInicial.Name = "lblAddFuncionarioSalarioInicial";
            lblAddFuncionarioSalarioInicial.Size = new Size(140, 30);
            lblAddFuncionarioSalarioInicial.TabIndex = 9;
            lblAddFuncionarioSalarioInicial.Text = "Salário Inicial:";
            // 
            // txtAddFuncionarioNome
            // 
            txtAddFuncionarioNome.Location = new Point(113, 49);
            txtAddFuncionarioNome.Name = "txtAddFuncionarioNome";
            txtAddFuncionarioNome.Size = new Size(448, 23);
            txtAddFuncionarioNome.TabIndex = 10;
            txtAddFuncionarioNome.TextChanged += txtAddFuncionarioNome_TextChanged;
            // 
            // txtAddFuncionarioCpf
            // 
            txtAddFuncionarioCpf.Location = new Point(91, 90);
            txtAddFuncionarioCpf.Name = "txtAddFuncionarioCpf";
            txtAddFuncionarioCpf.Size = new Size(470, 23);
            txtAddFuncionarioCpf.TabIndex = 11;
            txtAddFuncionarioCpf.TextChanged += txtAddFuncionarioCpf_TextChanged;
            // 
            // txtAddFuncionarioFuncao
            // 
            txtAddFuncionarioFuncao.Location = new Point(123, 94);
            txtAddFuncionarioFuncao.Name = "txtAddFuncionarioFuncao";
            txtAddFuncionarioFuncao.Size = new Size(438, 23);
            txtAddFuncionarioFuncao.TabIndex = 13;
            // 
            // dateAddFuncionarioAdmissao
            // 
            dateAddFuncionarioAdmissao.Location = new Point(222, 41);
            dateAddFuncionarioAdmissao.Name = "dateAddFuncionarioAdmissao";
            dateAddFuncionarioAdmissao.Size = new Size(200, 23);
            dateAddFuncionarioAdmissao.TabIndex = 15;
            // 
            // dtpAddFuncionarioNascimento
            // 
            dtpAddFuncionarioNascimento.Location = new Point(863, 49);
            dtpAddFuncionarioNascimento.Name = "dtpAddFuncionarioNascimento";
            dtpAddFuncionarioNascimento.Size = new Size(269, 23);
            dtpAddFuncionarioNascimento.TabIndex = 16;
            dtpAddFuncionarioNascimento.ValueChanged += dateAddFuncionarioNascimento_ValueChanged;
            // 
            // txtAddFuncionarioEndereco
            // 
            txtAddFuncionarioEndereco.Location = new Point(763, 90);
            txtAddFuncionarioEndereco.Name = "txtAddFuncionarioEndereco";
            txtAddFuncionarioEndereco.Size = new Size(369, 23);
            txtAddFuncionarioEndereco.TabIndex = 17;
            txtAddFuncionarioEndereco.TextChanged += txtAddFuncionarioEndereco_TextChanged;
            // 
            // txtAddFuncionarioQualificacao
            // 
            txtAddFuncionarioQualificacao.Location = new Point(792, 49);
            txtAddFuncionarioQualificacao.Name = "txtAddFuncionarioQualificacao";
            txtAddFuncionarioQualificacao.Size = new Size(340, 23);
            txtAddFuncionarioQualificacao.TabIndex = 18;
            // 
            // txtAddFuncionarioSalarioInicial
            // 
            txtAddFuncionarioSalarioInicial.Location = new Point(799, 94);
            txtAddFuncionarioSalarioInicial.Name = "txtAddFuncionarioSalarioInicial";
            txtAddFuncionarioSalarioInicial.Size = new Size(333, 23);
            txtAddFuncionarioSalarioInicial.TabIndex = 19;
            // 
            // gbStatusFuncionario
            // 
            gbStatusFuncionario.Controls.Add(dtpAddFuncionarioDataDesligamentoAfastamento);
            gbStatusFuncionario.Controls.Add(lblAddFuncionarioDataDesligamentoAfastamento);
            gbStatusFuncionario.Controls.Add(rbAddFuncionarioStatusAfastado);
            gbStatusFuncionario.Controls.Add(rbAddFuncionarioStatusDesligado);
            gbStatusFuncionario.Controls.Add(rbAddFuncionarioStatusAtivo);
            gbStatusFuncionario.Location = new Point(40, 390);
            gbStatusFuncionario.Name = "gbStatusFuncionario";
            gbStatusFuncionario.Size = new Size(1169, 189);
            gbStatusFuncionario.TabIndex = 24;
            gbStatusFuncionario.TabStop = false;
            gbStatusFuncionario.Text = "Status do funcionário";
            // 
            // dtpAddFuncionarioDataDesligamentoAfastamento
            // 
            dtpAddFuncionarioDataDesligamentoAfastamento.Location = new Point(800, 88);
            dtpAddFuncionarioDataDesligamentoAfastamento.Name = "dtpAddFuncionarioDataDesligamentoAfastamento";
            dtpAddFuncionarioDataDesligamentoAfastamento.Size = new Size(200, 23);
            dtpAddFuncionarioDataDesligamentoAfastamento.TabIndex = 4;
            dtpAddFuncionarioDataDesligamentoAfastamento.Visible = false;
            // 
            // lblAddFuncionarioDataDesligamentoAfastamento
            // 
            lblAddFuncionarioDataDesligamentoAfastamento.AutoSize = true;
            lblAddFuncionarioDataDesligamentoAfastamento.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddFuncionarioDataDesligamentoAfastamento.Location = new Point(448, 82);
            lblAddFuncionarioDataDesligamentoAfastamento.Name = "lblAddFuncionarioDataDesligamentoAfastamento";
            lblAddFuncionarioDataDesligamentoAfastamento.Size = new Size(346, 30);
            lblAddFuncionarioDataDesligamentoAfastamento.TabIndex = 3;
            lblAddFuncionarioDataDesligamentoAfastamento.Text = "Data de desligamento/afastamento:";
            lblAddFuncionarioDataDesligamentoAfastamento.Visible = false;
            // 
            // rbAddFuncionarioStatusAfastado
            // 
            rbAddFuncionarioStatusAfastado.AutoSize = true;
            rbAddFuncionarioStatusAfastado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAddFuncionarioStatusAfastado.Location = new Point(16, 131);
            rbAddFuncionarioStatusAfastado.Name = "rbAddFuncionarioStatusAfastado";
            rbAddFuncionarioStatusAfastado.Size = new Size(114, 34);
            rbAddFuncionarioStatusAfastado.TabIndex = 2;
            rbAddFuncionarioStatusAfastado.TabStop = true;
            rbAddFuncionarioStatusAfastado.Text = "Afastado";
            rbAddFuncionarioStatusAfastado.UseVisualStyleBackColor = true;
            rbAddFuncionarioStatusAfastado.CheckedChanged += rbAddFuncionarioStatusAfastado_CheckedChanged;
            // 
            // rbAddFuncionarioStatusDesligado
            // 
            rbAddFuncionarioStatusDesligado.AutoSize = true;
            rbAddFuncionarioStatusDesligado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAddFuncionarioStatusDesligado.Location = new Point(16, 78);
            rbAddFuncionarioStatusDesligado.Name = "rbAddFuncionarioStatusDesligado";
            rbAddFuncionarioStatusDesligado.Size = new Size(123, 34);
            rbAddFuncionarioStatusDesligado.TabIndex = 1;
            rbAddFuncionarioStatusDesligado.TabStop = true;
            rbAddFuncionarioStatusDesligado.Text = "Desligado";
            rbAddFuncionarioStatusDesligado.UseVisualStyleBackColor = true;
            rbAddFuncionarioStatusDesligado.CheckedChanged += rbAddFuncionarioStatusDesligado_CheckedChanged;
            // 
            // rbAddFuncionarioStatusAtivo
            // 
            rbAddFuncionarioStatusAtivo.AutoSize = true;
            rbAddFuncionarioStatusAtivo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAddFuncionarioStatusAtivo.Location = new Point(16, 31);
            rbAddFuncionarioStatusAtivo.Name = "rbAddFuncionarioStatusAtivo";
            rbAddFuncionarioStatusAtivo.Size = new Size(79, 34);
            rbAddFuncionarioStatusAtivo.TabIndex = 0;
            rbAddFuncionarioStatusAtivo.TabStop = true;
            rbAddFuncionarioStatusAtivo.Text = "Ativo";
            rbAddFuncionarioStatusAtivo.UseVisualStyleBackColor = true;
            rbAddFuncionarioStatusAtivo.CheckedChanged += rbAddFuncionarioStatusAtivo_CheckedChanged;
            // 
            // gbDadosProfissionais
            // 
            gbDadosProfissionais.Controls.Add(lblAddFuncionarioAdmissao);
            gbDadosProfissionais.Controls.Add(lblAddFuncionarioFuncao);
            gbDadosProfissionais.Controls.Add(lblAddFuncionarioQualificacao);
            gbDadosProfissionais.Controls.Add(txtAddFuncionarioSalarioInicial);
            gbDadosProfissionais.Controls.Add(lblAddFuncionarioSalarioInicial);
            gbDadosProfissionais.Controls.Add(txtAddFuncionarioQualificacao);
            gbDadosProfissionais.Controls.Add(txtAddFuncionarioFuncao);
            gbDadosProfissionais.Controls.Add(dateAddFuncionarioAdmissao);
            gbDadosProfissionais.Location = new Point(40, 237);
            gbDadosProfissionais.Name = "gbDadosProfissionais";
            gbDadosProfissionais.Size = new Size(1169, 147);
            gbDadosProfissionais.TabIndex = 25;
            gbDadosProfissionais.TabStop = false;
            gbDadosProfissionais.Text = "Dados profissionais";
            // 
            // gbDadosPessoais
            // 
            gbDadosPessoais.Controls.Add(lblAddFuncionarioNome);
            gbDadosPessoais.Controls.Add(lblAddFuncionarioCpf);
            gbDadosPessoais.Controls.Add(txtAddFuncionarioEndereco);
            gbDadosPessoais.Controls.Add(lblAddFuncionarioEndereco);
            gbDadosPessoais.Controls.Add(dtpAddFuncionarioNascimento);
            gbDadosPessoais.Controls.Add(lblAddFuncionarioNascimento);
            gbDadosPessoais.Controls.Add(txtAddFuncionarioCpf);
            gbDadosPessoais.Controls.Add(txtAddFuncionarioNome);
            gbDadosPessoais.Location = new Point(40, 84);
            gbDadosPessoais.Name = "gbDadosPessoais";
            gbDadosPessoais.Size = new Size(1169, 147);
            gbDadosPessoais.TabIndex = 20;
            gbDadosPessoais.TabStop = false;
            gbDadosPessoais.Text = "Dados pessoais";
            gbDadosPessoais.Enter += gbDadosPessoais_Enter;
            // 
            // btnAddFuncionarioSalvar
            // 
            btnAddFuncionarioSalvar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFuncionarioSalvar.Location = new Point(1044, 597);
            btnAddFuncionarioSalvar.Name = "btnAddFuncionarioSalvar";
            btnAddFuncionarioSalvar.Size = new Size(165, 66);
            btnAddFuncionarioSalvar.TabIndex = 26;
            btnAddFuncionarioSalvar.Text = "Salvar";
            btnAddFuncionarioSalvar.UseVisualStyleBackColor = true;
            // 
            // FormAdicionarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnAddFuncionarioSalvar);
            Controls.Add(gbDadosPessoais);
            Controls.Add(gbDadosProfissionais);
            Controls.Add(gbStatusFuncionario);
            Controls.Add(lblAddFuncionariosTitle);
            Name = "FormAdicionarFuncionario";
            Text = "FormAdicionarFuncionario";
            Load += FormAdicionarFuncionario_Load;
            gbStatusFuncionario.ResumeLayout(false);
            gbStatusFuncionario.PerformLayout();
            gbDadosProfissionais.ResumeLayout(false);
            gbDadosProfissionais.PerformLayout();
            gbDadosPessoais.ResumeLayout(false);
            gbDadosPessoais.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormAdicionarFuncionario_Load(object sender, EventArgs e)
        {

            rbAddFuncionarioStatusAtivo.Checked = true; 

            txtAddFuncionarioNome.Clear();
            txtAddFuncionarioCpf.Clear();
            txtAddFuncionarioEndereco.Clear();
            txtAddFuncionarioFuncao.Clear();
            txtAddFuncionarioSalarioInicial.Clear();
            dtpAddFuncionarioNascimento.Value = DateTime.Now; // Define a data de nascimento como hoje
        }

        private void gbDadosPessoais_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtAddFuncionarioEndereco_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateAddFuncionarioNascimento_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAddFuncionarioCpf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAddFuncionarioNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblAddFuncionarioEndereco_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAddFuncionarioCpf_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label lblAddFuncionariosTitle;
        private Label lblAddFuncionarioNome;
        private Label lblAddFuncionarioCpf;
        private Label lblAddFuncionarioNascimento;
        private Label lblAddFuncionarioEndereco;
        private Label lblAddFuncionarioAdmissao;
        private Label lblAddFuncionarioFuncao;
        private Label lblAddFuncionarioQualificacao;
        private Label lblAddFuncionarioSalarioInicial;
        private TextBox txtAddFuncionarioNome;
        private TextBox txtAddFuncionarioCpf;
        private TextBox txtAddFuncionarioFuncao;
        private DateTimePicker dateAddFuncionarioAdmissao;
        private DateTimePicker dtpAddFuncionarioNascimento;
        private TextBox txtAddFuncionarioEndereco;
        private TextBox txtAddFuncionarioQualificacao;
        private TextBox txtAddFuncionarioSalarioInicial;
        private GroupBox gbStatusFuncionario;
        private Label lblAddFuncionarioDataDesligamentoAfastamento;
        private RadioButton rbAddFuncionarioStatusAfastado;
        private RadioButton rbAddFuncionarioStatusDesligado;
        private RadioButton rbAddFuncionarioStatusAtivo;
        private DateTimePicker dtpAddFuncionarioDataDesligamentoAfastamento;
        private GroupBox gbDadosProfissionais;
        private GroupBox gbDadosPessoais;
        private Button btnAddFuncionarioSalvar;
    }
}