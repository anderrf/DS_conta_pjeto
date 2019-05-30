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
    public partial class frmContasPagar : Form
    {
        public frmContasPagar()
        {
            InitializeComponent();
        }

        private void frmContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_contasDataSet.tb_contas_pagar' table. You can move, or remove it, as needed.
            this.tb_contas_pagarTableAdapter.Fill(this.db_contasDataSet.tb_contas_pagar);
            Desabilita();

        }

        private void Habilita()
        {
            txtNumero.Enabled = true;
            dtEmissao.Enabled = true;
            txtValorConta.Enabled = true;
            txtIdFornecedor.Enabled = true;
            dtVencimento.Enabled = true;
            dtPagamento.Enabled = true;
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
            txtNumero.Enabled = false;
            dtEmissao.Enabled = false;
            txtValorConta.Enabled = false;
            txtIdFornecedor.Enabled = false;
            dtVencimento.Enabled = false;
            dtPagamento.Enabled = false;
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
            tb_contas_pagarBindingSource.CancelEdit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_contas_pagarBindingSource.EndEdit();
            tb_contas_pagarTableAdapter.Update(db_contasDataSet.tb_contas_pagar);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.AddNew();
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
            tb_contas_pagarBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.MoveNext();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.RemoveCurrent();
            tb_contas_pagarTableAdapter.Update(db_contasDataSet.tb_contas_pagar);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "Ficha de conta a pagar" + (char)10 + (char)10;
            strDados = strDados + "Código: " + lblCodigo.Text + (char)10;
            strDados = strDados + "Número: " + txtNumero.Text + (char)10;
            strDados = strDados + "Emissão: " + dtEmissao.Text + (char)10;
            strDados = strDados + "Valor: " + txtValorConta.Text + (char)10;
            strDados = strDados + "Fornecedor: " + txtIdFornecedor.Text + (char)10;
            strDados = strDados + "Vencimento: " + dtVencimento.Text + (char)10;
            strDados = strDados + "Pagamento: " + dtPagamento.Text + (char)10;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }
    }
}
