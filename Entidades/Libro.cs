using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        #region Atributos
        private string titulo;
       private int iSBN;
       private string autor;
       private string categoria;
       private int stock;
       private bool disponibilidad;
        #endregion

        #region Propiedades
        public string Titulo
        {
         set { titulo = value; }
         get { return titulo; }
        }   
        public int ISBN
        {
        set {  iSBN = value; }
        get { return iSBN; }
        }
        public string Autor
        {
            set {  autor = value; }
            get { return autor; }
        }
        public string Categoria
        {
            set {  categoria = value; }
            get { return categoria; }
        }
        public int Stock
        {
            get { return stock; }
        }
        public bool Disponibilidad
        {
            set {  disponibilidad = value; }
            get { return disponibilidad;}
        }
        #endregion

        #region Constructores
        public Libro()
        {
        
        }
        public Libro(string tit, int isbn, string aut)
        {
            titulo = tit;
            iSBN = isbn;
            autor = aut;
            stock = 0;
        }
        public Libro(string tit,int isbn, string aut, int stk)
        {
            titulo = tit;
            iSBN = isbn;
            autor = aut;
            stock = stk;

        }
        public Libro(string tit, int isbn, string aut, string categ, int stk, bool disp)
        {
            titulo = tit;
            iSBN = isbn;
            autor = aut;
            categoria = categ;
            stock = stk;
            disponibilidad = disp;  
        }
        #endregion

        #region Metodos
        public void Ingreso(int cantidad)
        {
            stock = stock + cantidad;
        }

        public void Salida(int cantidad)
        {
            stock = stock - cantidad;
        }
        #endregion
    }
}
