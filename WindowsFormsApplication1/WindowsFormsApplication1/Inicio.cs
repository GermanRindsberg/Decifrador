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
        public string nombre = "";
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtNombre.Text == "Ingresa tu nombre")
            {
                MessageBox.Show("Debes ingresar un nombre de usuario", "ATENCION JUGADOR");
            }
            else
            {
                nombre = txtNombre.Text;
            }

            if (rbNormal.Checked == true)
            {
                Normal normal = new Normal();
                normal.lblBienvenido.Text = "Hola "+nombre+", mucha suerte!";
                normal.Show();
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
    }
}
