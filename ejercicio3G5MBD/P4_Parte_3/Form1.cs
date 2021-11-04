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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // Ignorar
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form2 formu1 = new Form2();
            formu1.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form3 formu1 = new Form3();
            formu1.Show();
            this.Hide();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // La conexión a usar con autenticación de Windows
            // Indicando la base de datos master
            SqlConnection cnn = new SqlConnection(
                "Server=" + "(localdb)\\MSSQLLocalDB" + "; " + "database=master; integrated security=yes");  
            // La orden T-SQL para crear la base de datos es
            string CrearDB = "CREATE DATABASE " + "DB_AVANZADA";

            // ----- Creacion de la tabla clientes-----
            string tClientes = "USE DB_AVANZADA;" + 
                "CREATE TABLE CLIENTES(" +
                "id_Cliente int IDENTITY(1,1)," +
                "NombreCliente varchar(40)" +
                "CONSTRAINT PK_cliente PRIMARY KEY (id_Cliente));";

            // ----- Creación de la tabla pedidos -----
            string tPedidos = "USE DB_AVANZADA;" +
                "CREATE TABLE PEDIDOS(" +
                "id_Pedido int IDENTITY(1,1)," +
                "id_Cliente int not null," +
                "CantidadPedido int," +
                "FechaPedido varchar(70)," +
                "CONSTRAINT PK_pedido PRIMARY KEY(id_Pedido)," +
                "CONSTRAINT FK_Cliente FOREIGN KEY(id_Cliente)" +
                "REFERENCES CLIENTES(id_Cliente));";

            SqlCommand cmd = new SqlCommand(CrearDB, cnn);
            SqlCommand cmd1 = new SqlCommand(tClientes, cnn);
            SqlCommand cmd2 = new SqlCommand(tPedidos, cnn);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Base de datos" +
                    "\nCreada correctamente...", "Generar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al crear la Base de Datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
