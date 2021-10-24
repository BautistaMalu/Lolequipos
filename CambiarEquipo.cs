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
    
    public partial class CambiarEquipo : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public CambiarEquipo()
        {
            InitializeComponent();
        }

        private void CambiarEquipo_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseEquiposLol.accdb";
        }

        private void cbxLigas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEquipos.Items.Clear();
            cbxEquipos.Text = "";

            if (cbxLigas.Text == "LCK")
            {
                cbxEquipos.Items.Add("DK");
                cbxEquipos.Items.Add("GENG");
                cbxEquipos.Items.Add("NS");
                cbxEquipos.Items.Add("T1");
                cbxEquipos.Items.Add("LSB");
                cbxEquipos.Items.Add("AF");
                cbxEquipos.Items.Add("KT");
                cbxEquipos.Items.Add("HLE");
                cbxEquipos.Items.Add("BRO");
                cbxEquipos.Items.Add("DRX");
            }
            else if (cbxLigas.Text == "LCS")
            {
                cbxEquipos.Items.Add("TSM");
                cbxEquipos.Items.Add("100T");
                cbxEquipos.Items.Add("EG");
                cbxEquipos.Items.Add("C9");
                cbxEquipos.Items.Add("TL");
                cbxEquipos.Items.Add("DIG");
                cbxEquipos.Items.Add("IM");
                cbxEquipos.Items.Add("GG");
                cbxEquipos.Items.Add("FLY");
                cbxEquipos.Items.Add("CLG");
            }
            else if (cbxLigas.Text == "LPL")
            {
                cbxEquipos.Items.Add("BLG");
                cbxEquipos.Items.Add("EDG");
                cbxEquipos.Items.Add("FPX");
                cbxEquipos.Items.Add("IG");
                cbxEquipos.Items.Add("JDG");
                cbxEquipos.Items.Add("LGD");
                cbxEquipos.Items.Add("LNG");
                cbxEquipos.Items.Add("OMG");
                cbxEquipos.Items.Add("RA");
                cbxEquipos.Items.Add("RW");
                cbxEquipos.Items.Add("RNG");
                cbxEquipos.Items.Add("SN");
                cbxEquipos.Items.Add("WE");
                cbxEquipos.Items.Add("TOP");
                cbxEquipos.Items.Add("TTG");
                cbxEquipos.Items.Add("UP");
                cbxEquipos.Items.Add("VF");
            }
            else if (cbxLigas.Text == "LEC")
            {
                cbxEquipos.Items.Add("G2");
                cbxEquipos.Items.Add("FNC");
                cbxEquipos.Items.Add("ROUGE");
                cbxEquipos.Items.Add("MAD");
                cbxEquipos.Items.Add("MSF");
                cbxEquipos.Items.Add("VIT");
                cbxEquipos.Items.Add("AST");
                cbxEquipos.Items.Add("EXCEL");
                cbxEquipos.Items.Add("SK");
                cbxEquipos.Items.Add("S04");
            }
        }

        private void CambiarPredict_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command.CommandText = "select * from Equipos where Nombre='" + cbxEquipos.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();

            string IDGanador = reader["ID"].ToString();

            connection.Close();
            connection.Open();

            command.CommandText = "update Usuario set EquipoGanador='" + IDGanador + "' where NombreUsuario='" + Login.ObtenerDatosUsuario.NombreDelUsuario + "'";
            command.ExecuteNonQuery();

            MessageBox.Show("Nueva Prediccion Hecha!");

            connection.Close();

            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }
    }
}
