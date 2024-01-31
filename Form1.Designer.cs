using System.Windows.Forms;

namespace Calculadora
{
    partial class formCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculadora));
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnIgualdade = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.KeyPreview = true;
            this.KeyDown += (sender, e) => TrataAtalhos(e);

            // 
            // txtOperacao
            // 
            this.txtOperacao.BackColor = System.Drawing.Color.Black;
            this.txtOperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperacao.CausesValidation = false;
            this.txtOperacao.ForeColor = System.Drawing.Color.White;
            this.txtOperacao.Location = new System.Drawing.Point(12, 14);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.ReadOnly = true;
            this.txtOperacao.Size = new System.Drawing.Size(318, 13);
            this.txtOperacao.TabIndex = 0;
            this.txtOperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Black;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.CausesValidation = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(12, 27);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(318, 31);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUm
            // 
            this.btnUm.FlatAppearance.BorderSize = 0;
            this.btnUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.ForeColor = System.Drawing.Color.White;
            this.btnUm.Location = new System.Drawing.Point(12, 233);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(75, 26);
            this.btnUm.TabIndex = 2;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnDois
            // 
            this.btnDois.FlatAppearance.BorderSize = 0;
            this.btnDois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDois.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.ForeColor = System.Drawing.Color.White;
            this.btnDois.Location = new System.Drawing.Point(93, 233);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(75, 26);
            this.btnDois.TabIndex = 3;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnTres
            // 
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(174, 233);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 26);
            this.btnTres.TabIndex = 4;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.FlatAppearance.BorderSize = 0;
            this.btnQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuatro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.ForeColor = System.Drawing.Color.White;
            this.btnQuatro.Location = new System.Drawing.Point(12, 204);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(75, 26);
            this.btnQuatro.TabIndex = 5;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.FlatAppearance.BorderSize = 0;
            this.btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.ForeColor = System.Drawing.Color.White;
            this.btnCinco.Location = new System.Drawing.Point(93, 204);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 26);
            this.btnCinco.TabIndex = 6;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.FlatAppearance.BorderSize = 0;
            this.btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.ForeColor = System.Drawing.Color.White;
            this.btnSeis.Location = new System.Drawing.Point(174, 204);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 26);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnSete
            // 
            this.btnSete.FlatAppearance.BorderSize = 0;
            this.btnSete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.ForeColor = System.Drawing.Color.White;
            this.btnSete.Location = new System.Drawing.Point(12, 175);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(75, 26);
            this.btnSete.TabIndex = 8;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnOito
            // 
            this.btnOito.FlatAppearance.BorderSize = 0;
            this.btnOito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.ForeColor = System.Drawing.Color.White;
            this.btnOito.Location = new System.Drawing.Point(93, 175);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(75, 26);
            this.btnOito.TabIndex = 9;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.FlatAppearance.BorderSize = 0;
            this.btnNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.ForeColor = System.Drawing.Color.White;
            this.btnNove.Location = new System.Drawing.Point(174, 175);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(75, 26);
            this.btnNove.TabIndex = 10;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.FlatAppearance.BorderSize = 0;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.Color.White;
            this.btnVirgula.Location = new System.Drawing.Point(12, 262);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(75, 26);
            this.btnVirgula.TabIndex = 11;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(93, 262);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 26);
            this.btnZero.TabIndex = 12;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnIgualdade
            // 
            this.btnIgualdade.FlatAppearance.BorderSize = 0;
            this.btnIgualdade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgualdade.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgualdade.ForeColor = System.Drawing.Color.White;
            this.btnIgualdade.Location = new System.Drawing.Point(174, 262);
            this.btnIgualdade.Name = "btnIgualdade";
            this.btnIgualdade.Size = new System.Drawing.Size(75, 26);
            this.btnIgualdade.TabIndex = 13;
            this.btnIgualdade.Text = "=";
            this.btnIgualdade.UseVisualStyleBackColor = true;
            this.btnIgualdade.Click += new System.EventHandler(this.btnIgualdade_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.Color.White;
            this.btnAdicao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.ForeColor = System.Drawing.Color.Black;
            this.btnAdicao.Location = new System.Drawing.Point(255, 117);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 26);
            this.btnAdicao.TabIndex = 14;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.White;
            this.btnSubtracao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtracao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.Black;
            this.btnSubtracao.Location = new System.Drawing.Point(255, 146);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 26);
            this.btnSubtracao.TabIndex = 15;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.White;
            this.btnMultiplicacao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplicacao.Location = new System.Drawing.Point(255, 175);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 26);
            this.btnMultiplicacao.TabIndex = 16;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.White;
            this.btnDivisao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.Black;
            this.btnDivisao.Location = new System.Drawing.Point(255, 204);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 26);
            this.btnDivisao.TabIndex = 17;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.Color.White;
            this.btnPotencia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.ForeColor = System.Drawing.Color.Black;
            this.btnPotencia.Location = new System.Drawing.Point(255, 233);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 26);
            this.btnPotencia.TabIndex = 18;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.Color.White;
            this.btnPorcentagem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentagem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.ForeColor = System.Drawing.Color.Black;
            this.btnPorcentagem.Location = new System.Drawing.Point(255, 262);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(75, 26);
            this.btnPorcentagem.TabIndex = 19;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(12, 117);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 26);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // formCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(340, 300);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnIgualdade);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtOperacao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

            void TrataAtalhos(KeyEventArgs e)
            {

                switch (e.KeyCode)
                {
                    case Keys.D0:
                    case Keys.NumPad0:
                        btnZero.PerformClick();
                        break;
                    case Keys.D1:
                    case Keys.NumPad1:
                        btnUm.PerformClick();
                        break;
                    case Keys.D2:
                    case Keys.NumPad2:
                        btnDois.PerformClick();
                        break;
                    case Keys.D3:
                    case Keys.NumPad3:
                        btnTres.PerformClick();
                        break;
                    case Keys.D4:
                    case Keys.NumPad4:
                        btnQuatro.PerformClick();
                        break;
                    case Keys.D5:
                    case Keys.NumPad5:
                        if (e.Shift)
                        {
                            btnPorcentagem.PerformClick();
                        }
                        else
                        {
                            btnCinco.PerformClick();
                        }
                        break;
                    case Keys.Oem5:
                        if (e.Shift)
                        {
                            btnPorcentagem.PerformClick();
                        }
                        break;

                    case Keys.D6:
                    case Keys.NumPad6:
                        btnSeis.PerformClick();
                        break;
                    case Keys.D7:
                    case Keys.NumPad7:
                        btnSete.PerformClick();
                        break;
                    case Keys.D8:
                    case Keys.NumPad8:
                        btnOito.PerformClick();
                        break;
                    case Keys.D9:
                    case Keys.NumPad9:
                        btnNove.PerformClick();
                        break;
                    case Keys.Oemcomma:
                    case Keys.Decimal:
                        btnVirgula.PerformClick();
                        break;
                    case Keys.Add:
                        btnAdicao.PerformClick();
                        break;
                    case Keys.OemMinus:
                        btnSubtracao.PerformClick();
                        break;
                    case Keys.Subtract:
                        btnSubtracao.PerformClick();
                        break;
                    case Keys.Multiply:
                        btnMultiplicacao.PerformClick();
                        break;
                    case Keys.Divide:
                        btnDivisao.PerformClick();
                        break;
                    case Keys.Escape:
                    case Keys.Delete:
                        btnClear.PerformClick();
                        break;
                    case Keys.Oemplus:
                        btnAdicao.PerformClick();
                        break;
                    case Keys.Enter:
                        btnIgualdade.PerformClick();
                        break;
                    case Keys.P:
                        btnPotencia.PerformClick();
                        break;
                }
            }

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnIgualdade;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnClear;
        private TextBox txtResultado;
    }
}

