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
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();
            dataGridView3.DataSource = llenar_grid3();
        }

        static string conexion5 = "SERVER=127.0.0.1;PORT=3306;DATABASE=productos1;UID=root;PASSWORDS=;Convert Zero Datetime=True";
        MySqlConnection cn5 = new MySqlConnection(conexion5);

        public DataTable llenar_grid3()
        {
            cn5.Open();
            DataTable dt5 = new DataTable();
            String llenar = "SELECT * FROM veterinaria";
            MySqlCommand cmd5 = new MySqlCommand(llenar, cn5);
            MySqlDataAdapter da5 = new MySqlDataAdapter(cmd5);
            da5.Fill(dt5);
            cn5.Close();

            return dt5;
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

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
