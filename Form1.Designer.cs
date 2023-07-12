namespace Aula03Login
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb01 = new System.Windows.Forms.TextBox();
            this.txb02 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Saldo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Saldo = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.ckb_Aumentar = new System.Windows.Forms.CheckBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Saldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb01
            // 
            this.txb01.BackColor = System.Drawing.Color.GhostWhite;
            this.txb01.Location = new System.Drawing.Point(1, 41);
            this.txb01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb01.Name = "txb01";
            this.txb01.Size = new System.Drawing.Size(331, 26);
            this.txb01.TabIndex = 0;
            // 
            // txb02
            // 
            this.txb02.BackColor = System.Drawing.Color.GhostWhite;
            this.txb02.Location = new System.Drawing.Point(0, 131);
            this.txb02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txb02.Name = "txb02";
            this.txb02.PasswordChar = '*';
            this.txb02.Size = new System.Drawing.Size(332, 26);
            this.txb02.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite seu usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite sua senha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(61, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.txb01);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb02);
            this.panel1.Location = new System.Drawing.Point(61, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 204);
            this.panel1.TabIndex = 5;
            // 
            // panel_Saldo
            // 
            this.panel_Saldo.BackColor = System.Drawing.Color.Crimson;
            this.panel_Saldo.Controls.Add(this.btn_Salvar);
            this.panel_Saldo.Controls.Add(this.ckb_Aumentar);
            this.panel_Saldo.Controls.Add(this.lbl_saldo);
            this.panel_Saldo.Controls.Add(this.txb_Saldo);
            this.panel_Saldo.Controls.Add(this.label3);
            this.panel_Saldo.Location = new System.Drawing.Point(424, 60);
            this.panel_Saldo.Name = "panel_Saldo";
            this.panel_Saldo.Size = new System.Drawing.Size(273, 204);
            this.panel_Saldo.TabIndex = 6;
            this.panel_Saldo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seu Saldo R$";
            // 
            // txb_Saldo
            // 
            this.txb_Saldo.Location = new System.Drawing.Point(35, 101);
            this.txb_Saldo.Name = "txb_Saldo";
            this.txb_Saldo.Size = new System.Drawing.Size(139, 26);
            this.txb_Saldo.TabIndex = 1;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(129, 41);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(16, 18);
            this.lbl_saldo.TabIndex = 3;
            this.lbl_saldo.Text = "0";
            // 
            // ckb_Aumentar
            // 
            this.ckb_Aumentar.AutoSize = true;
            this.ckb_Aumentar.Location = new System.Drawing.Point(44, 62);
            this.ckb_Aumentar.Name = "ckb_Aumentar";
            this.ckb_Aumentar.Size = new System.Drawing.Size(84, 22);
            this.ckb_Aumentar.TabIndex = 4;
            this.ckb_Aumentar.Text = "Aumentar";
            this.ckb_Aumentar.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(180, 98);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 29);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 425);
            this.Controls.Add(this.panel_Saldo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = " Sistema de cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Saldo.ResumeLayout(false);
            this.panel_Saldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb01;
        private System.Windows.Forms.TextBox txb02;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Saldo;
        private System.Windows.Forms.TextBox txb_Saldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckb_Aumentar;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Button btn_Salvar;
    }
}

