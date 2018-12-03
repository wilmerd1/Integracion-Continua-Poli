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
  public   class CADproductos
    {

        public Exception insertarProducto(Producto vt)
 {
       
            try
            {

                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionProductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "insert");
                cmd.Parameters.AddWithValue("@nombre", vt.nombre);
                cmd.Parameters.AddWithValue("@marca", vt.marca);
                cmd.Parameters.AddWithValue("@precio", vt.precio);
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



        public Exception modificarProducto(Producto vt)
        {

            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
            SqlConnection con = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand();
            //sentencia que se ejecutara
            cmd.Connection = con;
            // sentencia que se ejecutara
            cmd.CommandText = "GestionProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "update");
            cmd.Parameters.AddWithValue("@nombre", vt.nombre);
            cmd.Parameters.AddWithValue("@marca", vt.marca);
            cmd.Parameters.AddWithValue("@precio", vt.precio);
            cmd.Parameters.AddWithValue("@descripcion", vt.descripcion);

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

        public Exception eliminarProducto(Producto vt)
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
                SqlConnection con = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand();

                //sentencia que se ejecutara
                cmd.Connection = con;
                // sentencia que se ejecutara
                cmd.CommandText = "GestionProductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@action", "delete");
                cmd.Parameters.AddWithValue("@nombre", vt.nombre);

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
