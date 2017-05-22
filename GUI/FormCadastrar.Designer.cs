namespace GUI
{
    partial class FormCadastrar
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
            this.lblAcao = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.cmdCadastrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAcao
            // 
            this.lblAcao.AutoSize = true;
            this.lblAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcao.Location = new System.Drawing.Point(6, 109);
            this.lblAcao.Name = "lblAcao";
            this.lblAcao.Size = new System.Drawing.Size(73, 29);
            this.lblAcao.TabIndex = 0;
            this.lblAcao.Text = "Ação:";
            this.lblAcao.Click += new System.EventHandler(this.lblACAO_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(6, 21);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(116, 29);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(165, 109);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 29);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(165, 19);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(300, 31);
            this.txtEmpresa.TabIndex = 3;
            this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // cmdCadastrar
            // 
            this.cmdCadastrar.BackColor = System.Drawing.Color.Black;
            this.cmdCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadastrar.ForeColor = System.Drawing.Color.White;
            this.cmdCadastrar.Location = new System.Drawing.Point(403, 382);
            this.cmdCadastrar.Name = "cmdCadastrar";
            this.cmdCadastrar.Size = new System.Drawing.Size(140, 40);
            this.cmdCadastrar.TabIndex = 4;
            this.cmdCadastrar.Text = "CADASTRAR\r\n";
            this.cmdCadastrar.UseVisualStyleBackColor = false;
            this.cmdCadastrar.Click += new System.EventHandler(this.cmdCadastrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.Black;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.Location = new System.Drawing.Point(243, 382);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(140, 40);
            this.cmdCancelar.TabIndex = 5;
            this.cmdCancelar.Text = "LIMPAR";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAcao);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(217, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(491, 152);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCadastrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAcao;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button cmdCadastrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}