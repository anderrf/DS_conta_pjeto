namespace PrjContas
{
    partial class frmContasReceber
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
            System.Windows.Forms.Label cd_conta_receberLabel;
            System.Windows.Forms.Label ds_numeroLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContasReceber));
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
            this.db_contasDataSet = new PrjContas.db_contasDataSet();
            this.tb_contas_receberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contas_receberTableAdapter = new PrjContas.db_contasDataSetTableAdapters.tb_contas_receberTableAdapter();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.txtValorConta = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.dtVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtPagamento = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            cd_conta_receberLabel = new System.Windows.Forms.Label();
            ds_numeroLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_receberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_conta_receberLabel
            // 
            cd_conta_receberLabel.AutoSize = true;
            cd_conta_receberLabel.BackColor = System.Drawing.Color.Transparent;
            cd_conta_receberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            cd_conta_receberLabel.Location = new System.Drawing.Point(73, 37);
            cd_conta_receberLabel.Name = "cd_conta_receberLabel";
            cd_conta_receberLabel.Size = new System.Drawing.Size(81, 25);
            cd_conta_receberLabel.TabIndex = 42;
            cd_conta_receberLabel.Text = "Código:";
            // 
            // ds_numeroLabel
            // 
            ds_numeroLabel.AutoSize = true;
            ds_numeroLabel.BackColor = System.Drawing.Color.Transparent;
            ds_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            ds_numeroLabel.Location = new System.Drawing.Point(73, 92);
            ds_numeroLabel.Name = "ds_numeroLabel";
            ds_numeroLabel.Size = new System.Drawing.Size(87, 25);
            ds_numeroLabel.TabIndex = 44;
            ds_numeroLabel.Text = "Número:";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.BackColor = System.Drawing.Color.Transparent;
            dt_emissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dt_emissaoLabel.Location = new System.Drawing.Point(73, 144);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(93, 25);
            dt_emissaoLabel.TabIndex = 46;
            dt_emissaoLabel.Text = "Emissão:";
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.BackColor = System.Drawing.Color.Transparent;
            vl_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            vl_contaLabel.Location = new System.Drawing.Point(73, 189);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(64, 25);
            vl_contaLabel.TabIndex = 48;
            vl_contaLabel.Text = "Valor:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.BackColor = System.Drawing.Color.Transparent;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            id_clienteLabel.Location = new System.Drawing.Point(73, 246);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(79, 25);
            id_clienteLabel.TabIndex = 50;
            id_clienteLabel.Text = "Cliente:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.BackColor = System.Drawing.Color.Transparent;
            dt_vencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dt_vencimentoLabel.Location = new System.Drawing.Point(73, 309);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(122, 25);
            dt_vencimentoLabel.TabIndex = 52;
            dt_vencimentoLabel.Text = "Vencimento:";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.BackColor = System.Drawing.Color.Transparent;
            dt_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dt_pagamentoLabel.Location = new System.Drawing.Point(73, 374);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(118, 25);
            dt_pagamentoLabel.TabIndex = 54;
            dt_pagamentoLabel.Text = "Pagamento:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.Location = new System.Drawing.Point(902, 508);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 50);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnImprimir.Location = new System.Drawing.Point(696, 508);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 50);
            this.btnImprimir.TabIndex = 40;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPesquisar.Location = new System.Drawing.Point(490, 508);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(200, 50);
            this.btnPesquisar.TabIndex = 39;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCancelar.Location = new System.Drawing.Point(284, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 50);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSalvar.Location = new System.Drawing.Point(78, 508);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 50);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExcluir.Location = new System.Drawing.Point(902, 452);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(200, 50);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAlterar.Location = new System.Drawing.Point(696, 452);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(200, 50);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNovo.Location = new System.Drawing.Point(490, 452);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(200, 50);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnProximo.Location = new System.Drawing.Point(284, 452);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(200, 50);
            this.btnProximo.TabIndex = 33;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAnterior.Location = new System.Drawing.Point(78, 452);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(200, 50);
            this.btnAnterior.TabIndex = 32;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // db_contasDataSet
            // 
            this.db_contasDataSet.DataSetName = "db_contasDataSet";
            this.db_contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contas_receberBindingSource
            // 
            this.tb_contas_receberBindingSource.DataMember = "tb_contas_receber";
            this.tb_contas_receberBindingSource.DataSource = this.db_contasDataSet;
            // 
            // tb_contas_receberTableAdapter
            // 
            this.tb_contas_receberTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_receberBindingSource, "cd_conta_receber", true));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCodigo.Location = new System.Drawing.Point(485, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(200, 23);
            this.lblCodigo.TabIndex = 43;
            this.lblCodigo.Text = "cd";
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_receberBindingSource, "ds_numero", true));
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumero.Location = new System.Drawing.Point(490, 89);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(406, 30);
            this.txtNumero.TabIndex = 45;
            // 
            // dtEmissao
            // 
            this.dtEmissao.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_receberBindingSource, "dt_emissao", true));
            this.dtEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtEmissao.Location = new System.Drawing.Point(490, 139);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(406, 30);
            this.dtEmissao.TabIndex = 47;
            // 
            // txtValorConta
            // 
            this.txtValorConta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_receberBindingSource, "vl_conta", true));
            this.txtValorConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtValorConta.Location = new System.Drawing.Point(490, 186);
            this.txtValorConta.Name = "txtValorConta";
            this.txtValorConta.Size = new System.Drawing.Size(406, 30);
            this.txtValorConta.TabIndex = 49;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_receberBindingSource, "id_cliente", true));
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtIdCliente.Location = new System.Drawing.Point(490, 243);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(406, 30);
            this.txtIdCliente.TabIndex = 51;
            // 
            // dtVencimento
            // 
            this.dtVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_receberBindingSource, "dt_vencimento", true));
            this.dtVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtVencimento.Location = new System.Drawing.Point(485, 304);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.Size = new System.Drawing.Size(411, 30);
            this.dtVencimento.TabIndex = 53;
            // 
            // dtPagamento
            // 
            this.dtPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contas_receberBindingSource, "dt_pagamento", true));
            this.dtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtPagamento.Location = new System.Drawing.Point(490, 369);
            this.dtPagamento.Name = "dtPagamento";
            this.dtPagamento.Size = new System.Drawing.Size(406, 30);
            this.dtPagamento.TabIndex = 55;
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
            // frmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1192, 573);
            this.Controls.Add(cd_conta_receberLabel);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(ds_numeroLabel);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dtEmissao);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.txtValorConta);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dtVencimento);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dtPagamento);
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
            this.Name = "frmContasReceber";
            this.Text = "Contas a receber";
            this.Load += new System.EventHandler(this.frmContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_receberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private db_contasDataSet db_contasDataSet;
        private System.Windows.Forms.BindingSource tb_contas_receberBindingSource;
        private db_contasDataSetTableAdapters.tb_contas_receberTableAdapter tb_contas_receberTableAdapter;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        private System.Windows.Forms.TextBox txtValorConta;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.DateTimePicker dtVencimento;
        private System.Windows.Forms.DateTimePicker dtPagamento;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}