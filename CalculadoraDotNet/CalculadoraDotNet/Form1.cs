using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDotNet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= cont; i++)
            {

            }
        }



        // LIMPAR CAMPO
        private void BtnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void BtnCe_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }



        // DIGITOS NUMÉRICOS

        private void Button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }



        // SINAL DE PONTO
        private void BtnPonto_Click(object sender, EventArgs e)
        {
            string ponto = txtResultado.Text;

            if (!ponto.EndsWith(".") || !ponto.EndsWith("+") || !ponto.EndsWith("-") || !ponto.EndsWith("*") || !ponto.EndsWith("/"))
            {
                txtResultado.Text += ".";
            }
        }



        public int cont = 0;
        string[] elementos = new string[100];
        

        // OPERAÇÕES

        private void OpSomar_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.EndsWith("+"))
            {
                elementos[cont] = txtResultado.Text; ;
                cont++;
                string sinalSoma = "+";
                elementos[cont] = sinalSoma;
                cont++;
                txtResultado.Text += "+";
                lblOperacao.Text += txtResultado.Text;
                txtResultado.Text = "";
            }
        }

        private void OpSubtracao_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.EndsWith("-"))
            {
                elementos[cont] = txtResultado.Text; ;
                cont++;
                string sinalSubtracao = "-";
                elementos[cont] = sinalSubtracao;
                cont++;
                txtResultado.Text += "-";
                lblOperacao.Text += txtResultado.Text;
                txtResultado.Text = "";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.EndsWith("*"))
            {
                elementos[cont] = txtResultado.Text; ;
                cont++;
                string sinalMultiplicacao = "*";
                elementos[cont] = sinalMultiplicacao;
                cont++;
                txtResultado.Text += "*";
                lblOperacao.Text += txtResultado.Text;
                txtResultado.Text = "";
            }
        }

        private void OpDivisao_Click(object sender, EventArgs e)
        {
            string sinalDividir = txtResultado.Text;

            if (!sinalDividir.EndsWith("/"))
            {
                if (!txtResultado.Text.EndsWith("/"))
                {
                    elementos[cont] = txtResultado.Text; ;
                    cont++;
                    string sinalDivisao= "/";
                    elementos[cont] = sinalDivisao;
                    cont++;
                    txtResultado.Text += "/";
                    lblOperacao.Text += txtResultado.Text;
                    txtResultado.Text = "";
                }
            }
        }
    }
}
