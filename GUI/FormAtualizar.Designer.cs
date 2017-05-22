namespace GUI
{
    partial class FormAtualizar
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoAcao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcao = new System.Windows.Forms.Label();
            this.chkInativo = new System.Windows.Forms.CheckBox();
            this.txtNomeAcao = new System.Windows.Forms.TextBox();
            this.cmbAcoes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome da ação: ";
            // 
            // txtCodigoAcao
            // 
            this.txtCodigoAcao.Enabled = false;
            this.txtCodigoAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAcao.Location = new System.Drawing.Point(221, 80);
            this.txtCodigoAcao.Name = "txtCodigoAcao";
            this.txtCodigoAcao.Size = new System.Drawing.Size(236, 31);
            this.txtCodigoAcao.TabIndex = 5;
            this.txtCodigoAcao.TextChanged += new System.EventHandler(this.txtCodigoAcao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código da ação: ";
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.Location = new System.Drawing.Point(6, 25);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(211, 29);
            this.lblAcao.TabIndex = 3;
            this.lblAcao.Text = "Selecione a ação: ";
            // 
            // chkInativo
            // 
            this.chkInativo.AutoSize = true;
            this.chkInativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInativo.Location = new System.Drawing.Point(168, 191);
            this.chkInativo.Name = "chkInativo";
            this.chkInativo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkInativo.Size = new System.Drawing.Size(101, 33);
            this.chkInativo.TabIndex = 2;
            this.chkInativo.Text = "Inativo";
            this.chkInativo.UseVisualStyleBackColor = true;
            // 
            // txtNomeAcao
            // 
            this.txtNomeAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAcao.Location = new System.Drawing.Point(221, 133);
            this.txtNomeAcao.Name = "txtNomeAcao";
            this.txtNomeAcao.Size = new System.Drawing.Size(236, 31);
            this.txtNomeAcao.TabIndex = 1;
            this.txtNomeAcao.TextChanged += new System.EventHandler(this.txtNomeAcao_TextChanged);
            // 
            // cmbAcoes
            // 
            this.cmbAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcoes.FormattingEnabled = true;
            this.cmbAcoes.Location = new System.Drawing.Point(221, 21);
            this.cmbAcoes.Name = "cmbAcoes";
            this.cmbAcoes.Size = new System.Drawing.Size(236, 33);
            this.cmbAcoes.TabIndex = 0;
            this.cmbAcoes.SelectedIndexChanged += new System.EventHandler(this.cmbAcoes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblAcao);
            this.groupBox2.Controls.Add(this.txtNomeAcao);
            this.groupBox2.Controls.Add(this.txtCodigoAcao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkInativo);
            this.groupBox2.Controls.Add(this.cmbAcoes);
            this.groupBox2.Location = new System.Drawing.Point(217, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(491, 230);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Black;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(403, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 40);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // FormAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 690);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAtualizar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormAtualizar";
            this.Load += new System.EventHandler(this.FormAtualizar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoAcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.CheckBox chkInativo;
        private System.Windows.Forms.TextBox txtNomeAcao;
        private System.Windows.Forms.ComboBox cmbAcoes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
    }
}