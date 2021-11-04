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

namespace P4_Parte_2
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        public Form2()
        {
            InitializeComponent();
            // Usando la clase conexion
            // Creo un nuevo objeto de tipo conexión y lo asigno a cn
            conexion cn = new conexion();
            // Acceso a la fundión conec de la clase conexion
            cn.conec();
            // Agrego la variable scn a la cadena conexión
            sCn = cn.cadena;
            // Creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);
            // Abro la conexión
            conn.Open();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void insertar2_Click(object sender, EventArgs e)
        {
            try
            {
                // Creo la variable que contendrá la consulta sql de inserción
                string inserparticipante;

                inserparticipante = "INSERT INTO Participantes(Codigo,Nombres,Apellidos,Edad)";
                inserparticipante += "VALUES(@carnet,@nombre,@apellido,@edad)";

                insert1 = new SqlCommand(inserparticipante, conn);

                insert1.Parameters.Add(new SqlParameter("@carnet", SqlDbType.VarChar));
                insert1.Parameters["@carnet"].Value = textcod2.Text;

                insert1.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                insert1.Parameters["@nombre"].Value = textnom2.Text;

                insert1.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                insert1.Parameters["@apellido"].Value = textapel2.Text;

                insert1.Parameters.Add(new SqlParameter("@edad", SqlDbType.VarChar));
                insert1.Parameters["@edad"].Value = textedad2.Text;

                insert1.ExecuteNonQuery();

                // Limpiamos lo textbox
                textcod2.Text = "";
                textnom2.Text = "";
                textapel2.Text = "";
                textedad2.Text = "";

                MessageBox.Show("Registro agregado");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


        private void buscar2_Click(object sender, EventArgs e)
        {
            Form1 formu1 = new Form1(); // Instanciamos un objeto de tipo
            formu1.Show(); // Mostramos el Form1
            this.Hide(); // Ocultamos el Form2
        }
    }
}
