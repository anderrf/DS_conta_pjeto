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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            this.Hide();
            fu.ShowDialog();
            this.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor ff = new frmFornecedor();
            this.Hide();
            ff.ShowDialog();
            this.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasPagar fcp = new frmContasPagar();
            this.Hide();
            fcp.ShowDialog();
            this.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasReceber fcr = new frmContasReceber();
            this.Hide();
            fcr.ShowDialog();
            this.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioCliente rc = new RelatorioCliente();
            this.Hide();
            rc.ShowDialog();
            this.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioUsuario ru = new RelatorioUsuario();
            this.Hide();
            ru.ShowDialog();
            this.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioFornecedor rf = new RelatorioFornecedor();
            this.Hide();
            rf.ShowDialog();
            this.Show();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioContasPagar rcp = new RelatorioContasPagar();
            this.Hide();
            rcp.ShowDialog();
            this.Show();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioContasReceber rcr = new RelatorioContasReceber();
            this.Hide();
            rcr.ShowDialog();
            this.Show();
        }
    }
}
