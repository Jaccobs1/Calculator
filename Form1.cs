using Microsoft.VisualBasic;
using System;

namespace Calculator.Forms
{
    public partial class Form1 : Form
    {
        Metodos metodos = new Metodos();
        double n1 = 0, n2 = 0;
        bool ehIgual, limpar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        //Números
        private void btn0_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "";
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
            }
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (limpar == true)
            {
                txtNum.Visible = false;
                txtVisor.Text = "0";
                limpar = false;
            }
            if (ehIgual == true)
            {
                txtVisor.Text = "";
                ehIgual = false;
            }
            if (txtVisor.Text.Contains(","))
            {

            }
            else
            {
                txtVisor.Text = txtVisor.Text + ",";
            }
        }



        //C e AC
        private void btnC_Click(object sender, EventArgs e)
        {
            if (limpar == false)
            {
                txtNum.Visible = false;
                if (ehIgual == false)
                {
                    txtVisor.Text = "0";
                }
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtNum.Visible = false;
            txtVisor.Text = "0";
            lblSinal3.Text = "";
            ehIgual = false;
        }



        //Operações
        private void btnMais_Click(object sender, EventArgs e)
        {
            if (limpar == false)
            {
                if (lblSinal3.Text != "")
                {
                    n2 = Convert.ToDouble(txtVisor.Text);
                    if (n1 == 0 && n2 == 0 && lblSinal3.Text == "/")
                    {
                        txtVisor.Text = "ERROR!";
                    }
                    else if (lblSinal3.Text == "+")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Adicao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "-")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Subtracao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "x")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Multiplicacao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "/")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Divisao(n1, n2));
                        lblSinal3.Text = "";
                    }
                }
                if (txtVisor.Text != "ERROR!")
                {
                    n1 = double.Parse(txtVisor.Text);
                    txtNum.Visible = true;
                    txtNum.Text = Convert.ToString(n1);
                    txtVisor.Text = "";
                }
            }
            else
            {
                txtVisor.Text = Convert.ToString(n1);
            }
            lblSinal3.Text = "+";
            limpar = true;
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (limpar == false)
            {
                if (lblSinal3.Text != "")
                {
                    n2 = Convert.ToDouble(txtVisor.Text);
                    if (n1 == 0 && n2 == 0 && lblSinal3.Text == "/")
                    {
                        txtVisor.Text = "ERROR!";
                    }
                    else if (lblSinal3.Text == "+")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Adicao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "-")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Subtracao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "x")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Multiplicacao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "/")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Divisao(n1, n2));
                        lblSinal3.Text = "";
                    }
                }
                if (txtVisor.Text != "ERROR!")
                {
                    n1 = double.Parse(txtVisor.Text);
                    txtNum.Visible = true;
                    txtNum.Text = Convert.ToString(n1);
                    txtVisor.Text = "";
                }
            }
            else
            {
                txtVisor.Text = Convert.ToString(n1);
            }
            lblSinal3.Text = "-";
            limpar = true;
        }
        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (limpar == false)
            {
                if (lblSinal3.Text != "")
                {
                    n2 = Convert.ToDouble(txtVisor.Text);
                    if (n1 == 0 && n2 == 0 && lblSinal3.Text == "/")
                    {
                        txtVisor.Text = "ERROR!";
                    }
                    else if (lblSinal3.Text == "+")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Adicao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "-")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Subtracao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "x")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Multiplicacao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "/")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Divisao(n1, n2));
                        lblSinal3.Text = "";
                    }
                }
                if (txtVisor.Text != "ERROR!")
                {
                    n1 = double.Parse(txtVisor.Text);
                    txtNum.Visible = true;
                    txtNum.Text = Convert.ToString(n1);
                    txtVisor.Text = "";
                }
            }
            else
            {
                txtVisor.Text = Convert.ToString(n1);
            }
            lblSinal3.Text = "x";
            limpar = true;
        }
        private void btnDividido_Click(object sender, EventArgs e)
        {
            if (limpar == false)
            {
                if (lblSinal3.Text != "")
                {
                    n2 = Convert.ToDouble(txtVisor.Text);
                    if (n1 == 0 && n2 == 0 && lblSinal3.Text == "/")
                    {
                        txtVisor.Text = "ERROR!";
                    }
                    else if (lblSinal3.Text == "+")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Adicao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "-")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Subtracao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "x")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Multiplicacao(n1, n2));
                        lblSinal3.Text = "";
                    }
                    else if (lblSinal3.Text == "/")
                    {
                        txtVisor.Text = Convert.ToString(metodos.Divisao(n1, n2));
                        lblSinal3.Text = "";
                    }
                }
                if (txtVisor.Text != "ERROR!")
                {
                    n1 = double.Parse(txtVisor.Text);
                    txtNum.Visible = true;
                    txtNum.Text = Convert.ToString(n1);
                    txtVisor.Text = "";
                }
            }
            else
            {
                txtVisor.Text = Convert.ToString(n1);
            }
            lblSinal3.Text = "/";
            limpar = true;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (limpar == false)
            {
                n2 = Convert.ToDouble(txtVisor.Text);
                if (n1 == 0 && n2 == 0 && lblSinal3.Text == "/")
                {
                    txtVisor.Text = "ERROR!";
                }
                else if (lblSinal3.Text == "+")
                {
                    txtVisor.Text = Convert.ToString(metodos.Adicao(n1, n2));
                    lblSinal3.Text = "";
                }
                else if (lblSinal3.Text == "-")
                {
                    txtVisor.Text = Convert.ToString(metodos.Subtracao(n1, n2));
                    lblSinal3.Text = "";
                }
                else if (lblSinal3.Text == "x")
                {
                    txtVisor.Text = Convert.ToString(metodos.Multiplicacao(n1, n2));
                    lblSinal3.Text = "";
                }
                else if (lblSinal3.Text == "/")
                {
                    txtVisor.Text = Convert.ToString(metodos.Divisao(n1, n2));
                    lblSinal3.Text = "";
                }
                ehIgual = true;
            }
        }
    }
}