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
    public class CADClientes
    {


        public Exception insertarClientes(Cliente vt)
        {

            try
            {

                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionClientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@cedula", vt.cedula);
                cmd.Parameters.AddWithValue("@correo", vt.correo);
                cmd.Parameters.AddWithValue("@nombres", vt.nombres);
                cmd.Parameters.AddWithValue("@apellidos", vt.apellidos);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

            }
            return null;


        }


        public Exception modificarClientes(Cliente vt)
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand();
            //sentencia que se ejecutara
            cmd.Connection = con;
            // sentencia que se ejecutara
            cmd.CommandText = "GestionClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "update");
            cmd.Parameters.AddWithValue("@cedula", vt.cedula);
            cmd.Parameters.AddWithValue("@correo", vt.correo);
            cmd.Parameters.AddWithValue("@nombres", vt.nombres);
            cmd.Parameters.AddWithValue("@apellidos", vt.apellidos);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            }

            catch (Exception ex)
            {
                // MessageBox.Show("El registro se ha eliminado");

            }

            return null;

        }

        public Exception eliminarCliente(Cliente vt)
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionClientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "delete");
                cmd.Parameters.AddWithValue("@cedula", vt.cedula);

                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();


            }
            catch (Exception ex)
            {
                // MessageBox.Show("El registro se ha eliminado");

            }
            return null;
        }



    }
}
