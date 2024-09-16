using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using Entidades;

namespace LibreriaBE
{
    public class DatosLibros : DatosConexionBD
    {
        public int abmLibros(string accion, Libro objLibro)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "AgregarLibro")
                orden = "insert into Libros (ISBN, Titulo, Autor) values (" + objLibro.ISBN +
                                                            ",'" + objLibro.Titulo + "','" + objLibro.Autor + "');";
            if (accion == "ModificarLibro")
                orden = "update Libros set Titulo='" + objLibro.Titulo + "" +
                                                            "'where ISBN = "+ objLibro.ISBN + "; ";
            // falta la orden de borrar

           SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar Libros", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }
    }
}
