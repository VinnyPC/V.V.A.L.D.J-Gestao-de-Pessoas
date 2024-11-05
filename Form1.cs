namespace Gestão_de_Pessoas_V.V.A.L.D.J;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

public partial class Form1 : Form
{
    private MySqlConnection connection;
    private string connectionString = "Server=localhost;Database=VVALDJ;User ID=root;Password=root;";
    public Form1()
    {
        InitializeComponent();
        CarregarFuncionarios();
        ContarFuncionarios();
    }

    private void CarregarFuncionarios()
    {
        // se a conexao for nula ou estiver fechada ele abre a conexao
        if (connection == null || connection.State == ConnectionState.Closed)
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        MySqlCommand command = new MySqlCommand("SELECT * FROM Funcionarios", connection);
        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);

        dataGridView1.DataSource = dataTable;
        dataGridView1.Columns["Id"].Visible = false;
    }

    //função que faz uma count no banco de dados e mostra no lbl quantos registros tem
    private void ContarFuncionarios()
    {
        try
        {
            // se a conexao for nula ou estiver fechada ele abre a conexao
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }

            using (var command = new MySqlCommand("SELECT COUNT(*) FROM Funcionarios", connection))
            {
                int quantidadeFuncionarios = Convert.ToInt32(command.ExecuteScalar());
                lblFuncionariosQtd.Text = quantidadeFuncionarios.ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao contar funcionários: " + ex.Message);
        }
    }

    private void lblFuncionarios_Click(object sender, EventArgs e)
    {

    }

    private void lblFuncionariosQtd_Click(object sender, EventArgs e)
    {

    }

    private void lblFuncoes_Click(object sender, EventArgs e)
    {

    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
    {
        using (FormAdicionarFuncionario formAdicionar = new FormAdicionarFuncionario())
        {
            formAdicionar.ShowDialog();
        }
    }

    private void btnExcluirFuncionario_Click(object sender, EventArgs e)
    {
        // Verifica se há alguma linha selecionada no DataGridView
        if (dataGridView1.SelectedRows.Count > 0)
        {
            // Confirmação de exclusão
            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir os funcionários selecionados?",
                                                "Confirmação de Exclusão", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        // Obtém o valor do ID da linha selecionada
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        MySqlCommand command = new MySqlCommand("DELETE FROM Funcionarios WHERE Id = @Id", connection);
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();

                        // Remove a linha do DataGridView após exclusão no banco
                        dataGridView1.Rows.Remove(row);
                    }
                }
                MessageBox.Show("Funcionários excluídos com sucesso.");
            }
        }
        else
        {
            MessageBox.Show("Selecione pelo menos um funcionário para excluir.");
        }
    }

    private void btnEditarFuncionario_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            int funcionarioId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            //MessageBox.Show("FuncionarioId:", funcionarioId.ToString());
            FormEditarFuncionario formEditar = new FormEditarFuncionario(funcionarioId);
            formEditar.Show();
        }
        else
        {
            MessageBox.Show("Selecione um funcionário para editar.");
        }
    }
}
