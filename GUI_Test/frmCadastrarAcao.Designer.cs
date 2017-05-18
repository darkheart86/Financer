namespace GUI_Test
{
    partial class frmCadastrarAcao
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
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCadastrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmpresa.Location = new System.Drawing.Point(107, 59);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(148, 21);
            this.txtEmpresa.TabIndex = 32;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.txtEmpresa_TextChanged);
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(33, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Empresa:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblID.Location = new System.Drawing.Point(105, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ação:";
            // 
            // cmdCadastrar
            // 
            this.cmdCadastrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCadastrar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmdCadastrar.Location = new System.Drawing.Point(36, 108);
            this.cmdCadastrar.Name = "cmdCadastrar";
            this.cmdCadastrar.Size = new System.Drawing.Size(101, 23);
            this.cmdCadastrar.TabIndex = 33;
            this.cmdCadastrar.Text = "&Cadastrar";
            this.cmdCadastrar.UseVisualStyleBackColor = false;
            this.cmdCadastrar.Click += new System.EventHandler(this.cmdCadastrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCancelar.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.cmdCancelar.Location = new System.Drawing.Point(144, 108);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(101, 23);
            this.cmdCancelar.TabIndex = 34;
            this.cmdCancelar.Text = "Cancela&r";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmCadastrarAcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 174);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdCadastrar);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCadastrarAcao";
            this.Text = "Cadastrar Ação";
            this.Load += new System.EventHandler(this.frmCadastrarAcao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCadastrar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}