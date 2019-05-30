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
    public partial class RelatorioContasReceber : Form
    {
        public RelatorioContasReceber()
        {
            InitializeComponent();
        }

        private void RelatorioContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_contasDataSet1.tb_contas_receber' table. You can move, or remove it, as needed.
            this.tb_contas_receberTableAdapter.Fill(this.db_contasDataSet1.tb_contas_receber);

            this.reportViewer1.RefreshReport();
        }
    }
}
