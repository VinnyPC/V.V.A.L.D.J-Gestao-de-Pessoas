using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Pessoas_V.V.A.L.D.J

{
    public partial class FormAdicionarFuncionario : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=VVALDJ;User ID=root;Password=root;";

        public FormAdicionarFuncionario()
        {
            InitializeComponent();
            rbAddFuncionarioStatusAtivo.CheckedChanged += RadioButton_CheckedChanged;
            rbAddFuncionarioStatusDesligado.CheckedChanged += RadioButton_CheckedChanged;
            rbAddFuncionarioStatusAfastado.CheckedChanged += RadioButton_CheckedChanged;


        }


        private void lblFuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void lblAddFuncionarioNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lblAddFuncionarioNome_Click(object sender, EventArgs e)
        {

        }

        private void rbAddFuncionarioStatusAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAddFuncionarioStatusDesligado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAddFuncionarioStatusAfastado_CheckedChanged(object sender, EventArgs e)
        {

        }
        //método para que apareça a data de desligamento/afatastamento apenas se o checkbox estiver marcado
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAddFuncionarioStatusDesligado.Checked || rbAddFuncionarioStatusAfastado.Checked)
            {
                lblAddFuncionarioDataDesligamentoAfastamento.Visible = true;
                dtpAddFuncionarioDataDesligamentoAfastamento.Visible = true;
            }
            else
            {
                lblAddFuncionarioDataDesligamentoAfastamento.Visible = false;
                dtpAddFuncionarioDataDesligamentoAfastamento.Visible = false;
            }
        }

        private void btnAddFuncionarioSalvar_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }

            try
            {
                var funcionarioNome = txtAddFuncionarioNome.Text; 
                var cpfFuncionario = txtAddFuncionarioCpf.Text;   
                var Nascimento = dtpAddFuncionarioNascimento.Value; 
                var endereco = txtAddFuncionarioEndereco.Text;   
                var Admissao = dateAddFuncionarioAdmissao.Value; 
                var funcao = txtAddFuncionarioFuncao.Text;  
                var qualificacao = txtAddFuncionarioQualificacao.Text; 
                var salarioInicial = Convert.ToDecimal(txtAddFuncionarioSalarioInicial.Text);  
                var situacao = "";


                if (rbAddFuncionarioStatusAfastado.Checked)
                {
                    situacao = "Afastado";
                }
                else if (rbAddFuncionarioStatusAtivo.Checked)
                {
                    situacao = "Ativo";
                }
                else if (rbAddFuncionarioStatusDesligado.Checked)
                {
                    situacao = "Desligado";
                }

                var dataDesligamentoAfastamento = dtpAddFuncionarioDataDesligamentoAfastamento.Visible ?
                                                  dtpAddFuncionarioDataDesligamentoAfastamento.Value :
                                                  (DateTime?)null;  

                string query = @"INSERT INTO Funcionarios (Nome, CPF, Nascimento, Endereco, Admissao, Funcao, Qualificacao, SalarioInicial, Situacao, Desligamento) 
                         VALUES (@Nome, @CPF, @Nascimento, @Endereco, @Admissao, @Funcao, @Qualificacao, @SalarioInicial, @Situacao, @Desligamento)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", funcionarioNome);
                    command.Parameters.AddWithValue("@CPF", cpfFuncionario);
                    command.Parameters.AddWithValue("@Nascimento", Nascimento);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Admissao", Admissao);
                    command.Parameters.AddWithValue("@Funcao", funcao);
                    command.Parameters.AddWithValue("@Qualificacao", qualificacao);
                    command.Parameters.AddWithValue("@SalarioInicial", salarioInicial);
                    command.Parameters.AddWithValue("@Situacao", situacao);
                    command.Parameters.AddWithValue("@Desligamento",
                        (object)dataDesligamentoAfastamento ?? DBNull.Value);  

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
