using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes.Datos
{
    public static class ConexionBD
    {
        private const string CadenaConexion =
            "Server=(localdb)\\MSSQLLocalDB;" +
            "Database=RegistroEstudiantesDB;" +
            "Trusted_Connection=True;" +
            "TrustServerCertificate=True;";

        public static SqlConnection CrearConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
