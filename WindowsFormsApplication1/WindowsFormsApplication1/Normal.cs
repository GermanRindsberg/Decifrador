using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    

    public partial class Normal : Form
    {
        public int contadorDeClicks = 0;
        public string usuario;

        public Normal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num1 = ran.Next(1, 10);
            int num2 = ran.Next(1, 10);
            int num3 = ran.Next(1, 10);
            int num4 = ran.Next(1, 10);

            while (num1 == num2 || num1 == num3 || num1 == num4 ||
                  num2 == num1 || num2 == num3 || num2 == num4 ||
                  num3 == num1 || num3 == num2 || num3 == num4 ||
                  num4 == num1 || num4 == num3 || num4 == num2)
            {
                 num1 = ran.Next(1, 10);
                 num2 = ran.Next(1, 10);
                 num3 = ran.Next(1, 10);
                 num4 = ran.Next(1, 10);
            }

            txtNum1.Text = Convert.ToString(num1);
            txtNum2.Text = Convert.ToString(num2);
            txtNum3.Text = Convert.ToString(num3);
            txtNum4.Text = Convert.ToString(num4);
 
            btnIniciar.Visible = false;
            txtNum1.Visible = false;
            txtNum2.Visible = false;
            txtNum3.Visible = false;
            txtNum4.Visible = false;
            txtUsuario.Visible = false;
            lblMensajeCorrectos.Text = "";
            btnProbar.Visible = true;

            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";


            txt1.Visible = true;
            txt2.Visible = true;
            txt3.Visible = true;
            txt4.Visible = true;
            txt1.Focus();
        }

        private void btnProbar_Click_1(object sender, EventArgs e)
        {
            String num1 = txt1.Text;
            String num2 = txt2.Text;
            String num3 = txt3.Text;
            String num4 = txt4.Text;

            int contadorCorrectos = 0;
            int contadorIncorrectos = 0;

            //evito que se repitan los numeros
            if (num1 == num2 || num1 == num3 || num1 == num4 || num2 == num3 || num2 == num4 || num3 == num4)
            {
                lblMensajeCorrectos.Text = "No se deben repetir numeros";
                lblMensajeCorrectos.Visible = true;
                return;
            }

            else
            {

                if (num1 == txtNum1.Text || num1 == txtNum2.Text || num1 == txtNum3.Text || num1 == txtNum4.Text)
                {
                    if (num1 == txtNum1.Text)
                    {
                        contadorCorrectos++;
                    }
                    else
                    {
                        contadorIncorrectos++;
                    }
                }
                if (num2 == txtNum1.Text || num2 == txtNum2.Text || num2 == txtNum3.Text || num2 == txtNum4.Text)
                {
                    if (num2 == txtNum2.Text)
                    {
                        contadorCorrectos++;
                    }
                    else
                    {
                        contadorIncorrectos++;
                    }
                }
                if (num3 == txtNum1.Text || num3 == txtNum2.Text || num3 == txtNum3.Text || num3 == txtNum4.Text)
                {
                    if (num3 == txtNum3.Text)
                    {
                        contadorCorrectos++;
                    }
                    else
                    {
                        contadorIncorrectos++;
                    }
                }
                if (num4 == txtNum1.Text || num4 == txtNum2.Text || num4 == txtNum3.Text || num4 == txtNum4.Text)
                {
                    if (num4 == txtNum4.Text)
                    {
                        contadorCorrectos++;
                    }
                    else
                    {
                        contadorIncorrectos++;
                    }
                }

            }


            lblMensajeCorrectos.Text = "Hay " + contadorCorrectos + " numeros correctos bien ubicados";
            lblMensajeIncorrectos.Text = "Hay " + contadorIncorrectos + " numeros correctos mal ubicados";
            lblMensajeCorrectos.Visible = true;
            lblMensajeIncorrectos.Visible = true;

            if (contadorCorrectos == 4)
            {
                lblMensajeCorrectos.Text = "Felicitaciones, has ganado. En "+ contadorDeClicks +" intentos";
                lblMensajeIncorrectos.Visible = false;
                btnIniciar.Visible = true;
                btnProbar.Visible = false;
                txtNum1.Visible = true;
                txtNum2.Visible = true;
                txtNum3.Visible = true;
                txtNum4.Visible = true;

            }
        }
        
        #region Efectos visuales
        
        private void txt1_TextChanged_1(object sender, EventArgs e)
        {
            lblMensajeCorrectos.Visible = false;
            lblMensajeIncorrectos.Visible = false;

            if (txt1.Text != "" && txt2.Text == "")
            {
                txt2.Focus();
            }
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {
            lblMensajeCorrectos.Visible = false;
            lblMensajeIncorrectos.Visible = false;
            if (txt2.Text != "" && txt3.Text == "")
            {
                txt3.Focus();
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            lblMensajeCorrectos.Visible = false;
            lblMensajeIncorrectos.Visible = false;
            if (txt3.Text != "" && txt4.Text == "")
            {
              txt4.Focus();
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            lblMensajeCorrectos.Visible = false;
            lblMensajeIncorrectos.Visible = false;
        }



        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                txt3.Focus();
            }
            txt4.Text = "";
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                txt2.Focus();
            }
            txt3.Text = "";
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                txt1.Focus();
            }
            txt2.Text="";
        }
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt1.Text = "";
        }
        #endregion

        private void Normal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnProbar_MouseClick(object sender, MouseEventArgs e)
        {
            contadorDeClicks++;
        }
    }
}
