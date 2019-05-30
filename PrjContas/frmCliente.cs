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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Habilita()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtCEP.Enabled = true;
            txtTelefone.Enabled = true;
            txtCPF.Enabled = true;
            txtRG.Enabled = true;
            txtCNPJ.Enabled = true;
            txtIE.Enabled = true;
            txtTipo.Enabled = true;
            txtEmail.Enabled = true;
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
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtCEP.Enabled = false;
            txtTelefone.Enabled = false;
            txtCPF.Enabled = false;
            txtRG.Enabled = false;
            txtCNPJ.Enabled = false;
            txtIE.Enabled = false;
            txtTipo.Enabled = false;
            txtEmail.Enabled = false;
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

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_contasDataSet1.tb_cliente' table. You can move, or remove it, as needed.
            this.tb_clienteTableAdapter.Fill(this.db_contasDataSet1.tb_cliente);
            Desabilita();
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
            tb_clienteTableAdapter.Update(db_contasDataSet1.tb_cliente);
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
            tb_clienteTableAdapter.Update(db_contasDataSet1.tb_cliente);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Ficha de cliente" + (char)10 + (char)10;
            strDados = strDados + "Código: " + lblCodigo.Text + (char)10;
            strDados = strDados + "Nome: " + txtNome.Text + (char)10;
            strDados = strDados + "Endereço: " + txtEndereco.Text + (char)10;
            strDados = strDados + "Número: " + txtNumero.Text + (char)10;
            strDados = strDados + "Bairro: " + txtBairro.Text + (char)10;
            strDados = strDados + "Cidade: " + txtCidade.Text + (char)10;
            strDados = strDados + "Estado: " + txtEstado.Text + (char)10;
            strDados = strDados + "CEP: " + txtCEP.Text + (char)10;
            strDados = strDados + "Telefone: " + txtTelefone.Text + (char)10;
            strDados = strDados + "CPF: " + txtCPF.Text + (char)10;
            strDados = strDados + "RG: " + txtRG.Text + (char)10;
            strDados = strDados + "CNPJ: " + txtCNPJ.Text + (char)10;
            strDados = strDados + "IE: " + txtIE.Text + (char)10;
            strDados = strDados + "Tipo: " + txtTipo.Text + (char)10;
            strDados = strDados + "E-mail: " + txtEmail.Text + (char)10;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }
    }
}
