using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HM21044_practica4
{
    class Conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;

        public void conec()
        {
            servidor = "LAPTOP-HBP2PF1B";
            db = "BD2_HM210444";
            usuario = "sa";
            clave = "123456";
            cadena = "server" + servidor + ";uid=" + usuario + "pwd=" + clave + ";database" + db;


        }
    }
}
