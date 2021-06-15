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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
            dataGridView2.DataSource = llenar_grid2();
            //Para que no se cambie ni edite el contenido del combobox
            cbTam.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        static string conexion3 = "SERVER=127.0.0.1;PORT=3306;DATABASE=productos1;UID=root;PASSWORDS=;Convert Zero Datetime=True";
        MySqlConnection cn3 = new MySqlConnection(conexion3);

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

        public DataTable llenar_grid2()
        {
            cn3.Open();
            DataTable dt2 = new DataTable();
            String llenar = "SELECT * FROM veterinaria";
            MySqlCommand cmd3 = new MySqlCommand(llenar, cn3);
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            da3.Fill(dt2);
            cn3.Close();

            return dt2;
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Fecha = fecha.Text;
            try
            {
                string conexion4 = "SERVER=127.0.0.1;PORT=3306;DATABASE=productos1;UID=root;PASSWORDS=;Convert Zero Datetime=True";
                MySqlConnection cn4 = new MySqlConnection(conexion4);
                cn4.Open();
                string actualizar = "UPDATE veterinaria SET NOMBRE=@NOMBRE,DUEÑO=@DUEÑO," +
                    "RAZA=@RAZA,PESO=@PESO,TAMAÑO=@TAMAÑO,ENFERMEDAD=@ENFERMEDAD," +
                    "TRATAMIENTO=@TRATAMIENTO,FECHA=@FECHA,RUTA=@RUTA WHERE ID=@ID";

                if (pictboxImagen.Image == null)
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA IMAGEN", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Agregar la imagen
                    MemoryStream ms = new MemoryStream();
                    pictboxImagen.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();

                    MySqlCommand cmd4 = new MySqlCommand(actualizar, cn4);

                    cmd4.Parameters.AddWithValue("@ID", tID.Text);
                    cmd4.Parameters.AddWithValue("@NOMBRE", tNombreM.Text);
                    cmd4.Parameters.AddWithValue("@DUEÑO", tNombreD.Text);
                    cmd4.Parameters.AddWithValue("@RAZA", tRaza.Text);
                    cmd4.Parameters.AddWithValue("@PESO", tPeso.Text);
                    cmd4.Parameters.AddWithValue("@TAMAÑO", cbTam.Text);
                    cmd4.Parameters.AddWithValue("@ENFERMEDAD", tEnfermedad.Text);
                    cmd4.Parameters.AddWithValue("@TRATAMIENTO", tTratamiento.Text);
                    cmd4.Parameters.AddWithValue("@FECHA", tFecha.Text);
                    cmd4.Parameters.AddWithValue("@RUTA", aByte.Length);

                    cmd4.ExecuteNonQuery();
                    cn4.Close();

                    MessageBox.Show("SE ACTUALIZARON LOS DATOS", "FELICIDADES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView2.DataSource = llenar_grid2();
                }
            }
            catch
            {

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg;*.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccinar imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pictboxImagen.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {
            tFecha.Text = fecha.Value.ToString("yyyy-MM-dd");
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = llenar_grid2();
            LoadTheme();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                tNombreM.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                tNombreD.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                tRaza.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                tPeso.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                cbTam.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                tEnfermedad.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                tTratamiento.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                fecha.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Habilitar los textbox para modificar
            tPeso.Enabled = true; tNombreD.Enabled = true; tRaza.Enabled = true; cbTam.Enabled = true;
            tNombreM.Enabled = true; tEnfermedad.Enabled = true; tTratamiento.Enabled = true; fecha.Visible = true;
            btnSeleccionar.Enabled = true; btnGuardar.Enabled = true;
        }

        private void tNombreM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tNombreD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tRaza_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tPeso_Enter(object sender, EventArgs e)
        {
            tPeso.Text = "";
        }

        private void tEnfermedad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tPeso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tNombreM_Enter(object sender, EventArgs e)
        {
            tNombreM.Text = "";
        }

        private void tNombreD_Enter(object sender, EventArgs e)
        {
            tNombreD.Text = "";
        }

        private void tRaza_Enter(object sender, EventArgs e)
        {
            tRaza.Text = "";
        }

        private void tEnfermedad_Enter(object sender, EventArgs e)
        {
            tEnfermedad.Text = "";
        }

        private void tTratamiento_Enter(object sender, EventArgs e)
        {
            tTratamiento.Text = "";
        }
    }
}
