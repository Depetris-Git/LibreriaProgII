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
    public class DatosProfesionales : DatosConexionBD
    {
        public int abmLibros(string accion, Libro objProfesional)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "AgregarLibro")
                orden = "insert into libro values (" + objProfesional.ISBN +
                                                            ",'" + objProfesional.Titulo + "');";
            if (accion == "ModificarLibro")
                orden = "update libro set Titulo='" + objProfesional.Titulo + "" +
                                                            "'where ISNB = "+ objProfesional.ISBN + "; ";
            // falta la orden de borrar

           SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar de Profesionales",e);
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
