﻿using System;
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

                    string UsuarioID = reader2["ID"].ToString();
                    string EquipoFav = reader2["EquipoGanador"].ToString();
                    Login.ObtenerDatosUsuario.IDUsuarioActivo = Convert.ToInt32(UsuarioID);
                    Login.ObtenerDatosUsuario.NombreDelUsuario = txtUsuario.Text;
                    Login.ObtenerDatosUsuario.IDEquipoWinner = Convert.ToInt32(EquipoFav);

                    MessageBox.Show(Convert.ToString(UsuarioID));

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
    }
}