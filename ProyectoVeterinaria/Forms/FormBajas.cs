using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVeterinaria.Forms
{
    public partial class FormBajas : Form
    {
        public FormBajas()
        {
            InitializeComponent();
        }

        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=productos1;UID=root;PASSWORDS=;Convert Zero Datetime=True";
        MySqlConnection cn1 = new MySqlConnection(conexion);

        public DataTable llenar_grid()
        {
            cn1.Open();
            DataTable dt = new DataTable();
            String llenar = "SELECT * FROM veterinaria";
            MySqlCommand cmd1 = new MySqlCommand(llenar, cn1);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da1.Fill(dt);
            cn1.Close();

            return dt;


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

        private void FormBajas_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1.DataSource = llenar_grid();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string ID = txtID.Text;

            //sentencias de sql para la base
            string sql = "SELECT id FROM veterinaria WHERE id LIKE '" + ID + "'";
            string eliminar = "DELETE FROM veterinaria WHERE id LIKE '" + ID + "'";

            MySqlConnection conexionBD1 = Conexion.conexion();
            conexionBD1.Open();

            try
            {
                MySqlCommand comando2 = new MySqlCommand(sql, conexionBD1);
                MySqlDataReader reader1 = null;
                reader1 = comando2.ExecuteReader();
                if (reader1.HasRows)
                {

                    while (reader1.Read())
                    {
                        contador = +1;  //Es un contador en caso de que se encuentre un id igual
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Se produjo un error, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexionBD1.Close();
            }

            try
            {
                //si se encontro el valor, se elimina de lo contrario lanza una advertencia que no existe       
                if (contador > 0)
                {
                    MySqlConnection conexionBDAgre = Conexion.conexion();
                    conexionBDAgre.Open();

                    MySqlCommand cmd2 = new MySqlCommand(eliminar, conexionBDAgre);
                    cmd2.ExecuteNonQuery();
                    //Elimina correctamente de acuerdo el id, toda la linea
                    MessageBox.Show("SE ELIMINÓ CORRECTAMENTE ESTE USUARIO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";

                    dataGridView1.DataSource = llenar_grid();
                }
                else
                {
                    MessageBox.Show("NO EXISTE NINGUN DATO DE ESTE ID.\nDEBE SELECCIONAR UN ID EXISTENTE.", "INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Se produjo un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
