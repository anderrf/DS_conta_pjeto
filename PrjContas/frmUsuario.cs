using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjContas
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_contasDataSet1.tb_usuario' table. You can move, or remove it, as needed.
            this.tb_usuarioTableAdapter.Fill(this.db_contasDataSet1.tb_usuario);
            Desabilita();

        }

        private void Habilita()
        {
            txtNome.Enabled = true;
            txtNivel.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }

        private void Desabilita()
        {
            txtNome.Enabled = false;
            txtNivel.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            bindingSource1.CancelEdit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            bindingSource1.EndEdit();
            tb_usuarioTableAdapter.Update(db_contasDataSet1.tb_usuario);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            tb_usuarioTableAdapter.Update(db_contasDataSet1.tb_usuario);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            this.Hide();
            fpu.ShowDialog();
            this.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Ficha de usuário" + (char)10 + (char)10;
            strDados = strDados + "Código: " + lblCodigo.Text + (char)10;
            strDados = strDados + "Nome: " + txtNome.Text + (char)10;
            strDados = strDados + "Nível: " + txtNivel.Text + (char)10;
            strDados = strDados + "Login: " + txtLogin.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }
    }
}
