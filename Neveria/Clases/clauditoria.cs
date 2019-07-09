using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neveria.Clases
{

    class clauditoria
    {

       
        public static void auditoria(string au_actividad)
        {
            string user = "add";
            string usuario = Clases.clusuario.persona;
            Clconexion objconexion = new Clconexion();
            SqlConnection cnn = new SqlConnection(objconexion.conn());
            cnn.Open();
            string query = "insert into Auditoria values('"+usuario+"','"+DateTime.Now.ToString("MM/dd/yyyy/ HH:mm:ss")+"','"+au_actividad+"')";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
            
        
        
        }

        
        
    }
}
