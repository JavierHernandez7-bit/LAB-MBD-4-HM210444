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
using System.Data.SqlClient;

namespace P4_Parte_2
{
    public partial class Form1 : Form
    {
        // Defino una varibale de tipo Connection
        private SqlConnection conn1;
        // Defino una variable de tipo DataAdapter
        private SqlDataAdapter da1;
        // Defino una variable de tipo DataReader
        private SqlDataReader dr1;
        // Defino una variable que contendrá la cadena de conexión
        private string sCn1;
        // Instancio una variable OleDbConection
        OleDbConnection cnn = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            // Linea de conexion con el servidor de base de datos SQL por OLEBD
            cnn.ConnectionString =
                @"PROVIDER=SQLOLEDB;Server=(localdb)\\MSSQLLocalDB;Database=BD_AE210567_P4;Uid=sa;Pwd=123456";
            // Ocultamos el botón modificar
            modificar1.Visible = false;
            // Conexión por medio de SQLCLIENT
            conexion cn1 = new conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn1 = new SqlConnection(sCn1);
            conn1.Open();
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            //mostramos los textbox ocultos
            textapel1.Visible = true;
            textedad1.Visible = true;
            textnom1.Visible = true;
            modificar1.Visible = true;

            // La variable tendra la consulta
            string seleccion;
            seleccion = "Select * From Participantes where Codigo= '" + textcod1.Text + "'";
            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("Codigo", SqlDbType.VarChar);
            prm.Value = textcod1.Text;
            da1.SelectCommand.Parameters.Add(prm); 
            dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                textnom1.Text = dr1["Nombres"].ToString().Trim();
                textapel1.Text = dr1["Apellidos"].ToString().Trim();
                textedad1.Text = dr1["Edad"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos encontrados");
                dr1.Close();
            }
        }

        private void modificar1_Click(object sender, EventArgs e)
        {
            string actualizar;
            actualizar = "update Participantes set";
            actualizar += "Nombres = ' " + textnom1.Text + " ', Apellidos= '" + textapel1.Text;

            actualizar += " ', Edad=" + textedad1.Text + "where Codigo= ', " + textcod1.Text + " ' ";
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);
            cnn.Open();
            // Mandando sql a base de datos
            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Registro actualizado");
            Reset();
        }

        private void Reset()
        {
            textcod1.Text = "";
            textnom1.Text = "";
            textapel1.Text = "";
            textedad1.Text = "";
            textedad1.Visible = false;
            textnom1.Visible = false;
            textapel1.Visible = false;
            modificar1.Visible = false;
            Form2 formu2 = new Form2();
            // Mostramos el Form2
            formu2.Show();
            // Ocultamos el Form1
            this.Hide();
        }
    }
}
