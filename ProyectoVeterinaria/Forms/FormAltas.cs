using LibExamen;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVeterinaria.Forms
{
    public partial class FormAltas : Form
    {
        public FormAltas()
        {
            InitializeComponent();
            LoadTheme();
            //Para que no se cambie ni edite el contenido del combobox
            cbTamanio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /* Este boton lo que hace es que genera una ID aleatoria
         * para las mascotas cuando se deseen agregar
         * */
        private void btGenerarID_Click(object sender, EventArgs e)
        {
            string id = "";
            Password generar = new Password();
            id = generar.GenerarPassword(10);
            txtID.Text = id;

            timer1.Start();
            label11.Visible = false;
            mostrarRFC.Visible = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg;*.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccinar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pbImagen.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string NombreMas = txtNombreM.Text;
            string NombreDue = txtNombreD.Text;
            string Raza = txtRaza.Text;
            string Peso = txtPeso.Text;
            string Tamanio = cbTamanio.Text;
            string Enfermedad = txtEnfermedad.Text;
            string Tratamiento = txtTratamiento.Text;
            string Fecha = txtFecha.Text;

            string sql = "INSERT INTO veterinaria (id, nombre, dueño, raza, peso, tamaño, enfermedad, tratamiento, fecha, ruta)"
                    + " VALUES('" + ID + "', '" + NombreMas + "', '" + NombreDue + "', '" + Raza + "', '" + Peso + "', '" + Tamanio + "', '" + Enfermedad
                    + "', '" + Tratamiento + "', '" + Fecha + "', @ruta)";
            /* Dejamos a manera de que @Ruta sea que se modificara mas adelante en el proceso de agregarse
             * a la base de datos en formato de aBites y concluir 
             */

            //Agregar la imagen
            MemoryStream ms = new MemoryStream();
            pbImagen.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("ruta", aByte);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se han guardado correctamente", "AGREGADO CORRECTAMENTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpiamos los textbox si se ingresan correctamente los datos
                txtID.Text = ""; txtNombreD.Text = ""; txtNombreM.Text = "";
                txtRaza.Text = ""; txtPeso.Text = ""; txtEnfermedad.Text = ""; pbImagen.Image = null;
                cbTamanio.Text = ""; txtTratamiento.Text = ""; txtFecha.Text = "Seleccione una fecha";
                progressBar1.Visible = false;
                label13.Visible = false;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un error al cargar los datos\nRevise de nuevo e intente de nuevo", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*Para que solo acepte valores numericos en donde deben de ir 
        ciertos textbox
        */
        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Solo se aceptara un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPeso_Enter(object sender, EventArgs e)
        {
            txtPeso.Text = "";
        }

        private void DTPfecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = DTPfecha.Value.Date;
            txtFecha.Text = DTPfecha.Value.ToString("yyyy-MM-dd");
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecundaryColor;
                }
            }

        }

        private void txtNombreM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEnfermedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value >= 100)
            {
                lblID.Text = "TU ID ES:";
                txtID.Visible = true;
            }
            label13.Text = "GENERANDO ID... " + progressBar1.Value + "%";
        }

        private void FormAltas_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
