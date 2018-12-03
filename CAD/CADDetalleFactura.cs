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
    public class CADDetalleFactura
    {



        public Exception insertarDetalleFactura(DetalleFactura vt)
        {

            try
            {

                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionDetalleFactura";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@idFactura", vt.idFactura);
                cmd.Parameters.AddWithValue("@idProducto", vt.idProducto);
                cmd.Parameters.AddWithValue("@precioUnitario", vt.precioUnitario);
                cmd.Parameters.AddWithValue("@cantidad", vt.cantidad);
                cmd.Parameters.AddWithValue("@precioTotal", vt.precioTotal);
                cmd.Parameters.AddWithValue("@descripcion", vt.descripcion);
           


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

            }
            return null;


        }



        public Exception modificarProducto(DetalleFactura vt)
        {
            string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand();
            //sentencia que se ejecutara
            cmd.Connection = con;
            // sentencia que se ejecutara
            cmd.CommandText = "GestionDetalleFactura";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "update");
            cmd.Parameters.AddWithValue("@idFactura", vt.idFactura);
            cmd.Parameters.AddWithValue("@idProducto", vt.idProducto);
            cmd.Parameters.AddWithValue("@precioUnitario", vt.precioUnitario);
            cmd.Parameters.AddWithValue("@cantidad", vt.cantidad);
            cmd.Parameters.AddWithValue("@precioTotal", vt.precioTotal);
            cmd.Parameters.AddWithValue("@descripcion", vt.descripcion);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            return null;

        }

        public Exception eliminarProducto(DetalleFactura vt)
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionDetalleFactura";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "delete");
                cmd.Parameters.AddWithValue("@nombre", vt.idDetalleFactura);

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
