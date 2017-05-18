namespace brafinfrontend
{
    partial class Compra
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAcao = new System.Windows.Forms.Label();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.txtValorDaCompra = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblTituloCompra = new System.Windows.Forms.Label();
            this.cmdCadastro = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdComprar = new System.Windows.Forms.Button();
            this.txtValorDaAcao = new System.Windows.Forms.TextBox();
            this.lblValorDaAcao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açõesToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(337, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.comprarToolStripMenuItem,
            this.venderToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.açõesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(60, 28);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cadastrarToolStripMenuItem.Image = global::brafinfrontend.Properties.Resources.cadastrariconebrafin12;
            this.cadastrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // comprarToolStripMenuItem
            // 
            this.comprarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comprarToolStripMenuItem.Image = global::brafinfrontend.Properties.Resources.comprariconebrafin;
            this.comprarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            this.comprarToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.comprarToolStripMenuItem.Text = "Comprar";
            this.comprarToolStripMenuItem.Click += new System.EventHandler(this.comprarToolStripMenuItem_Click);
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.venderToolStripMenuItem.Image = global::brafinfrontend.Properties.Resources.vendericonebrafin;
            this.venderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.venderToolStripMenuItem.Text = "Vender";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sairToolStripMenuItem.Image = global::brafinfrontend.Properties.Resources.sairiconebrafin;
            this.sairToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sairToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.relatóriosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.compraToolStripMenuItem.Image = global::brafinfrontend.Properties.Resources.comprariconebrafin;
            this.compraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vendaToolStripMenuItem.Image = global::brafinfrontend.Properties.Resources.vendericonebrafin;
            this.vendaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(59, 28);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblAcao.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            this.lblAcao.Location = new System.Drawing.Point(22, 115);
            this.lblAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(52, 28);
            this.lblAcao.TabIndex = 1;
            this.lblAcao.Text = "Ação:";
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDaCompra.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            this.lblValorDaCompra.Location = new System.Drawing.Point(4, 314);
            this.lblValorDaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(138, 28);
            this.lblValorDaCompra.TabIndex = 4;
            this.lblValorDaCompra.Text = "Valor da Compra:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            this.lblData.Location = new System.Drawing.Point(9, 216);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(133, 28);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data da Compra:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            this.lblQuantidade.Location = new System.Drawing.Point(39, 262);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(101, 28);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // cmbAcao
            // 
            this.cmbAcao.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(81, 117);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(214, 30);
            this.cmbAcao.TabIndex = 29;
            this.cmbAcao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtValorDaCompra
            // 
            this.txtValorDaCompra.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaCompra.Location = new System.Drawing.Point(144, 316);
            this.txtValorDaCompra.Multiline = true;
            this.txtValorDaCompra.Name = "txtValorDaCompra";
            this.txtValorDaCompra.ReadOnly = true;
            this.txtValorDaCompra.Size = new System.Drawing.Size(150, 27);
            this.txtValorDaCompra.TabIndex = 30;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(144, 218);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(150, 27);
            this.txtData.TabIndex = 31;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(144, 261);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(150, 33);
            this.numQuantidade.TabIndex = 36;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged);
            // 
            // lblTituloCompra
            // 
            this.lblTituloCompra.AutoSize = true;
            this.lblTituloCompra.Font = new System.Drawing.Font("Tw Cen MT Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompra.Location = new System.Drawing.Point(11, 50);
            this.lblTituloCompra.Name = "lblTituloCompra";
            this.lblTituloCompra.Size = new System.Drawing.Size(128, 41);
            this.lblTituloCompra.TabIndex = 37;
            this.lblTituloCompra.Text = "► COMPRA";
            // 
            // cmdCadastro
            // 
            this.cmdCadastro.BackgroundImage = global::brafinfrontend.Properties.Resources.NOVOCADASTRO1;
            this.cmdCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdCadastro.FlatAppearance.BorderSize = 0;
            this.cmdCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCadastro.Location = new System.Drawing.Point(70, 394);
            this.cmdCadastro.Name = "cmdCadastro";
            this.cmdCadastro.Size = new System.Drawing.Size(204, 80);
            this.cmdCadastro.TabIndex = 35;
            this.cmdCadastro.UseVisualStyleBackColor = false;
            this.cmdCadastro.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackgroundImage = global::brafinfrontend.Properties.Resources.CANCELARBT;
            this.cmdCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdCancelar.FlatAppearance.BorderSize = 0;
            this.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCancelar.Location = new System.Drawing.Point(16, 485);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(121, 43);
            this.cmdCancelar.TabIndex = 14;
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdComprar
            // 
            this.cmdComprar.BackgroundImage = global::brafinfrontend.Properties.Resources.COMPRARBT;
            this.cmdComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdComprar.FlatAppearance.BorderSize = 0;
            this.cmdComprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComprar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdComprar.Location = new System.Drawing.Point(201, 485);
            this.cmdComprar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmdComprar.Name = "cmdComprar";
            this.cmdComprar.Size = new System.Drawing.Size(121, 43);
            this.cmdComprar.TabIndex = 13;
            this.cmdComprar.UseVisualStyleBackColor = true;
            this.cmdComprar.Click += new System.EventHandler(this.cmdComprar_Click);
            // 
            // txtValorDaAcao
            // 
            this.txtValorDaAcao.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaAcao.Location = new System.Drawing.Point(144, 171);
            this.txtValorDaAcao.Multiline = true;
            this.txtValorDaAcao.Name = "txtValorDaAcao";
            this.txtValorDaAcao.Size = new System.Drawing.Size(150, 27);
            this.txtValorDaAcao.TabIndex = 39;
            // 
            // lblValorDaAcao
            // 
            this.lblValorDaAcao.AutoSize = true;
            this.lblValorDaAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDaAcao.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaAcao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(191)))), ((int)(((byte)(45)))));
            this.lblValorDaAcao.Location = new System.Drawing.Point(20, 169);
            this.lblValorDaAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaAcao.Name = "lblValorDaAcao";
            this.lblValorDaAcao.Size = new System.Drawing.Size(117, 28);
            this.lblValorDaAcao.TabIndex = 38;
            this.lblValorDaAcao.Text = "Valor da Ação:";
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(337, 552);
            this.Controls.Add(this.txtValorDaAcao);
            this.Controls.Add(this.lblValorDaAcao);
            this.Controls.Add(this.lblTituloCompra);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.cmdCadastro);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtValorDaCompra);
            this.Controls.Add(this.cmbAcao);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdComprar);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblValorDaCompra);
            this.Controls.Add(this.lblAcao);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button cmdComprar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.TextBox txtValorDaCompra;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button cmdCadastro;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblTituloCompra;
        private System.Windows.Forms.TextBox txtValorDaAcao;
        private System.Windows.Forms.Label lblValorDaAcao;
    }
}