using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Neveria.Clases
{
    class ClConsecutivo
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC; User=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        string cons;
        public string consecutivos(string folio, string tabla)
        {
            string query = "SELECT MAX("+folio+")+ 1 AS ultimo FROM "+tabla;
            comando = new SqlCommand(query, conexion);
            conexion.Open();
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                cons = lector["ultimo"].ToString();
                conexion.Close();
            }
            return cons;
        }
    }
}
