using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neveria.Clases
{
    class Clconexion
    {
        public string conexion()
        {
            string conexion = (@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
            return conexion;
        }
    }
}
