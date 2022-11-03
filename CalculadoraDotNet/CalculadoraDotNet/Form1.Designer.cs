
namespace CalculadoraDotNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.opSoma = new System.Windows.Forms.Button();
            this.btnCe = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.opSubtracao = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.opMultiplicacao = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.opDivisao = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(27, 29);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(249, 23);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(27, 282);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 15);
            this.lblOperacao.TabIndex = 1;
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(27, 69);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(45, 47);
            this.btnSete.TabIndex = 2;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(78, 69);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(45, 47);
            this.btnOito.TabIndex = 3;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.BtnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(129, 69);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(45, 47);
            this.btnNove.TabIndex = 4;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.BtnNove_Click);
            // 
            // opSoma
            // 
            this.opSoma.Location = new System.Drawing.Point(180, 69);
            this.opSoma.Name = "opSoma";
            this.opSoma.Size = new System.Drawing.Size(45, 47);
            this.opSoma.TabIndex = 5;
            this.opSoma.Text = "+";
            this.opSoma.UseVisualStyleBackColor = true;
            this.opSoma.Click += new System.EventHandler(this.OpSomar_Click);
            // 
            // btnCe
            // 
            this.btnCe.Location = new System.Drawing.Point(231, 69);
            this.btnCe.Name = "btnCe";
            this.btnCe.Size = new System.Drawing.Size(45, 47);
            this.btnCe.TabIndex = 6;
            this.btnCe.Text = "CE";
            this.btnCe.UseVisualStyleBackColor = true;
            this.btnCe.Click += new System.EventHandler(this.BtnCe_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(231, 122);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(45, 47);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // opSubtracao
            // 
            this.opSubtracao.Location = new System.Drawing.Point(180, 122);
            this.opSubtracao.Name = "opSubtracao";
            this.opSubtracao.Size = new System.Drawing.Size(45, 47);
            this.opSubtracao.TabIndex = 10;
            this.opSubtracao.Text = "-";
            this.opSubtracao.UseVisualStyleBackColor = true;
            this.opSubtracao.Click += new System.EventHandler(this.OpSubtracao_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(129, 122);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(45, 47);
            this.btnSeis.TabIndex = 9;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.BtnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(78, 122);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(45, 47);
            this.btnCinco.TabIndex = 8;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.BtnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(27, 122);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(45, 47);
            this.btnQuatro.TabIndex = 7;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.Button10_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(231, 175);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(45, 100);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.Button11_Click);
            // 
            // opMultiplicacao
            // 
            this.opMultiplicacao.Location = new System.Drawing.Point(180, 175);
            this.opMultiplicacao.Name = "opMultiplicacao";
            this.opMultiplicacao.Size = new System.Drawing.Size(45, 47);
            this.opMultiplicacao.TabIndex = 15;
            this.opMultiplicacao.Text = "x";
            this.opMultiplicacao.UseVisualStyleBackColor = true;
            this.opMultiplicacao.Click += new System.EventHandler(this.Button12_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(129, 175);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(45, 47);
            this.btnTres.TabIndex = 14;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.BtnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(78, 175);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(45, 47);
            this.btnDois.TabIndex = 13;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.BtnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(27, 175);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(45, 47);
            this.btnUm.TabIndex = 12;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.BtnUm_Click);
            // 
            // opDivisao
            // 
            this.opDivisao.Location = new System.Drawing.Point(180, 228);
            this.opDivisao.Name = "opDivisao";
            this.opDivisao.Size = new System.Drawing.Size(45, 47);
            this.opDivisao.TabIndex = 20;
            this.opDivisao.Text = "/";
            this.opDivisao.UseVisualStyleBackColor = true;
            this.opDivisao.Click += new System.EventHandler(this.OpDivisao_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(129, 228);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(45, 47);
            this.btnPonto.TabIndex = 19;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.BtnPonto_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(27, 228);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(96, 47);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.Button20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 306);
            this.Controls.Add(this.opDivisao);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.opMultiplicacao);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.opSubtracao);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnCe);
            this.Controls.Add(this.opSoma);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button opSoma;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button opSubtracao;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button opMultiplicacao;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button opDivisao;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnZero;
        public System.Windows.Forms.Label lblOperacao;
    }
}

