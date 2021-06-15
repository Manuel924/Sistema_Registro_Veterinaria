using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVeterinaria
{
    public partial class frmLogin : Form
    {
        /* Se crea una variable privada para el conteo de 
        contraseñas o usuarios para que finalice.
        */
        private int intentos = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            //Identifica si se ha ingresado correctamente los datos, accedera a la siguiente pesteña
            if (txtUsuario.Text == "DOCENTE" && txtContraseña.Text == "12345")
            {
                FormSplashScreen nuevo = new FormSplashScreen();
                nuevo.Show();
                Visible = false;

            }
            else
            {
                intentos = intentos + 1;
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA\nESTE ES EL INTENTO " + intentos, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //se cerrara el programa despues de 3 intentos fallidos por el usuario
            if (intentos == 3)
            {
                MessageBox.Show("Se ha introducido la contraseña incorrecta 3 veces! \n\nEste programa se cerrara!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); //Cerrara el programa
            }
        }
    }
}
