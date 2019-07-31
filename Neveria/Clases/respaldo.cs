using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neveria.Clases
{
    class respaldo
    {
        public static void realizar(string ruta)
        {
            string fecha = DateTime.Now.ToString("dd-MM-yyyy");
            string query = "BACKUP DATABASE [NEVERIAC] TO DISK = N'" + ruta + "" + "/Respaldo Neveria" + " " + fecha + ".bak' WITH NOFORMAT, NOINIT, NAME= N'Neveria completa base de datos  copia de seguridad', SKIP, NOREWIND, NOUNLOAD, STATS=10";
            Clconexion objconexion = new Clconexion();
            SqlConnection conexion = new SqlConnection(objconexion.conexion());
            SqlCommand cmd;
   
            cmd = new SqlCommand(query);
            cmd.Connection = conexion;
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
