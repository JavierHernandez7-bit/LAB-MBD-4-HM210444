﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HM21044_practica4
{
    public partial class Form2 : Form
    {
        private SqlConnection conn;
        private SqlCommand insert1;
        private string sCn;
        public Form2()
        {
            InitializeComponent();
            Conexion cn = new Conexion();
            cn.conec();
            sCn = cn.cadena;
            conn = new SqlConnection(sCn);
            conn.Open();
        }

        private void insertar2_Click(object sender, EventArgs e)
        {
            try
            {
                string inserparticipantes;
                inserparticipantes = "INSERT INTO Participantes(Codigo,Nombre,Apellidos,Edad)";
                inserparticipantes += "VALUE(@carnet,@nombre,@apellido,@edad)";
                insert1 = new SqlCommand(inserparticipantes, conn);
                insert1.Parameters.Add(new SqlParameter("@carnet", SqlDbType.VarChar));//
                insert1.Parameters["@carnet"].Value = textcod2.Text;
                insert1.Parameters.Add(new SqlParameter("@carnet", SqlDbType.VarChar));//
                insert1.Parameters["@carnet"].Value = textnom2.Text;
                insert1.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));//
                insert1.Parameters["@apellido"].Value = textapell2.Text;
                insert1.Parameters.Add(new SqlParameter("@edad", SqlDbType.Int));//
                insert1.Parameters["@edad"].Value = textedad2.Text;
                insert1.ExecuteNonQuery();
                //
                textcod2.Text = "";
                textnom2.Text = "";
                textapell2.Text = "";
                textedad2.Text = "";
                MessageBox.Show("Registro Agregado");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void buscar2_Click(object sender, EventArgs e)
        {
            Form formu1 = new Form1();
            formu1.Show();
            this.Hide();
        }
    }
}
