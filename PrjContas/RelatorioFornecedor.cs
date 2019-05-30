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
    public partial class RelatorioFornecedor : Form
    {
        public RelatorioFornecedor()
        {
            InitializeComponent();
        }

        private void RelatorioFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_contasDataSet1.tb_fornecedor' table. You can move, or remove it, as needed.
            this.tb_fornecedorTableAdapter.Fill(this.db_contasDataSet1.tb_fornecedor);

            this.reportViewer1.RefreshReport();
        }

    }
        
}
