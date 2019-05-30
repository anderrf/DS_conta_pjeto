namespace PrjContas
{
    partial class RelatorioFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFornecedor));
            this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_contasDataSet1 = new PrjContas.db_contasDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_fornecedorTableAdapter = new PrjContas.db_contasDataSet1TableAdapters.tb_fornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_contasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_fornecedorBindingSource
            // 
            this.tb_fornecedorBindingSource.DataMember = "tb_fornecedor";
            this.tb_fornecedorBindingSource.DataSource = this.db_contasDataSet1;
            // 
            // db_contasDataSet1
            // 
            this.db_contasDataSet1.DataSetName = "db_contasDataSet1";
            this.db_contasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_fornecedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PrjContas.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1168, 549);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1192, 573);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioFornecedor";
            this.Text = "Relatório de fornecedor";
            this.Load += new System.EventHandler(this.RelatorioFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_contasDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
        private db_contasDataSet1 db_contasDataSet1;
        private db_contasDataSet1TableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
    }
}