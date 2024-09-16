using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibreriaBE;
using Entidades;

namespace Negocio
{
    public class NegLibros
    {
        DatosLibros objDatosLibros = new DatosLibros();
        public int abmLibros(string accion, Libro objLibro)
        {
            return objDatosLibros.abmLibros(accion, objLibro);
        }
        public DataSet listadoLibros(string cual)
        {
            return objDatosLibros.listadoLibros(cual);
        }
    }
}
