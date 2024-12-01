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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblFuncionarios = new Label();
            btnAdicionarFuncionario = new Button();
            btnEditarFuncionario = new Button();
            btnExcluirFuncionario = new Button();
            dataGridView1 = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnRefresh = new Button();
            lblFuncionariosQtd = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFuncionarios
            // 
            lblFuncionarios.AutoSize = true;
            lblFuncionarios.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionarios.Location = new Point(15, 159);
            lblFuncionarios.Name = "lblFuncionarios";
            lblFuncionarios.Size = new Size(201, 40);
            lblFuncionarios.TabIndex = 0;
            lblFuncionarios.Text = "Funcionários:";
            lblFuncionarios.Click += lblFuncionarios_Click;
            // 
            // btnAdicionarFuncionario
            // 
            btnAdicionarFuncionario.BackColor = Color.FromArgb(127, 124, 249);
            btnAdicionarFuncionario.FlatAppearance.BorderColor = Color.FromArgb(105, 102, 227);
            btnAdicionarFuncionario.FlatAppearance.BorderSize = 2;
            btnAdicionarFuncionario.FlatStyle = FlatStyle.Flat;
            btnAdicionarFuncionario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarFuncionario.ForeColor = Color.White;
            btnAdicionarFuncionario.Image = (Image)resources.GetObject("btnAdicionarFuncionario.Image");
            btnAdicionarFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarFuncionario.Location = new Point(15, 221);
            btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            btnAdicionarFuncionario.Size = new Size(210, 61);
            btnAdicionarFuncionario.TabIndex = 5;
            btnAdicionarFuncionario.Text = "Adicionar Funcionário";
            btnAdicionarFuncionario.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarFuncionario.UseVisualStyleBackColor = false;
            btnAdicionarFuncionario.Click += btnAdicionarFuncionario_Click;
            // 
            // btnEditarFuncionario
            // 
            btnEditarFuncionario.BackColor = Color.FromArgb(127, 124, 249);
            btnEditarFuncionario.FlatAppearance.BorderColor = Color.FromArgb(105, 102, 227);
            btnEditarFuncionario.FlatAppearance.BorderSize = 2;
            btnEditarFuncionario.FlatStyle = FlatStyle.Flat;
            btnEditarFuncionario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarFuncionario.ForeColor = Color.White;
            btnEditarFuncionario.Image = (Image)resources.GetObject("btnEditarFuncionario.Image");
            btnEditarFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarFuncionario.Location = new Point(243, 221);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new Size(210, 61);
            btnEditarFuncionario.TabIndex = 8;
            btnEditarFuncionario.Text = "Editar funcionário";
            btnEditarFuncionario.TextAlign = ContentAlignment.MiddleRight;
            btnEditarFuncionario.UseVisualStyleBackColor = false;
            btnEditarFuncionario.Click += btnEditarFuncionario_Click;
            // 
            // btnExcluirFuncionario
            // 
            btnExcluirFuncionario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluirFuncionario.BackColor = Color.FromArgb(127, 124, 249);
            btnExcluirFuncionario.FlatAppearance.BorderColor = Color.FromArgb(105, 102, 227);
            btnExcluirFuncionario.FlatAppearance.BorderSize = 2;
            btnExcluirFuncionario.FlatStyle = FlatStyle.Flat;
            btnExcluirFuncionario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExcluirFuncionario.ForeColor = Color.White;
            btnExcluirFuncionario.Image = (Image)resources.GetObject("btnExcluirFuncionario.Image");
            btnExcluirFuncionario.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirFuncionario.Location = new Point(1042, 221);
            btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            btnExcluirFuncionario.Size = new Size(210, 61);
            btnExcluirFuncionario.TabIndex = 6;
            btnExcluirFuncionario.Text = "Excluir funcionário";
            btnExcluirFuncionario.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirFuncionario.UseVisualStyleBackColor = false;
            btnExcluirFuncionario.Click += btnExcluirFuncionario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1237, 307);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(498, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 319);
            label1.Name = "label1";
            label1.Size = new Size(111, 40);
            label1.TabIndex = 10;
            label1.Text = "Dados:";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.FromArgb(127, 124, 249);
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(105, 102, 227);
            btnRefresh.FlatAppearance.BorderSize = 2;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(1205, 299);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(47, 47);
            btnRefresh.TabIndex = 11;
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblFuncionariosQtd
            // 
            lblFuncionariosQtd.BorderStyle = BorderStyle.FixedSingle;
            lblFuncionariosQtd.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionariosQtd.Location = new Point(222, 154);
            lblFuncionariosQtd.Name = "lblFuncionariosQtd";
            lblFuncionariosQtd.Size = new Size(95, 45);
            lblFuncionariosQtd.TabIndex = 12;
            lblFuncionariosQtd.Text = "99";
            lblFuncionariosQtd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(lblFuncionariosQtd);
            Controls.Add(btnRefresh);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdicionarFuncionario);
            Controls.Add(btnEditarFuncionario);
            Controls.Add(btnExcluirFuncionario);
            Controls.Add(lblFuncionarios);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncionarios;
        private Button btnAdicionarFuncionario;
        private Button btnEditarFuncionario;
        private Button btnExcluirFuncionario;
        private DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnRefresh;
        private Label lblFuncionariosQtd;
    }
}
