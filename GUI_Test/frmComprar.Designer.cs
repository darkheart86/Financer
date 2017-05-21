namespace GUI_Test
{
    partial class frmComprar
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
            this.cmdCadastro = new System.Windows.Forms.Button();
            this.txtValorDaCompra = new System.Windows.Forms.TextBox();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdComprar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.lblAcao = new System.Windows.Forms.Label();
            this.grpCompras = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.grpCompras.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValorDaAcao
            // 
            this.txtValorDaAcao.AllowDrop = true;
            this.txtValorDaAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDaAcao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDaAcao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorDaAcao.Location = new System.Drawing.Point(161, 71);
            this.txtValorDaAcao.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtValorDaAcao.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtValorDaAcao.Name = "txtValorDaAcao";
            this.txtValorDaAcao.Size = new System.Drawing.Size(150, 21);
            this.txtValorDaAcao.TabIndex = 2;
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
            this.lblValorDaAcao.Location = new System.Drawing.Point(62, 78);
            this.lblValorDaAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaAcao.Name = "lblValorDaAcao";
            this.lblValorDaAcao.Size = new System.Drawing.Size(92, 13);
            this.lblValorDaAcao.TabIndex = 51;
            this.lblValorDaAcao.Text = "Valor da Ação:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantidade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numQuantidade.Location = new System.Drawing.Point(161, 123);
            this.numQuantidade.MaximumSize = new System.Drawing.Size(300, 0);
            this.numQuantidade.MinimumSize = new System.Drawing.Size(150, 0);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(150, 21);
            this.numQuantidade.TabIndex = 4;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidade.ValueChanged += new System.EventHandler(this.AtualizaPrecoTotal);
            this.numQuantidade.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numQuantidade_Scroll);
            this.numQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDaAcao_KeyPress);
            // 
            // cmdCadastro
            // 
            this.cmdCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdCadastro.FlatAppearance.BorderSize = 0;
            this.cmdCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdCadastro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCadastro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdCadastro.Location = new System.Drawing.Point(144, 201);
            this.cmdCadastro.MaximumSize = new System.Drawing.Size(101, 23);
            this.cmdCadastro.MinimumSize = new System.Drawing.Size(101, 23);
            this.cmdCadastro.Name = "cmdCadastro";
            this.cmdCadastro.Size = new System.Drawing.Size(101, 23);
            this.cmdCadastro.TabIndex = 6;
            this.cmdCadastro.Text = "&Cadastro";
            this.cmdCadastro.UseVisualStyleBackColor = false;
            // 
            // txtValorDaCompra
            // 
            this.txtValorDaCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDaCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaCompra.ForeColor = System.Drawing.Color.Blue;
            this.txtValorDaCompra.Location = new System.Drawing.Point(161, 151);
            this.txtValorDaCompra.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtValorDaCompra.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtValorDaCompra.Multiline = true;
            this.txtValorDaCompra.Name = "txtValorDaCompra";
            this.txtValorDaCompra.ReadOnly = true;
            this.txtValorDaCompra.Size = new System.Drawing.Size(150, 21);
            this.txtValorDaCompra.TabIndex = 47;
            this.txtValorDaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbAcao
            // 
            this.cmbAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAcao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(161, 44);
            this.cmbAcao.MaximumSize = new System.Drawing.Size(300, 0);
            this.cmbAcao.MinimumSize = new System.Drawing.Size(150, 0);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(150, 21);
            this.cmbAcao.TabIndex = 1;
            this.cmbAcao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.cmdCancelar.Location = new System.Drawing.Point(252, 201);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmdCancelar.MaximumSize = new System.Drawing.Size(101, 23);
            this.cmdCancelar.MinimumSize = new System.Drawing.Size(101, 23);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(101, 23);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancela&r";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdComprar
            // 
            this.cmdComprar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdComprar.FlatAppearance.BorderSize = 0;
            this.cmdComprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdComprar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdComprar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdComprar.Location = new System.Drawing.Point(36, 201);
            this.cmdComprar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cmdComprar.MaximumSize = new System.Drawing.Size(101, 23);
            this.cmdComprar.MinimumSize = new System.Drawing.Size(101, 23);
            this.cmdComprar.Name = "cmdComprar";
            this.cmdComprar.Size = new System.Drawing.Size(101, 23);
            this.cmdComprar.TabIndex = 5;
            this.cmdComprar.Text = "C&omprar";
            this.cmdComprar.UseVisualStyleBackColor = true;
            this.cmdComprar.Click += new System.EventHandler(this.cmdComprar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantidade.Location = new System.Drawing.Point(77, 130);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(77, 13);
            this.lblQuantidade.TabIndex = 43;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblData.Location = new System.Drawing.Point(47, 105);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(107, 13);
            this.lblData.TabIndex = 42;
            this.lblData.Text = "Data da Compra:";
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDaCompra.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorDaCompra.Location = new System.Drawing.Point(47, 157);
            this.lblValorDaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(110, 13);
            this.lblValorDaCompra.TabIndex = 41;
            this.lblValorDaCompra.Text = "Valor da Compra:";
            // 
            // lblAcao
            // 
            this.lblAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcao.AutoSize = true;
            this.lblAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblAcao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcao.Location = new System.Drawing.Point(114, 47);
            this.lblAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(40, 13);
            this.lblAcao.TabIndex = 40;
            this.lblAcao.Text = "Ação:";
            // 
            // grpCompras
            // 
            this.grpCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCompras.AutoSize = true;
            this.grpCompras.Controls.Add(this.txtData);
            this.grpCompras.Controls.Add(this.lblValorDaAcao);
            this.grpCompras.Controls.Add(this.txtValorDaAcao);
            this.grpCompras.Controls.Add(this.lblAcao);
            this.grpCompras.Controls.Add(this.lblValorDaCompra);
            this.grpCompras.Controls.Add(this.numQuantidade);
            this.grpCompras.Controls.Add(this.lblData);
            this.grpCompras.Controls.Add(this.cmdCadastro);
            this.grpCompras.Controls.Add(this.lblQuantidade);
            this.grpCompras.Controls.Add(this.cmdComprar);
            this.grpCompras.Controls.Add(this.txtValorDaCompra);
            this.grpCompras.Controls.Add(this.cmdCancelar);
            this.grpCompras.Controls.Add(this.cmbAcao);
            this.grpCompras.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompras.Location = new System.Drawing.Point(12, 3);
            this.grpCompras.Name = "grpCompras";
            this.grpCompras.Size = new System.Drawing.Size(379, 256);
            this.grpCompras.TabIndex = 0;
            this.grpCompras.TabStop = false;
            this.grpCompras.Text = "Comprar ação: ";
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(161, 97);
            this.txtData.MaximumSize = new System.Drawing.Size(300, 21);
            this.txtData.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(150, 21);
            this.txtData.TabIndex = 3;
            this.txtData.Value = new System.DateTime(2017, 5, 16, 19, 40, 33, 0);
            // 
            // frmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 268);
            this.Controls.Add(this.grpCompras);
            this.MinimumSize = new System.Drawing.Size(420, 306);
            this.Name = "frmComprar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Comprar ações";
            this.Load += new System.EventHandler(this.frmComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.grpCompras.ResumeLayout(false);
            this.grpCompras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorDaAcao;
        private System.Windows.Forms.Label lblValorDaAcao;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button cmdCadastro;
        private System.Windows.Forms.TextBox txtValorDaCompra;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdComprar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.GroupBox grpCompras;
        private System.Windows.Forms.DateTimePicker txtData;
    }
}