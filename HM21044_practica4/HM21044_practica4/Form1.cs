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


namespace HM21044_practica4
{
    public partial class Form1 : Form
    {
        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            cnn.ConnectionString =
                @"PROVIDER=SQLOLEDB;Server=LAPTOP-HBP2PF1B;Database=BD2_HM210444;Uid=sa;Pwd=123456";
            modificar1.Visible = false;
            Conexion cn1 = new
            Conexion();
            cn1.conec();
            sCn1 = cn1.cadena;
            conn1 = new SqlConnection(sCn1);//
            conn1.Open();
        }

        private void buscar1_Click(object sender, EventArgs e)
        {
            textedad1.Visible = true;
            textnom1.Visible = true;
            textapell.Visible = true;
            modificar1.Visible = true;
            string seleccion;
            seleccion = "Select *From Participantes where Codigo= " + textcod1.Text + "";//
            da1 = new SqlDataAdapter(seleccion, conn1);
            SqlParameter prm = new SqlParameter("Codigo", SqlDbType.VarChar);
            prm.Value = textcod1.Text;
            da1.SelectCommand.Parameters.Add(prm); dr1 = da1.SelectCommand.ExecuteReader();
            while (dr1.Read())
            {
                textnom1.Text = dr1["Nombres"].ToString().Trim();
                textapell.Text = dr1["Apellidos"].ToString().Trim();
                textedad1.Text = dr1["Edad"].ToString().Trim();
            }
            if (dr1 != null)
            {
                MessageBox.Show("Datos Encontrados");
                dr1.Close();
            }
        }

        private void modificar1_Click(object sender, EventArgs e)
        {/////////
            string actualizar;
            actualizar = "update Participante set";
            actualizar += "Nombre=" + textnom1.Text + ",Apellidos = " + textapell.Text;
            actualizar += ",Edad=" + textedad1.Text + "where Codigo = " + textcod1.Text + "";
            OleDbCommand datos = new OleDbCommand(actualizar, cnn);
            cnn.Open();
            //
            datos.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("REGISTRO ACTUALIZADO");
            Reset();
            

        }
        private void Reset()
        {
            textcod1.Text = "";
            textnom1.Text = "";
            textapell.Text = "";
            textedad1.Text = "";
            textedad1.Visible = false;
            textnom1.Visible = false;
            textapell.Visible = false;
            modificar1.Visible = false;
            Form2 formu2 = new Form2();
            formu2.Show();
            this.Hide();
        }
    }
}   
