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

        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        Clases.Clconexion objconexion;
        public static void auditoria(string au_actividad)
        {
              Clconexion objconexion = new Clconexion();
            SqlConnection con = new SqlConnection(objconexion.conexion());

            con.Open();

            SqlCommand Registrar = new SqlCommand("insert into Auditoria values(@au_usuario,@au_fecha,@au_descrip)", con);
            Registrar.Parameters.AddWithValue("@au_usuario", Clases.clusuario.usuario);
            Registrar.Parameters.AddWithValue("@au_fecha", DateTime.Today);
            Registrar.Parameters.AddWithValue("@au_descrip", au_actividad);
            Registrar.ExecuteNonQuery();
            con.Close();

            //string user = "add";
            //string usuario = Clases.clusuario.persona;
            //Clconexion objconexion = new Clconexion();
            //SqlConnection conexion = new SqlConnection(objconexion.conexion());
            //conexion.Open();
            //string query = "insert into Auditoria values('"+usuario+"','"+DateTime.Now.ToString("MM/dd/yyyy/ HH:mm:ss")+"','"+au_actividad+"')";
            //SqlCommand cmd = new SqlCommand(query, conexion);
            //cmd.ExecuteNonQuery();
            //conexion.Close();



        }



    }
}
