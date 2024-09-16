using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace LibreriaBE
{
    public class DatosConexionBD
    {
        public SqlConnection conexion;
        public string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=
                                        C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Libreria.mdf;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False";
        
        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
        public DataSet listadoLibros(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Libros where ISBN = " + int.Parse(cual) + ";";
            else
                orden = "select * from Libros;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar libros", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}