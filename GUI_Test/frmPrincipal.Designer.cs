namespace GUI_Test
{
    partial class frmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrarAcao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAtualizarAcao = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComprar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVender = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMdi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMinimizarTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.cmnuMdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.açõesToolStripMenuItem,
            this.operaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.mnuAjuda});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(97, 22);
            this.mnuSair.Text = "&Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastrarAcao,
            this.mnuAtualizarAcao});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.açõesToolStripMenuItem.Text = "&Ações";
            // 
            // mnuCadastrarAcao
            // 
            this.mnuCadastrarAcao.Name = "mnuCadastrarAcao";
            this.mnuCadastrarAcao.Size = new System.Drawing.Size(131, 22);
            this.mnuCadastrarAcao.Text = "&Cadastrar";
            this.mnuCadastrarAcao.Click += new System.EventHandler(this.mnuCadastrarAcao_Click);
            // 
            // mnuAtualizarAcao
            // 
            this.mnuAtualizarAcao.Name = "mnuAtualizarAcao";
            this.mnuAtualizarAcao.Size = new System.Drawing.Size(131, 22);
            this.mnuAtualizarAcao.Text = "&Atualizar";
            this.mnuAtualizarAcao.Click += new System.EventHandler(this.mnuAtualizarAcao_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuComprar,
            this.mnuVender});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.operaçõesToolStripMenuItem.Text = "&Operações";
            // 
            // mnuComprar
            // 
            this.mnuComprar.Name = "mnuComprar";
            this.mnuComprar.Size = new System.Drawing.Size(125, 22);
            this.mnuComprar.Text = "&Comprar";
            this.mnuComprar.Click += new System.EventHandler(this.mnuComprar_Click);
            // 
            // mnuVender
            // 
            this.mnuVender.Name = "mnuVender";
            this.mnuVender.Size = new System.Drawing.Size(125, 22);
            this.mnuVender.Text = "&Vender";
            this.mnuVender.Click += new System.EventHandler(this.mnuVender_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRelCompras,
            this.mnuVendas,
            this.mnuEstoque});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // mnuRelCompras
            // 
            this.mnuRelCompras.Name = "mnuRelCompras";
            this.mnuRelCompras.Size = new System.Drawing.Size(152, 22);
            this.mnuRelCompras.Text = "&Compras";
            this.mnuRelCompras.Click += new System.EventHandler(this.mnuRelCompras_Click);
            // 
            // mnuVendas
            // 
            this.mnuVendas.Name = "mnuVendas";
            this.mnuVendas.Size = new System.Drawing.Size(152, 22);
            this.mnuVendas.Text = "&Vendas";
            // 
            // mnuEstoque
            // 
            this.mnuEstoque.Name = "mnuEstoque";
            this.mnuEstoque.Size = new System.Drawing.Size(152, 22);
            this.mnuEstoque.Text = "&Estoque";
            this.mnuEstoque.Click += new System.EventHandler(this.mnuEstoque_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(52, 20);
            this.mnuAjuda.Text = "&Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // cmnuMdi
            // 
            this.cmnuMdi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnuMdi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuCascata,
            this.cmnuMinimizarTodas});
            this.cmnuMdi.Name = "cmnuMdi";
            this.cmnuMdi.ShowImageMargin = false;
            this.cmnuMdi.Size = new System.Drawing.Size(161, 48);
            // 
            // cmnuCascata
            // 
            this.cmnuCascata.Name = "cmnuCascata";
            this.cmnuCascata.Size = new System.Drawing.Size(160, 22);
            this.cmnuCascata.Text = "Janelas em cascata";
            this.cmnuCascata.Click += new System.EventHandler(this.cmnuCascata_Click);
            // 
            // cmnuMinimizarTodas
            // 
            this.cmnuMinimizarTodas.Name = "cmnuMinimizarTodas";
            this.cmnuMinimizarTodas.Size = new System.Drawing.Size(160, 22);
            this.cmnuMinimizarTodas.Text = "&Minimizar todas";
            this.cmnuMinimizarTodas.Click += new System.EventHandler(this.cmnuMinimizarTodas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ContextMenuStrip = this.cmnuMdi;
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financer";
            this.TransparencyKey = System.Drawing.Color.Chartreuse;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.cmnuMdi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrarAcao;
        private System.Windows.Forms.ToolStripMenuItem mnuAtualizarAcao;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuComprar;
        private System.Windows.Forms.ToolStripMenuItem mnuVender;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRelCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuVendas;
        private System.Windows.Forms.ToolStripMenuItem mnuEstoque;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmnuMdi;
        private System.Windows.Forms.ToolStripMenuItem cmnuCascata;
        private System.Windows.Forms.ToolStripMenuItem cmnuMinimizarTodas;
    }
}