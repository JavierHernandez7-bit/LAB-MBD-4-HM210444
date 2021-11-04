using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace P4_Parte_3
{
    public partial class Form2 : Form
    {
        // Variables
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;

        public Form2()
        {
            InitializeComponent();

            // Objeto de conexión
            conexion cn = new conexion();
            // Acceso a la función conec de la clase conexión
            cn.conec();
            // Variable para la cadena de conexión
            sCn = cn.cadena;
            // Conexión
            conn = new SqlConnection(sCn);
        }

        private void btnIngresarC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // Variable insertar
                string insertCliente;
                insertCliente = "INSERT INTO CLIENTES(NombreCliente)";
                insertCliente += "VALUES (@nombreCliente)";
                insert1 = new SqlCommand(insertCliente, conn);
                insert1.Parameters.Add(
                    new SqlParameter("@nombreCliente", SqlDbType.VarChar));
                insert1.Parameters["@nombreCliente"].Value = txtCliente.Text;
                insert1.ExecuteNonQuery();
                txtCliente.Clear();
                MessageBox.Show("Registro ingresado...", "Ingresar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("El registro no fue ingresado...",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarC_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
