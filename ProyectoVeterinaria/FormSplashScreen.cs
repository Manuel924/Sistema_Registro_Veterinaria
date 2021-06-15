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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;

            if (panel1.Width >= 599)
            {
                timerSplash.Stop();
                frmMenu entrada = new frmMenu();
                entrada.Show();
                this.Hide();
            }
        }
    }
}
