
namespace ctrl_de_frota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbVeiculo = new System.Windows.Forms.GroupBox();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.btnCarro = new System.Windows.Forms.Button();
            this.pnlCarro = new System.Windows.Forms.Panel();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.pnlCaminhao = new System.Windows.Forms.Panel();
            this.txtEixos = new System.Windows.Forms.TextBox();
            this.txtKm2 = new System.Windows.Forms.TextBox();
            this.txtPlaca2 = new System.Windows.Forms.TextBox();
            this.txtModelo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEixos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.txtRegistro2 = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistroModelo = new System.Windows.Forms.Label();
            this.lblRegistroPlaca = new System.Windows.Forms.Label();
            this.lblRegistroKm = new System.Windows.Forms.Label();
            this.lblRegistroEixo = new System.Windows.Forms.Label();
            this.gbVeiculo.SuspendLayout();
            this.pnlCarro.SuspendLayout();
            this.pnlCaminhao.SuspendLayout();
            this.gbRegistro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVeiculo
            // 
            this.gbVeiculo.Controls.Add(this.btnCaminhao);
            this.gbVeiculo.Controls.Add(this.btnCarro);
            this.gbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVeiculo.ForeColor = System.Drawing.Color.Coral;
            this.gbVeiculo.Location = new System.Drawing.Point(12, 12);
            this.gbVeiculo.Name = "gbVeiculo";
            this.gbVeiculo.Size = new System.Drawing.Size(323, 100);
            this.gbVeiculo.TabIndex = 0;
            this.gbVeiculo.TabStop = false;
            this.gbVeiculo.Text = "Selecione o Tipo de Veículo";
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCaminhao.Location = new System.Drawing.Point(174, 38);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(123, 37);
            this.btnCaminhao.TabIndex = 1;
            this.btnCaminhao.Text = "Caminhão";
            this.btnCaminhao.UseVisualStyleBackColor = true;
            this.btnCaminhao.Click += new System.EventHandler(this.btnCaminhao_Click);
            // 
            // btnCarro
            // 
            this.btnCarro.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCarro.Location = new System.Drawing.Point(26, 38);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(123, 37);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // pnlCarro
            // 
            this.pnlCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCarro.Controls.Add(this.txtKm);
            this.pnlCarro.Controls.Add(this.txtPlaca);
            this.pnlCarro.Controls.Add(this.txtModelo);
            this.pnlCarro.Controls.Add(this.lblKm);
            this.pnlCarro.Controls.Add(this.lblPlaca);
            this.pnlCarro.Controls.Add(this.lblModelo);
            this.pnlCarro.Location = new System.Drawing.Point(12, 118);
            this.pnlCarro.Name = "pnlCarro";
            this.pnlCarro.Size = new System.Drawing.Size(618, 134);
            this.pnlCarro.TabIndex = 1;
            this.pnlCarro.Visible = false;
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(66, 92);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(106, 24);
            this.txtKm.TabIndex = 2;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(85, 57);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(500, 24);
            this.txtPlaca.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(100, 20);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(485, 24);
            this.txtModelo.TabIndex = 0;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblKm.Location = new System.Drawing.Point(22, 91);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(39, 20);
            this.lblKm.TabIndex = 0;
            this.lblKm.Text = "Km:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblPlaca.Location = new System.Drawing.Point(21, 56);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(58, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblModelo.Location = new System.Drawing.Point(21, 19);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(72, 20);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo:";
            // 
            // pnlCaminhao
            // 
            this.pnlCaminhao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlCaminhao.Controls.Add(this.txtEixos);
            this.pnlCaminhao.Controls.Add(this.txtKm2);
            this.pnlCaminhao.Controls.Add(this.txtPlaca2);
            this.pnlCaminhao.Controls.Add(this.txtModelo2);
            this.pnlCaminhao.Controls.Add(this.label1);
            this.pnlCaminhao.Controls.Add(this.label3);
            this.pnlCaminhao.Controls.Add(this.lblEixos);
            this.pnlCaminhao.Controls.Add(this.label4);
            this.pnlCaminhao.Location = new System.Drawing.Point(12, 118);
            this.pnlCaminhao.Name = "pnlCaminhao";
            this.pnlCaminhao.Size = new System.Drawing.Size(618, 134);
            this.pnlCaminhao.TabIndex = 2;
            this.pnlCaminhao.Visible = false;
            // 
            // txtEixos
            // 
            this.txtEixos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEixos.Location = new System.Drawing.Point(258, 92);
            this.txtEixos.Name = "txtEixos";
            this.txtEixos.Size = new System.Drawing.Size(106, 24);
            this.txtEixos.TabIndex = 3;
            // 
            // txtKm2
            // 
            this.txtKm2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm2.Location = new System.Drawing.Point(66, 92);
            this.txtKm2.Name = "txtKm2";
            this.txtKm2.Size = new System.Drawing.Size(106, 24);
            this.txtKm2.TabIndex = 2;
            // 
            // txtPlaca2
            // 
            this.txtPlaca2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca2.Location = new System.Drawing.Point(85, 57);
            this.txtPlaca2.Name = "txtPlaca2";
            this.txtPlaca2.Size = new System.Drawing.Size(500, 24);
            this.txtPlaca2.TabIndex = 1;
            // 
            // txtModelo2
            // 
            this.txtModelo2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo2.Location = new System.Drawing.Point(100, 20);
            this.txtModelo2.Name = "txtModelo2";
            this.txtModelo2.Size = new System.Drawing.Size(485, 24);
            this.txtModelo2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Km:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Placa:";
            // 
            // lblEixos
            // 
            this.lblEixos.AutoSize = true;
            this.lblEixos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEixos.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblEixos.Location = new System.Drawing.Point(195, 91);
            this.lblEixos.Name = "lblEixos";
            this.lblEixos.Size = new System.Drawing.Size(57, 20);
            this.lblEixos.TabIndex = 0;
            this.lblEixos.Text = "Eixos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OliveDrab;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Modelo:";
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.panel1);
            this.gbRegistro.Controls.Add(this.txtRegistro2);
            this.gbRegistro.Controls.Add(this.txtRegistro);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.ForeColor = System.Drawing.Color.Coral;
            this.gbRegistro.Location = new System.Drawing.Point(12, 258);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(617, 344);
            this.gbRegistro.TabIndex = 3;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro";
            // 
            // txtRegistro2
            // 
            this.txtRegistro2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtRegistro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro2.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRegistro2.Location = new System.Drawing.Point(6, 49);
            this.txtRegistro2.Multiline = true;
            this.txtRegistro2.Name = "txtRegistro2";
            this.txtRegistro2.Size = new System.Drawing.Size(605, 289);
            this.txtRegistro2.TabIndex = 0;
            this.txtRegistro2.Visible = false;
            // 
            // txtRegistro
            // 
            this.txtRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.ForeColor = System.Drawing.SystemColors.Info;
            this.txtRegistro.Location = new System.Drawing.Point(6, 49);
            this.txtRegistro.Multiline = true;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(605, 289);
            this.txtRegistro.TabIndex = 0;
            this.txtRegistro.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSalvar.Location = new System.Drawing.Point(427, 50);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 37);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRegistroEixo);
            this.panel1.Controls.Add(this.lblRegistroKm);
            this.panel1.Controls.Add(this.lblRegistroPlaca);
            this.panel1.Controls.Add(this.lblRegistroModelo);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 22);
            this.panel1.TabIndex = 1;
            // 
            // lblRegistroModelo
            // 
            this.lblRegistroModelo.AutoSize = true;
            this.lblRegistroModelo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroModelo.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroModelo.Location = new System.Drawing.Point(3, 6);
            this.lblRegistroModelo.Name = "lblRegistroModelo";
            this.lblRegistroModelo.Size = new System.Drawing.Size(61, 16);
            this.lblRegistroModelo.TabIndex = 0;
            this.lblRegistroModelo.Text = "Modelo |";
            // 
            // lblRegistroPlaca
            // 
            this.lblRegistroPlaca.AutoSize = true;
            this.lblRegistroPlaca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroPlaca.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroPlaca.Location = new System.Drawing.Point(140, 6);
            this.lblRegistroPlaca.Name = "lblRegistroPlaca";
            this.lblRegistroPlaca.Size = new System.Drawing.Size(56, 16);
            this.lblRegistroPlaca.TabIndex = 0;
            this.lblRegistroPlaca.Text = " | Placa |";
            // 
            // lblRegistroKm
            // 
            this.lblRegistroKm.AutoSize = true;
            this.lblRegistroKm.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroKm.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroKm.Location = new System.Drawing.Point(292, 6);
            this.lblRegistroKm.Name = "lblRegistroKm";
            this.lblRegistroKm.Size = new System.Drawing.Size(41, 16);
            this.lblRegistroKm.TabIndex = 0;
            this.lblRegistroKm.Text = "| Km |";
            // 
            // lblRegistroEixo
            // 
            this.lblRegistroEixo.AutoSize = true;
            this.lblRegistroEixo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroEixo.ForeColor = System.Drawing.Color.Gray;
            this.lblRegistroEixo.Location = new System.Drawing.Point(424, 6);
            this.lblRegistroEixo.Name = "lblRegistroEixo";
            this.lblRegistroEixo.Size = new System.Drawing.Size(45, 16);
            this.lblRegistroEixo.TabIndex = 0;
            this.lblRegistroEixo.Text = "| Eixos";
            this.lblRegistroEixo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(640, 605);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.pnlCaminhao);
            this.Controls.Add(this.pnlCarro);
            this.Controls.Add(this.gbVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Frota";
            this.gbVeiculo.ResumeLayout(false);
            this.pnlCarro.ResumeLayout(false);
            this.pnlCarro.PerformLayout();
            this.pnlCaminhao.ResumeLayout(false);
            this.pnlCaminhao.PerformLayout();
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbVeiculo;
        private System.Windows.Forms.Panel pnlCarro;
        private System.Windows.Forms.TextBox txtEixos;
        private System.Windows.Forms.Label lblEixos;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnCaminhao;
        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Panel pnlCaminhao;
        private System.Windows.Forms.TextBox txtKm2;
        private System.Windows.Forms.TextBox txtPlaca2;
        private System.Windows.Forms.TextBox txtModelo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtRegistro2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistroKm;
        private System.Windows.Forms.Label lblRegistroPlaca;
        private System.Windows.Forms.Label lblRegistroModelo;
        private System.Windows.Forms.Label lblRegistroEixo;
    }
}

