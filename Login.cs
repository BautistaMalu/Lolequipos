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
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
        }

        public static class ObtenerDatosUsuario
        {

            public static int IDUsuarioActivo = 0;
            public static string NombreDelUsuario = "";
            public static int IDEquipoWinner = 0;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseEquiposLol.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "select * from Usuario where NombreUsuario='" + txtUsuario.Text + "' and UsuarioContra='" + txtContra.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count += 1;
                }

                connection.Close();

                if (count == 1)
                {
                    connection.Open();
                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;

                    command2.CommandText = "select * from Usuario where NombreUsuario='" + txtUsuario.Text + "' and UsuarioContra='" + txtContra.Text + "'";

                    OleDbDataReader reader2 = command2.ExecuteReader();
                    reader2.Read();

                    string EquipoFav = reader2["EquipoGanador"].ToString();
                    Login.ObtenerDatosUsuario.NombreDelUsuario = txtUsuario.Text;
                    Login.ObtenerDatosUsuario.IDEquipoWinner = Convert.ToInt32(EquipoFav);

                    

                    this.Hide();
                    new MenuEquipos().ShowDialog();
                    this.Show();
                }
                else if (count < 1)
                {
                    MessageBox.Show("Los datos introducidos son incorrectos");
                    return;

                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa algo salio mal... " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().ShowDialog();
            this.Show();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";

                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";

                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";

                txtContra.ForeColor = Color.Black;

                txtContra.PasswordChar = '*';
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";

                txtContra.ForeColor = Color.DarkGray;

                txtContra.PasswordChar = (char)0;
            }
        }
    }
}
