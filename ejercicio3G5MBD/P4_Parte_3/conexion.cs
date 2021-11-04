using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace P4_Parte_3
{
    class conexion
    {
        // Parámetros para la cadena de conexión
        public string servidor, usuario, clave, db;
        public string cadena;
        // Función que tendrá la cadena de conexión
        public void conec()
        {
            servidor = "(localdb)\\MSSQLLocalDB";
            db = "DB_AVANZADA";
            usuario = "as";
            clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;
        }
    }
}
