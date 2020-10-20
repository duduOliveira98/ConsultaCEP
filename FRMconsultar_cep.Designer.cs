namespace ConsutarCeps
{
    partial class FRMconsultar_cep
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
            this.label1 = new System.Windows.Forms.Label();
            this.txCep = new System.Windows.Forms.TextBox();
            this.ENDERECO = new System.Windows.Forms.GroupBox();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txRua = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.ENDERECO.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP:";
            // 
            // txCep
            // 
            this.txCep.BackColor = System.Drawing.SystemColors.Info;
            this.txCep.Location = new System.Drawing.Point(32, 62);
            this.txCep.Name = "txCep";
            this.txCep.Size = new System.Drawing.Size(184, 22);
            this.txCep.TabIndex = 1;
            // 
            // ENDERECO
            // 
            this.ENDERECO.Controls.Add(this.txRua);
            this.ENDERECO.Controls.Add(this.label6);
            this.ENDERECO.Controls.Add(this.label4);
            this.ENDERECO.Controls.Add(this.txEstado);
            this.ENDERECO.Controls.Add(this.label5);
            this.ENDERECO.Controls.Add(this.txBairro);
            this.ENDERECO.Controls.Add(this.label3);
            this.ENDERECO.Controls.Add(this.txCidade);
            this.ENDERECO.Controls.Add(this.label2);
            this.ENDERECO.Location = new System.Drawing.Point(32, 100);
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.Size = new System.Drawing.Size(498, 248);
            this.ENDERECO.TabIndex = 2;
            this.ENDERECO.TabStop = false;
            this.ENDERECO.Text = "RESULTADO";
            // 
            // txCidade
            // 
            this.txCidade.BackColor = System.Drawing.Color.LightGray;
            this.txCidade.Location = new System.Drawing.Point(21, 98);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(428, 22);
            this.txCidade.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "CIDADE:";
            // 
            // txBairro
            // 
            this.txBairro.BackColor = System.Drawing.Color.LightGray;
            this.txBairro.Location = new System.Drawing.Point(21, 143);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(428, 22);
            this.txBairro.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "BAIRRO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ESTADO:";
            // 
            // txEstado
            // 
            this.txEstado.BackColor = System.Drawing.Color.LightGray;
            this.txEstado.Location = new System.Drawing.Point(21, 53);
            this.txEstado.Name = "txEstado";
            this.txEstado.Size = new System.Drawing.Size(428, 22);
            this.txEstado.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "RUA:";
            // 
            // txRua
            // 
            this.txRua.BackColor = System.Drawing.Color.LightGray;
            this.txRua.Location = new System.Drawing.Point(21, 188);
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(428, 22);
            this.txRua.TabIndex = 10;
            // 
            // btConsultar
            // 
            this.btConsultar.BackgroundImage = global::ConsutarCeps.Properties.Resources.busca_cep;
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultar.Location = new System.Drawing.Point(300, 36);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(181, 58);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLimpar.Image = global::ConsutarCeps.Properties.Resources.limpar;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(270, 354);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(135, 47);
            this.btLimpar.TabIndex = 4;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Image = global::ConsutarCeps.Properties.Resources.sair;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(411, 354);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(139, 47);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // FRMconsultar_cep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(581, 413);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.ENDERECO);
            this.Controls.Add(this.txCep);
            this.Controls.Add(this.label1);
            this.Name = "FRMconsultar_cep";
            this.Text = "Form1";
            this.ENDERECO.ResumeLayout(false);
            this.ENDERECO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCep;
        private System.Windows.Forms.GroupBox ENDERECO;
        private System.Windows.Forms.TextBox txRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
    }
}

