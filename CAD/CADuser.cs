using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CADuser
    {
        string conex = ConfigurationManager.ConnectionStrings["conSQL"].ConnectionString;
        

        public DataTable validarUsuario(user us){
            SqlConnection con = new SqlConnection(conex);
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "prcValidarusuario";

            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            

            cmd.Parameters.AddWithValue("@usuario",us.usuario);
            cmd.Parameters.AddWithValue("@contra", us.contra);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            con.Open();
            sda.Fill(dt);
            con.Close();
            return dt;



        }

    }
}
