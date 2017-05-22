namespace GUI_Test
{
    partial class frmVender
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
            this.txtValorDaAcao = new System.Windows.Forms.TextBox();
            this.lblValorDaAcao = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cmdEstoque = new System.Windows.Forms.Button();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdVender = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblAcao = new System.Windows.Forms.Label();
            this.grpVendas = new System.Windows.Forms.GroupBox();
            this.gprVenda2 = new System.Windows.Forms.GroupBox();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.lblIRTotal = new System.Windows.Forms.Label();
            this.txtIrTotal = new System.Windows.Forms.TextBox();
            this.lblPercentualIR = new System.Windows.Forms.Label();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.grpVenda1 = new System.Windows.Forms.GroupBox();
            this.lblValorMedio = new System.Windows.Forms.Label();
            this.txtValorMedio = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.grpVendas.SuspendLayout();
            this.gprVenda2.SuspendLayout();
            this.grpVenda1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorDaAcao
            // 
            this.txtValorDaAcao.AllowDrop = true;
            this.txtValorDaAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDaAcao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDaAcao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorDaAcao.Location = new System.Drawing.Point(149, 48);
            this.txtValorDaAcao.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtValorDaAcao.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtValorDaAcao.Name = "txtValorDaAcao";
            this.txtValorDaAcao.Size = new System.Drawing.Size(150, 21);
            this.txtValorDaAcao.TabIndex = 2;
            this.txtValorDaAcao.Text = "0";
            this.txtValorDaAcao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorDaAcao.TextChanged += new System.EventHandler(this.AtualizaPrecoTotal);
            this.txtValorDaAcao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDaAcao_KeyPress);
            // 
            // lblValorDaAcao
            // 
            this.lblValorDaAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorDaAcao.AutoSize = true;
            this.lblValorDaAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDaAcao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorDaAcao.Location = new System.Drawing.Point(-2, 51);
            this.lblValorDaAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaAcao.Name = "lblValorDaAcao";
            this.lblValorDaAcao.Size = new System.Drawing.Size(148, 13);
            this.lblValorDaAcao.TabIndex = 0;
            this.lblValorDaAcao.Text = "Valor de venda da ação:";
            this.lblValorDaAcao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantidade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numQuantidade.Location = new System.Drawing.Point(149, 123);
            this.numQuantidade.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numQuantidade.MaximumSize = new System.Drawing.Size(300, 0);
            this.numQuantidade.MinimumSize = new System.Drawing.Size(150, 0);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(150, 21);
            this.numQuantidade.TabIndex = 5;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged);
            this.numQuantidade.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numQuantidade_Scroll);
            this.numQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDaAcao_KeyPress);
            // 
            // cmdEstoque
            // 
            this.cmdEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdEstoque.FlatAppearance.BorderSize = 0;
            this.cmdEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdEstoque.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdEstoque.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEstoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdEstoque.Location = new System.Drawing.Point(144, 321);
            this.cmdEstoque.MaximumSize = new System.Drawing.Size(101, 23);
            this.cmdEstoque.MinimumSize = new System.Drawing.Size(101, 23);
            this.cmdEstoque.Name = "cmdEstoque";
            this.cmdEstoque.Size = new System.Drawing.Size(101, 23);
            this.cmdEstoque.TabIndex = 11;
            this.cmdEstoque.Text = "&Estoque";
            this.cmdEstoque.UseVisualStyleBackColor = false;
            this.cmdEstoque.Click += new System.EventHandler(this.cmdEstoque_Click);
            // 
            // txtBruto
            // 
            this.txtBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBruto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBruto.ForeColor = System.Drawing.Color.Blue;
            this.txtBruto.Location = new System.Drawing.Point(149, 151);
            this.txtBruto.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtBruto.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtBruto.Multiline = true;
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.ReadOnly = true;
            this.txtBruto.Size = new System.Drawing.Size(150, 21);
            this.txtBruto.TabIndex = 6;
            this.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBruto.TextChanged += new System.EventHandler(this.txtBruto_TextChanged);
            // 
            // cmbAcao
            // 
            this.cmbAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAcao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(149, 23);
            this.cmbAcao.MaximumSize = new System.Drawing.Size(300, 0);
            this.cmbAcao.MinimumSize = new System.Drawing.Size(150, 0);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(150, 21);
            this.cmbAcao.TabIndex = 1;
            this.cmbAcao.SelectedIndexChanged += new System.EventHandler(this.cmbAcao_SelectedIndexChanged);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdCancelar.FlatAppearance.BorderSize = 0;
            this.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancelar.Location = new System.Drawing.Point(252, 321);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmdCancelar.MaximumSize = new System.Drawing.Size(101, 23);
            this.cmdCancelar.MinimumSize = new System.Drawing.Size(101, 23);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(101, 23);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancela&r";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdVender
            // 
            this.cmdVender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdVender.FlatAppearance.BorderSize = 0;
            this.cmdVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdVender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdVender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVender.Location = new System.Drawing.Point(36, 321);
            this.cmdVender.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmdVender.MaximumSize = new System.Drawing.Size(101, 23);
            this.cmdVender.MinimumSize = new System.Drawing.Size(101, 23);
            this.cmdVender.Name = "cmdVender";
            this.cmdVender.Size = new System.Drawing.Size(101, 23);
            this.cmdVender.TabIndex = 10;
            this.cmdVender.Text = "&Vender";
            this.cmdVender.UseVisualStyleBackColor = true;
            this.cmdVender.Click += new System.EventHandler(this.cmdVender_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantidade.Location = new System.Drawing.Point(65, 127);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(77, 13);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblData.Location = new System.Drawing.Point(45, 101);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(97, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data da Venda:";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBruto
            // 
            this.lblBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBruto.AutoSize = true;
            this.lblBruto.BackColor = System.Drawing.Color.Transparent;
            this.lblBruto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBruto.Location = new System.Drawing.Point(3, 154);
            this.lblBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(146, 13);
            this.lblBruto.TabIndex = 0;
            this.lblBruto.Text = "Total da Venda (bruto) :";
            this.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAcao
            // 
            this.lblAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcao.AutoSize = true;
            this.lblAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblAcao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcao.Location = new System.Drawing.Point(102, 28);
            this.lblAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(40, 13);
            this.lblAcao.TabIndex = 0;
            this.lblAcao.Text = "Ação:";
            this.lblAcao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpVendas
            // 
            this.grpVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVendas.AutoSize = true;
            this.grpVendas.Controls.Add(this.gprVenda2);
            this.grpVendas.Controls.Add(this.cmdEstoque);
            this.grpVendas.Controls.Add(this.cmdVender);
            this.grpVendas.Controls.Add(this.cmdCancelar);
            this.grpVendas.Controls.Add(this.grpVenda1);
            this.grpVendas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVendas.Location = new System.Drawing.Point(12, 3);
            this.grpVendas.Name = "grpVendas";
            this.grpVendas.Size = new System.Drawing.Size(379, 368);
            this.grpVendas.TabIndex = 0;
            this.grpVendas.TabStop = false;
            this.grpVendas.Text = "Vender ação:";
            // 
            // gprVenda2
            // 
            this.gprVenda2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gprVenda2.Controls.Add(this.lblLiquido);
            this.gprVenda2.Controls.Add(this.txtLiquido);
            this.gprVenda2.Controls.Add(this.lblIRTotal);
            this.gprVenda2.Controls.Add(this.txtIrTotal);
            this.gprVenda2.Controls.Add(this.lblPercentualIR);
            this.gprVenda2.Controls.Add(this.txtIR);
            this.gprVenda2.Location = new System.Drawing.Point(36, 211);
            this.gprVenda2.Name = "gprVenda2";
            this.gprVenda2.Size = new System.Drawing.Size(317, 100);
            this.gprVenda2.TabIndex = 0;
            this.gprVenda2.TabStop = false;
            // 
            // lblLiquido
            // 
            this.lblLiquido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.BackColor = System.Drawing.Color.Transparent;
            this.lblLiquido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLiquido.Location = new System.Drawing.Point(34, 62);
            this.lblLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(93, 13);
            this.lblLiquido.TabIndex = 0;
            this.lblLiquido.Text = "Valor (liquido):";
            this.lblLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLiquido
            // 
            this.txtLiquido.AllowDrop = true;
            this.txtLiquido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLiquido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLiquido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLiquido.Location = new System.Drawing.Point(133, 57);
            this.txtLiquido.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtLiquido.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.Size = new System.Drawing.Size(150, 21);
            this.txtLiquido.TabIndex = 9;
            this.txtLiquido.Text = "0";
            this.txtLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIRTotal
            // 
            this.lblIRTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIRTotal.AutoSize = true;
            this.lblIRTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblIRTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIRTotal.Location = new System.Drawing.Point(66, 40);
            this.lblIRTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRTotal.Name = "lblIRTotal";
            this.lblIRTotal.Size = new System.Drawing.Size(54, 13);
            this.lblIRTotal.TabIndex = 0;
            this.lblIRTotal.Text = "IR total:";
            this.lblIRTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIrTotal
            // 
            this.txtIrTotal.AllowDrop = true;
            this.txtIrTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIrTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIrTotal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIrTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIrTotal.Location = new System.Drawing.Point(132, 35);
            this.txtIrTotal.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtIrTotal.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtIrTotal.Name = "txtIrTotal";
            this.txtIrTotal.Size = new System.Drawing.Size(150, 21);
            this.txtIrTotal.TabIndex = 8;
            this.txtIrTotal.Text = "0";
            this.txtIrTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPercentualIR
            // 
            this.lblPercentualIR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercentualIR.AutoSize = true;
            this.lblPercentualIR.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentualIR.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualIR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPercentualIR.Location = new System.Drawing.Point(32, 17);
            this.lblPercentualIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentualIR.Name = "lblPercentualIR";
            this.lblPercentualIR.Size = new System.Drawing.Size(93, 13);
            this.lblPercentualIR.TabIndex = 0;
            this.lblPercentualIR.Text = "Percentual IR: ";
            this.lblPercentualIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIR
            // 
            this.txtIR.AllowDrop = true;
            this.txtIR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIR.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIR.Location = new System.Drawing.Point(132, 12);
            this.txtIR.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtIR.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(150, 21);
            this.txtIR.TabIndex = 7;
            this.txtIR.Text = "0";
            this.txtIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIR.TextChanged += new System.EventHandler(this.txtIR_TextChanged);
            this.txtIR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIR_KeyPress);
            // 
            // grpVenda1
            // 
            this.grpVenda1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpVenda1.Controls.Add(this.lblValorMedio);
            this.grpVenda1.Controls.Add(this.txtValorMedio);
            this.grpVenda1.Controls.Add(this.cmbAcao);
            this.grpVenda1.Controls.Add(this.txtData);
            this.grpVenda1.Controls.Add(this.txtBruto);
            this.grpVenda1.Controls.Add(this.lblValorDaAcao);
            this.grpVenda1.Controls.Add(this.lblQuantidade);
            this.grpVenda1.Controls.Add(this.txtValorDaAcao);
            this.grpVenda1.Controls.Add(this.lblData);
            this.grpVenda1.Controls.Add(this.lblAcao);
            this.grpVenda1.Controls.Add(this.numQuantidade);
            this.grpVenda1.Controls.Add(this.lblBruto);
            this.grpVenda1.Location = new System.Drawing.Point(13, 20);
            this.grpVenda1.Name = "grpVenda1";
            this.grpVenda1.Size = new System.Drawing.Size(352, 185);
            this.grpVenda1.TabIndex = 0;
            this.grpVenda1.TabStop = false;
            // 
            // lblValorMedio
            // 
            this.lblValorMedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorMedio.AutoSize = true;
            this.lblValorMedio.BackColor = System.Drawing.Color.Transparent;
            this.lblValorMedio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorMedio.Location = new System.Drawing.Point(45, 77);
            this.lblValorMedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorMedio.Name = "lblValorMedio";
            this.lblValorMedio.Size = new System.Drawing.Size(101, 13);
            this.lblValorMedio.TabIndex = 0;
            this.lblValorMedio.Text = "Valor da Médio: ";
            this.lblValorMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorMedio
            // 
            this.txtValorMedio.AllowDrop = true;
            this.txtValorMedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorMedio.Enabled = false;
            this.txtValorMedio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorMedio.Location = new System.Drawing.Point(149, 73);
            this.txtValorMedio.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtValorMedio.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtValorMedio.Name = "txtValorMedio";
            this.txtValorMedio.Size = new System.Drawing.Size(150, 21);
            this.txtValorMedio.TabIndex = 3;
            this.txtValorMedio.Text = "0";
            this.txtValorMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(149, 97);
            this.txtData.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtData.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(150, 21);
            this.txtData.TabIndex = 4;
            this.txtData.Value = new System.DateTime(2017, 5, 16, 19, 40, 33, 0);
            // 
            // frmVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 373);
            this.Controls.Add(this.grpVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(420, 411);
            this.Name = "frmVender";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender  ações";
            this.Load += new System.EventHandler(this.frmComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.grpVendas.ResumeLayout(false);
            this.gprVenda2.ResumeLayout(false);
            this.gprVenda2.PerformLayout();
            this.grpVenda1.ResumeLayout(false);
            this.grpVenda1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorDaAcao;
        private System.Windows.Forms.Label lblValorDaAcao;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button cmdEstoque;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdVender;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.GroupBox grpVendas;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.GroupBox gprVenda2;
        private System.Windows.Forms.GroupBox grpVenda1;
        private System.Windows.Forms.Label lblValorMedio;
        private System.Windows.Forms.TextBox txtValorMedio;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.TextBox txtLiquido;
        private System.Windows.Forms.Label lblIRTotal;
        private System.Windows.Forms.TextBox txtIrTotal;
        private System.Windows.Forms.Label lblPercentualIR;
        private System.Windows.Forms.TextBox txtIR;
    }
}