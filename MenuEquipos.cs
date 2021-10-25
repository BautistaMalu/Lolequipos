using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LolEsports
{
    public partial class MenuEquipos : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public MenuEquipos()
        {
            InitializeComponent();
        }

        private void MenuEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseEquiposLol.accdb";

                

                lblBienvenido.Text = "Hola! Bienvenid@ " + Login.ObtenerDatosUsuario.NombreDelUsuario;

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "SELECT * FROM Equipos WHERE ID=" + Login.ObtenerDatosUsuario.IDEquipoWinner + "";
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                string PredictionEquipo = reader["Nombre"].ToString();



                lblPredict.Text = "Su prediccion es: " + PredictionEquipo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }

        private void CambiarEquipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CambiarEquipo().ShowDialog();
            this.Show();
        }
    }
}
