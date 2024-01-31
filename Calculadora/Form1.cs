using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class formCalculadora : Form
    {
        public formCalculadora()
        {
            InitializeComponent();
        }

        decimal calculo;

        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool porcentagem = false;
        bool potencia = false;

        string apagarCaractere;
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtOperacao.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtOperacao.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtOperacao.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtOperacao.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtOperacao.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtOperacao.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtOperacao.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtOperacao.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtOperacao.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtOperacao.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResultado.Text);


                txtOperacao.Text += "+";
                txtResultado.Text = "";

                adicao = true;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                porcentagem = false;
                potencia = false;
            }
            catch
            {

            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResultado.Text);

                txtOperacao.Text += "-";
                txtResultado.Text = "";

                adicao = false;
                subtracao = true;
                multiplicacao = false;
                divisao = false;
                porcentagem = false;
                potencia = false;
            }
            catch
            {

            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResultado.Text);

                txtOperacao.Text += "×";
                txtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = true;
                divisao = false;
                porcentagem = false;
                potencia = false;
            }
            catch
            {
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResultado.Text);

                txtOperacao.Text += "÷";
                txtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = true;
                porcentagem = false;
                potencia = false;
            }
            catch
            {
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResultado.Text);

                txtOperacao.Text += "^";
                txtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                porcentagem = false;
                potencia = true;
            }
            catch
            {
            }
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                calculo = Convert.ToDecimal(txtResultado.Text);

                txtOperacao.Text += "%";
                txtResultado.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
                porcentagem = true;
                potencia = false;
            }
            catch
            {
            }
        }

        private void btnIgualdade_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "=";

            if (adicao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) + calculo);
                txtOperacao.Text = txtResultado.Text;
            }
            else if (subtracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtResultado.Text));

                txtOperacao.Text = txtResultado.Text;
            }
            else if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) * calculo);
                txtOperacao.Text = txtResultado.Text;
            }
            else if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtResultado.Text));
                txtOperacao.Text = txtResultado.Text;
            }
            else if (potencia == true)
            {
                txtResultado.Text = Convert.ToString(Math.Pow(Convert.ToDouble(calculo), Convert.ToDouble(txtResultado.Text)));
                txtOperacao.Text = txtResultado.Text;
            }
            else if (porcentagem == true)
            {
                txtResultado.Text = Convert.ToString(calculo / 100);
                txtOperacao.Text = txtResultado.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = null;
            txtOperacao.Text = null;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if ((txtResultado.Text.Contains(",") && txtOperacao.Text.Contains(",")) || (txtResultado.Text == ""))
            {

            }
            else
            {
                txtOperacao.Text += ",";
                txtResultado.Text += ",";
            }
        }
    }
}
