namespace PrjContas
{
    partial class frmContasPagar
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
            System.Windows.Forms.Label cd_conta_pagarLabel;
            System.Windows.Forms.Label ds_numeroLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label id_fornecedorLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasPagar));
            this.db_contasDataSet = new PrjContas.db_contasDataSet();
            this.tb_contas_pagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contas_pagarTableAdapter = new PrjContas.db_contasDataSetTableAdapters.tb_contas_pagarTableAdapter();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_conta_pagarLabel = new System.Windows.Forms.Label();
            ds_numeroLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            id_fornecedorLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_pagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_conta_pagarLabel
            // 
            cd_conta_pagarLabel.AutoSize = true;
            cd_conta_pagarLabel.BackColor = System.Drawing.Color.Transparent;
            cd_conta_pagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            cd_conta_pagarLabel.Location = new System.Drawing.Point(76, 41);
            cd_conta_pagarLabel.Name = "cd_conta_pagarLabel";
            cd_conta_pagarLabel.Size = new System.Drawing.Size(81, 25);
            cd_conta_pagarLabel.TabIndex = 1;
            cd_conta_pagarLabel.Text = "Código:";
            // 
            // ds_numeroLabel
            // 
            ds_numeroLabel.AutoSize = true;
            ds_numeroLabel.BackColor = System.Drawing.Color.Transparent;
            ds_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            ds_numeroLabel.Location = new System.Drawing.Point(76, 88);
            ds_numeroLabel.Name = "ds_numeroLabel";
            ds_numeroLabel.Size = new System.Drawing.Size(87, 25);
            ds_numeroLabel.TabIndex = 3;
            ds_numeroLabel.Text = "Número:";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.BackColor = System.Drawing.Color.Transparent;
            dt_emissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dt_emissaoLabel.Location = new System.Drawing.Point(76, 140);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(93, 25);
            dt_emissaoLabel.TabIndex = 5;
            dt_emissaoLabel.Text = "Emissão:";
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.BackColor = System.Drawing.Color.Transparent;
            vl_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            vl_contaLabel.Location = new System.Drawing.Point(76, 192);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(64, 25);
            vl_contaLabel.TabIndex = 7;
            vl_contaLabel.Text = "Valor:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.BackColor = System.Drawing.Color.Transparent;
            dt_vencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dt_vencimentoLabel.Location = new System.Drawing.Point(76, 308);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(122, 25);
            dt_vencimentoLabel.TabIndex = 11;
            dt_vencimentoLabel.Text = "Vencimento:";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.BackColor = System.Drawing.Color.Transparent;
            dt_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dt_pagamentoLabel.Location = new System.Drawing.Point(76, 362);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(118, 25);
            dt_pagamentoLabel.TabIndex = 13;
            dt_pagamentoLabel.Text = "Pagamento:";
            // 
            // id_fornecedorLabel1
            // 
            id_fornecedorLabel1.AutoSize = true;
            id_fornecedorLabel1.BackColor = System.Drawing.Color.Transparent;
            id_fornecedorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            id_fornecedorLabel1.Location = new System.Drawing.Point(76, 247);
            id_fornecedorLabel1.Name = "id_fornecedorLabel1";
            id_fornecedorLabel1.Size = new System.Drawing.Size(118, 25);
            id_fornecedorLabel1.TabIndex = 31;
            id_fornecedorLabel1.Text = "Fornecedor:";
            // 
            // db_contasDataSet
            // 
            this.db_contasDataSet.DataSetName = "db_contasDataSet";
            this.db_contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contas_pagarBindingSource
            // 
            this.tb_contas_pagarBindingSource.DataMember = "tb_contas_pagar";
            this.tb_contas_pagarBindingSource.DataSource = this.db_contasDataSet;
            // 
            // tb_contas_pagarTableAdapter
            // 
            this.tb_contas_pagarTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "cd_conta_pagar", true));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCodigo.Location = new System.Drawing.Point(488, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(200, 23);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "cd";
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "ds_numero", true));
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumero.Location = new System.Drawing.Point(493, 85);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(406, 30);
            this.txtNumero.TabIndex = 4;
            // 
            // dtEmissao
            // 
            this.dtEmissao.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_pagarBindingSource, "dt_emissao", true));
            this.dtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtEmissao.Location = new System.Drawing.Point(493, 135);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(406, 30);
            this.dtEmissao.TabIndex = 6;
            // 
            // txtValorConta
            // 
            this.txtValorConta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "vl_conta", true));
            this.txtValorConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtValorConta.Location = new System.Drawing.Point(493, 189);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(406, 30);
            this.txtValorConta.TabIndex = 8;
            // 
            // dtVencimento
            // 
            this.dtVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_pagarBindingSource, "dt_vencimento", true));
            this.dtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtVencimento.Location = new System.Drawing.Point(493, 303);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(406, 30);
            this.dtVencimento.TabIndex = 12;
            // 
            // dtPagamento
            // 
            this.dtPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_pagarBindingSource, "dt_pagamento", true));
            this.dtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtPagamento.Location = new System.Drawing.Point(493, 357);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Size = new System.Drawing.Size(406, 30);
            this.dtPagamento.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Location = new System.Drawing.Point(905, 490);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 50);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnImprimir.Location = new System.Drawing.Point(699, 490);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 50);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPesquisar.Location = new System.Drawing.Point(493, 490);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(200, 50);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(287, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 50);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSalvar.Location = new System.Drawing.Point(81, 490);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 50);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExcluir.Location = new System.Drawing.Point(905, 434);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(200, 50);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAlterar.Location = new System.Drawing.Point(699, 434);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(200, 50);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNovo.Location = new System.Drawing.Point(493, 434);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(200, 50);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnProximo.Location = new System.Drawing.Point(287, 434);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(200, 50);
            this.btnProximo.TabIndex = 23;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAnterior.Location = new System.Drawing.Point(81, 434);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(200, 50);
            this.btnAnterior.TabIndex = 22;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "id_fornecedor", true));
            this.txtIdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIdFornecedor.Location = new System.Drawing.Point(493, 244);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(406, 30);
            this.txtIdFornecedor.TabIndex = 32;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1192, 573);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(id_fornecedorLabel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_conta_pagarLabel);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(ds_numeroLabel);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dtEmissao);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.txtValorConta);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dtVencimento);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dtPagamento);
            this.Name = "frmContasPagar";
            this.Text = "Contas a pagar";
            this.Load += new System.EventHandler(this.frmContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_pagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_contasDataSet db_contasDataSet;
        private System.Windows.Forms.BindingSource tb_contas_pagarBindingSource;
        private db_contasDataSetTableAdapters.tb_contas_pagarTableAdapter tb_contas_pagarTableAdapter;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.DateTimePicker dtPagamento;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}