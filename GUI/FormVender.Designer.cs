namespace GUI
{
    partial class FormVender
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
            this.gprVenda2 = new System.Windows.Forms.GroupBox();
            this.lblLiquido = new System.Windows.Forms.Label();
            this.txtLiquido = new System.Windows.Forms.TextBox();
            this.lblIRTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPercentualIR = new System.Windows.Forms.Label();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.grpVenda1 = new System.Windows.Forms.GroupBox();
            this.lblValorMedio = new System.Windows.Forms.Label();
            this.txtValorMedio = new System.Windows.Forms.TextBox();
            this.cmbAcao = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.lblValorDaAcao = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtValorDaAcao = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblAcao = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblBruto = new System.Windows.Forms.Label();
            this.cmdVender = new System.Windows.Forms.Button();
            this.gprVenda2.SuspendLayout();
            this.grpVenda1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // gprVenda2
            // 
            this.gprVenda2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gprVenda2.Controls.Add(this.lblLiquido);
            this.gprVenda2.Controls.Add(this.txtLiquido);
            this.gprVenda2.Controls.Add(this.lblIRTotal);
            this.gprVenda2.Controls.Add(this.textBox2);
            this.gprVenda2.Controls.Add(this.lblPercentualIR);
            this.gprVenda2.Controls.Add(this.txtIR);
            this.gprVenda2.Location = new System.Drawing.Point(217, 295);
            this.gprVenda2.Name = "gprVenda2";
            this.gprVenda2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gprVenda2.Size = new System.Drawing.Size(491, 137);
            this.gprVenda2.TabIndex = 0;
            this.gprVenda2.TabStop = false;
            // 
            // lblLiquido
            // 
            this.lblLiquido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLiquido.AutoSize = true;
            this.lblLiquido.BackColor = System.Drawing.Color.Transparent;
            this.lblLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLiquido.Location = new System.Drawing.Point(16, 89);
            this.lblLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(170, 29);
            this.lblLiquido.TabIndex = 0;
            this.lblLiquido.Text = "Valor (liquido):";
            this.lblLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLiquido
            // 
            this.txtLiquido.AllowDrop = true;
            this.txtLiquido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLiquido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiquido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLiquido.Location = new System.Drawing.Point(193, 89);
            this.txtLiquido.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtLiquido.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtLiquido.Name = "txtLiquido";
            this.txtLiquido.Size = new System.Drawing.Size(237, 31);
            this.txtLiquido.TabIndex = 9;
            this.txtLiquido.Text = "0";
            this.txtLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIRTotal
            // 
            this.lblIRTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIRTotal.AutoSize = true;
            this.lblIRTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblIRTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIRTotal.Location = new System.Drawing.Point(16, 53);
            this.lblIRTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIRTotal.Name = "lblIRTotal";
            this.lblIRTotal.Size = new System.Drawing.Size(93, 29);
            this.lblIRTotal.TabIndex = 0;
            this.lblIRTotal.Text = "IR total:";
            this.lblIRTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(194, 51);
            this.textBox2.MaximumSize = new System.Drawing.Size(300, 31);
            this.textBox2.MinimumSize = new System.Drawing.Size(150, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 31);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPercentualIR
            // 
            this.lblPercentualIR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPercentualIR.AutoSize = true;
            this.lblPercentualIR.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentualIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualIR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPercentualIR.Location = new System.Drawing.Point(14, 17);
            this.lblPercentualIR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentualIR.Name = "lblPercentualIR";
            this.lblPercentualIR.Size = new System.Drawing.Size(169, 29);
            this.lblPercentualIR.TabIndex = 0;
            this.lblPercentualIR.Text = "Percentual IR: ";
            this.lblPercentualIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIR
            // 
            this.txtIR.AllowDrop = true;
            this.txtIR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIR.Location = new System.Drawing.Point(194, 15);
            this.txtIR.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtIR.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(236, 31);
            this.txtIR.TabIndex = 7;
            this.txtIR.Text = "10";
            this.txtIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.grpVenda1.Location = new System.Drawing.Point(217, 40);
            this.grpVenda1.Name = "grpVenda1";
            this.grpVenda1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpVenda1.Size = new System.Drawing.Size(491, 249);
            this.grpVenda1.TabIndex = 0;
            this.grpVenda1.TabStop = false;
            // 
            // lblValorMedio
            // 
            this.lblValorMedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorMedio.AutoSize = true;
            this.lblValorMedio.BackColor = System.Drawing.Color.Transparent;
            this.lblValorMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorMedio.Location = new System.Drawing.Point(6, 96);
            this.lblValorMedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorMedio.Name = "lblValorMedio";
            this.lblValorMedio.Size = new System.Drawing.Size(188, 29);
            this.lblValorMedio.TabIndex = 0;
            this.lblValorMedio.Text = "Valor da Médio: ";
            this.lblValorMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorMedio
            // 
            this.txtValorMedio.AllowDrop = true;
            this.txtValorMedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorMedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMedio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorMedio.Location = new System.Drawing.Point(194, 91);
            this.txtValorMedio.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtValorMedio.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtValorMedio.Name = "txtValorMedio";
            this.txtValorMedio.Size = new System.Drawing.Size(236, 31);
            this.txtValorMedio.TabIndex = 3;
            this.txtValorMedio.Text = "0";
            this.txtValorMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbAcao
            // 
            this.cmbAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbAcao.FormattingEnabled = true;
            this.cmbAcao.Location = new System.Drawing.Point(194, 15);
            this.cmbAcao.MaximumSize = new System.Drawing.Size(300, 0);
            this.cmbAcao.MinimumSize = new System.Drawing.Size(150, 0);
            this.cmbAcao.Name = "cmbAcao";
            this.cmbAcao.Size = new System.Drawing.Size(236, 33);
            this.cmbAcao.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(194, 130);
            this.txtData.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtData.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(236, 31);
            this.txtData.TabIndex = 4;
            this.txtData.Value = new System.DateTime(2017, 5, 16, 19, 40, 33, 0);
            // 
            // txtBruto
            // 
            this.txtBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBruto.ForeColor = System.Drawing.Color.Blue;
            this.txtBruto.Location = new System.Drawing.Point(194, 204);
            this.txtBruto.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtBruto.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtBruto.Multiline = true;
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.ReadOnly = true;
            this.txtBruto.Size = new System.Drawing.Size(236, 31);
            this.txtBruto.TabIndex = 6;
            this.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorDaAcao
            // 
            this.lblValorDaAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorDaAcao.AutoSize = true;
            this.lblValorDaAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDaAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorDaAcao.Location = new System.Drawing.Point(7, 53);
            this.lblValorDaAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorDaAcao.Name = "lblValorDaAcao";
            this.lblValorDaAcao.Size = new System.Drawing.Size(168, 29);
            this.lblValorDaAcao.TabIndex = 0;
            this.lblValorDaAcao.Text = "Valor da Ação:";
            this.lblValorDaAcao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantidade.Location = new System.Drawing.Point(7, 171);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(160, 29);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorDaAcao
            // 
            this.txtValorDaAcao.AllowDrop = true;
            this.txtValorDaAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDaAcao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorDaAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorDaAcao.Location = new System.Drawing.Point(194, 54);
            this.txtValorDaAcao.MaximumSize = new System.Drawing.Size(300, 31);
            this.txtValorDaAcao.MinimumSize = new System.Drawing.Size(150, 31);
            this.txtValorDaAcao.Name = "txtValorDaAcao";
            this.txtValorDaAcao.Size = new System.Drawing.Size(236, 31);
            this.txtValorDaAcao.TabIndex = 2;
            this.txtValorDaAcao.Text = "0";
            this.txtValorDaAcao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorDaAcao.TextChanged += new System.EventHandler(this.txtValorDaAcao_TextChanged_1);
            this.txtValorDaAcao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDaAcao_KeyPress_1);
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblData.Location = new System.Drawing.Point(7, 134);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(176, 29);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data da Venda:";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAcao
            // 
            this.lblAcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcao.AutoSize = true;
            this.lblAcao.BackColor = System.Drawing.Color.Transparent;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcao.Location = new System.Drawing.Point(7, 15);
            this.lblAcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(73, 29);
            this.lblAcao.TabIndex = 0;
            this.lblAcao.Text = "Ação:";
            this.lblAcao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numQuantidade.Location = new System.Drawing.Point(194, 167);
            this.numQuantidade.MaximumSize = new System.Drawing.Size(300, 0);
            this.numQuantidade.MinimumSize = new System.Drawing.Size(150, 0);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(236, 31);
            this.numQuantidade.TabIndex = 5;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantidade.ValueChanged += new System.EventHandler(this.numQuantidade_ValueChanged_1);
            this.numQuantidade.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numQuantidade_Scroll_1);
            // 
            // lblBruto
            // 
            this.lblBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBruto.AutoSize = true;
            this.lblBruto.BackColor = System.Drawing.Color.Transparent;
            this.lblBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBruto.Location = new System.Drawing.Point(7, 206);
            this.lblBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(158, 29);
            this.lblBruto.TabIndex = 0;
            this.lblBruto.Text = "Valor (bruto) :";
            this.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdVender
            // 
            this.cmdVender.BackColor = System.Drawing.Color.Black;
            this.cmdVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVender.ForeColor = System.Drawing.Color.White;
            this.cmdVender.Location = new System.Drawing.Point(403, 438);
            this.cmdVender.Name = "cmdVender";
            this.cmdVender.Size = new System.Drawing.Size(140, 40);
            this.cmdVender.TabIndex = 14;
            this.cmdVender.Text = "VENDER";
            this.cmdVender.UseVisualStyleBackColor = false;
            this.cmdVender.Click += new System.EventHandler(this.cmdVender_Click);
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 690);
            this.Controls.Add(this.cmdVender);
            this.Controls.Add(this.gprVenda2);
            this.Controls.Add(this.grpVenda1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVender";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormVender";
            this.Load += new System.EventHandler(this.FormVender_Load);
            this.gprVenda2.ResumeLayout(false);
            this.gprVenda2.PerformLayout();
            this.grpVenda1.ResumeLayout(false);
            this.grpVenda1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gprVenda2;
        private System.Windows.Forms.Label lblLiquido;
        private System.Windows.Forms.TextBox txtLiquido;
        private System.Windows.Forms.Label lblIRTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPercentualIR;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.GroupBox grpVenda1;
        private System.Windows.Forms.Label lblValorMedio;
        private System.Windows.Forms.TextBox txtValorMedio;
        private System.Windows.Forms.ComboBox cmbAcao;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Label lblValorDaAcao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtValorDaAcao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Button cmdVender;
    }
}