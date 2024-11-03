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
    }
}
