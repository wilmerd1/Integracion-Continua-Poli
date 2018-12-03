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
    public class CADFactura
    {



        public Exception insertarFactura(Factura vt)
        {

            try
            {

                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionFactura";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@observaciones", vt.observaciones);
                cmd.Parameters.AddWithValue("@iva", vt.iva);
                cmd.Parameters.AddWithValue("@subtotal", vt.subtotal);
                cmd.Parameters.AddWithValue("@total", vt.total);
                cmd.Parameters.AddWithValue("@cliente", vt.cliente);
                cmd.Parameters.AddWithValue("@fecha", vt.fecha);



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

            }
            return null;


        }



        public Exception modificarFactura(Factura vt)
        {
            string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand();
            //sentencia que se ejecutara
            cmd.Connection = con;
            // sentencia que se ejecutara
            cmd.CommandText = "GestionFactura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "update");
            cmd.Parameters.AddWithValue("@observaciones", vt.observaciones);
            cmd.Parameters.AddWithValue("@iva", vt.iva);
            cmd.Parameters.AddWithValue("@subtotal", vt.subtotal);
            cmd.Parameters.AddWithValue("@total", vt.total);
            cmd.Parameters.AddWithValue("@cliente", vt.cliente);
            cmd.Parameters.AddWithValue("@fecha", vt.fecha);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return null;

        }

        public Exception eliminarFactura(Factura vt)
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionFactura";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "delete");
                cmd.Parameters.AddWithValue("@nombre", vt.idFactura);

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
