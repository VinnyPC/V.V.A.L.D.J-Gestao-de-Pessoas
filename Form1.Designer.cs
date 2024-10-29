namespace Gestão_de_Pessoas_V.V.A.L.D.J
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFuncionarios = new Label();
            lblFuncoes = new Label();
            lblFuncionariosQtd = new Label();
            lblFuncoesQtd = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            btnAdicionarFuncionario = new Button();
            btnExcluirFuncionario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblFuncionarios
            // 
            lblFuncionarios.AutoSize = true;
            lblFuncionarios.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionarios.Location = new Point(12, 40);
            lblFuncionarios.Name = "lblFuncionarios";
            lblFuncionarios.Size = new Size(207, 45);
            lblFuncionarios.TabIndex = 0;
            lblFuncionarios.Text = "Funcionários:";
            lblFuncionarios.Click += lblFuncionarios_Click;
            // 
            // lblFuncoes
            // 
            lblFuncoes.AutoSize = true;
            lblFuncoes.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncoes.Location = new Point(313, 40);
            lblFuncoes.Name = "lblFuncoes";
            lblFuncoes.Size = new Size(144, 45);
            lblFuncoes.TabIndex = 1;
            lblFuncoes.Text = "Funções:";
            lblFuncoes.Click += lblFuncoes_Click;
            // 
            // lblFuncionariosQtd
            // 
            lblFuncionariosQtd.BorderStyle = BorderStyle.FixedSingle;
            lblFuncionariosQtd.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionariosQtd.Location = new Point(225, 40);
            lblFuncionariosQtd.Name = "lblFuncionariosQtd";
            lblFuncionariosQtd.Size = new Size(59, 45);
            lblFuncionariosQtd.TabIndex = 2;
            lblFuncionariosQtd.Text = "00";
            lblFuncionariosQtd.TextAlign = ContentAlignment.MiddleCenter;
            lblFuncionariosQtd.Click += lblFuncionariosQtd_Click;
            // 
            // lblFuncoesQtd
            // 
            lblFuncoesQtd.BorderStyle = BorderStyle.FixedSingle;
            lblFuncoesQtd.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncoesQtd.Location = new Point(463, 40);
            lblFuncoesQtd.Name = "lblFuncoesQtd";
            lblFuncoesQtd.Size = new Size(59, 45);
            lblFuncoesQtd.TabIndex = 3;
            lblFuncoesQtd.Text = "00";
            lblFuncoesQtd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(12, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1240, 454);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Selecionar";
            Column1.Name = "Column1";
            // 
            // btnAdicionarFuncionario
            // 
            btnAdicionarFuncionario.Location = new Point(12, 124);
            btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            btnAdicionarFuncionario.Size = new Size(156, 47);
            btnAdicionarFuncionario.TabIndex = 5;
            btnAdicionarFuncionario.Text = "Adicionar Funcionario";
            btnAdicionarFuncionario.UseVisualStyleBackColor = true;
            btnAdicionarFuncionario.Click += btnAdicionarFuncionario_Click;
            // 
            // btnExcluirFuncionario
            // 
            btnExcluirFuncionario.Location = new Point(1159, 124);
            btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            btnExcluirFuncionario.Size = new Size(93, 47);
            btnExcluirFuncionario.TabIndex = 6;
            btnExcluirFuncionario.Text = "Excluir funcionario";
            btnExcluirFuncionario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnExcluirFuncionario);
            Controls.Add(btnAdicionarFuncionario);
            Controls.Add(dataGridView1);
            Controls.Add(lblFuncoesQtd);
            Controls.Add(lblFuncionariosQtd);
            Controls.Add(lblFuncoes);
            Controls.Add(lblFuncionarios);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncionarios;
        private Label lblFuncoes;
        private Label lblFuncionariosQtd;
        private Label lblFuncoesQtd;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Column1;
        private Button btnAdicionarFuncionario;
        private Button btnExcluirFuncionario;
    }
}
