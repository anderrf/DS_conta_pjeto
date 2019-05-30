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
    public partial class frmPesquisaUsuario : Form
    {
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_usuarioBindingSource.EndEdit();

        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_contasDataSet.tb_usuario' table. You can move, or remove it, as needed.
            this.tb_usuarioTableAdapter.Fill(this.db_contasDataSet.tb_usuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                tb_usuarioTableAdapter.Fill(db_contasDataSet.tb_usuario);
            }
            else
            {
                tb_usuarioTableAdapter.Fillnome(db_contasDataSet.tb_usuario, "%"+txtNome.Text+"%");
            }
        }
    }
}
