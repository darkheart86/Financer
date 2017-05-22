namespace GUI
{
    partial class FormComprar
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
            this.grpCompras = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.lblValorDaAcao = new System.Windows.Forms.Label();
            this.txtValorDaAcao = new System.Windows.Forms.TextBox();
            this.lblAcao = new System.Windows.Forms.Label();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblData = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtValorDaCompra = new System.Windows.Forms.TextBox();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.cmdComprar = new System.Windows.Forms.Button();
            this.grpCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
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
            this.grpCompras.Controls.Add(this.lblQuantidade);
            this.grpCompras.Controls.Add(this.txtValorDaCompra);
            this.grpCompras.Controls.Add(this.cmbAcao);
            this.grpCompras.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompras.Location = new System.Drawing.Point(217, 40);
            this.grpCompras.Name = "grpCompras";
            this.grpCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpCompras.Size = new System.Drawing.Size(491, 258);
            this.grpCompras.TabIndex = 1;
            this.grpCompras.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(232, 112);
            this.txtData.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtData.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(177, 31);
            this.txtData.TabIndex = 3;
            this.txtData.Value = new System.DateTime(2017, 5, 16, 19, 40, 33, 0);
            // 
            // lblValorDaAcao
            // 
            this.lblValorDaAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorDaAcao.AutoSize = true;
            this.lblValorDaAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDaAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorDaAcao.Location = new System.Drawing.Point(16, 66);
            this.lblValorDaAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaAcao.Name = "lblValorDaAcao";
            this.lblValorDaAcao.Size = new System.Drawing.Size(168, 29);
            this.lblValorDaAcao.TabIndex = 51;
            this.lblValorDaAcao.Text = "Valor da Ação:";
            // 
            // txtValorDaAcao
            // 
            this.txtValorDaAcao.AllowDrop = true;
            this.txtValorDaAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDaAcao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDaAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorDaAcao.Location = new System.Drawing.Point(232, 66);
            this.txtValorDaAcao.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtValorDaAcao.MinimumSize = new System.Drawing.Size(150, 21);
            this.txtValorDaAcao.Name = "txtValorDaAcao";
            this.txtValorDaAcao.Size = new System.Drawing.Size(177, 31);
            this.txtValorDaAcao.TabIndex = 2;
            this.txtValorDaAcao.TextChanged += new System.EventHandler(this.txtValorDaAcao_TextChanged_1);
            this.txtValorDaAcao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDaAcao_KeyPress_1);
            // 
            // lblAcao
            // 
            this.lblAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcao.AutoSize = true;
            this.lblAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcao.Location = new System.Drawing.Point(15, 25);
            this.lblAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(73, 29);
            this.lblAcao.TabIndex = 40;
            this.lblAcao.Text = "Ação:";
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorDaCompra.Location = new System.Drawing.Point(16, 209);
            this.lblValorDaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(200, 29);
            this.lblValorDaCompra.TabIndex = 41;
            this.lblValorDaCompra.Text = "Valor da Compra:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numQuantidade.Location = new System.Drawing.Point(232, 161);
            this.numQuantidade.MaximumSize = new System.Drawing.Size(300, 0);
            this.numQuantidade.MinimumSize = new System.Drawing.Size(150, 0);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(177, 31);
            this.numQuantidade.TabIndex = 4;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged_1);
            this.numQuantidade.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numQuantidade_Scroll_1);
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblData.Location = new System.Drawing.Point(16, 115);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(193, 29);
            this.lblData.TabIndex = 42;
            this.lblData.Text = "Data da Compra:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantidade.Location = new System.Drawing.Point(15, 163);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(144, 29);
            this.lblQuantidade.TabIndex = 43;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtValorDaCompra
            // 
            this.txtValorDaCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaCompra.ForeColor = System.Drawing.Color.Blue;
            this.txtValorDaCompra.Location = new System.Drawing.Point(232, 207);
            this.txtValorDaCompra.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtValorDaCompra.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtValorDaCompra.Multiline = true;
            this.txtValorDaCompra.Name = "txtValorDaCompra";
            this.txtValorDaCompra.ReadOnly = true;
            this.txtValorDaCompra.Size = new System.Drawing.Size(177, 31);
            this.txtValorDaCompra.TabIndex = 47;
            this.txtValorDaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbAcao
            // 
            this.cmbAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(232, 21);
            this.cmbAcao.MaximumSize = new System.Drawing.Size(300, 0);
            this.cmbAcao.MinimumSize = new System.Drawing.Size(150, 0);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(177, 33);
            this.cmbAcao.TabIndex = 1;
            // 
            // cmdComprar
            // 
            this.cmdComprar.BackColor = System.Drawing.Color.Black;
            this.cmdComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprar.ForeColor = System.Drawing.Color.White;
            this.cmdComprar.Location = new System.Drawing.Point(403, 382);
            this.cmdComprar.Name = "cmdComprar";
            this.cmdComprar.Size = new System.Drawing.Size(140, 40);
            this.cmdComprar.TabIndex = 16;
            this.cmdComprar.Text = "COMPRAR";
            this.cmdComprar.UseVisualStyleBackColor = false;
            this.cmdComprar.Click += new System.EventHandler(this.cmdComprar_Click);
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 690);
            this.Controls.Add(this.cmdComprar);
            this.Controls.Add(this.grpCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComprar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormComprar";
            this.Load += new System.EventHandler(this.FormComprar_Load);
            this.grpCompras.ResumeLayout(false);
            this.grpCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCompras;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label lblValorDaAcao;
        private System.Windows.Forms.TextBox txtValorDaAcao;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtValorDaCompra;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.Button cmdComprar;
    }
}