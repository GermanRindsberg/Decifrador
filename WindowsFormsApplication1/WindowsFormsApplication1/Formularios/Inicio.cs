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


    public partial class Inicio : Form
    {
     
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (txtNombre.Text == "" || txtNombre.Text == "Ingresa tu nombre")
            {
                MessageBox.Show("Debes ingresar un nombre de usuario", "ATENCION JUGADOR");
                return;
            }
            else
            {
               nombre = txtNombre.Text;
            }

            if (rbNormal.Checked == true)
            {
                Normal normal = new Normal();
                normal.Show();
                normal.txtUsuario.Text = "Bienvenido "+ nombre + " Mucha suerte!";
                this.Hide();
            }
            if (rbFacil.Checked == true)
            {
                Formularios.Facil facil = new Formularios.Facil();
                facil.Show();
                facil.txtUsuario.Text= "Bienvenido " + nombre + " Mucha suerte!";
                this.Hide();
            }
            if (rbDificil.Checked == true)
            {
                Formularios.Dificil dificil = new Formularios.Dificil();
                dificil.Show();
                dificil.txtUsuario.Text = "Bienvenida/o " + nombre + ", mucha suerte!";
                this.Hide();
            }
        }
      
        #region Efectos visuales
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.ForeColor = Color.Black;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingresa tu nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
