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
    public partial class Register : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Register()
        {
            InitializeComponent();

        }

        private void Register_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseEquiposLol.accdb";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int count = 0;


                command.CommandText = "select * from Usuario where NombreUsuario='" + txtUsuario.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count += 1;
                }

                if (count == 1 || count > 1)
                {
                    MessageBox.Show("Ya existe una cuenta con los datos introducidos");
                    connection.Close();
                    return;

                }
                connection.Close();
                connection.Open();

                command.CommandText = "insert into Usuario (NombreUsuario,UsuarioContra,EquipoGanador) " + " values ('" + txtUsuario.Text + "','" + txtContra.Text + "','" + 64 + "')";
                command.ExecuteNonQuery();

                connection.Close();



                MessageBox.Show("Cuenta Creada Exitosamente");

                this.Hide();
                new Login().ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";

                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";

                txtUsuario.ForeColor = Color.Black;
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

        private void txtContra_Leave_1(object sender, EventArgs e)
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
