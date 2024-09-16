using Entidades;
using LibreriaBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProductos
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Libro NuevoLibro;
                NuevoLibro = new Libro(txt_Titulo.Text, int.Parse(txt_ISNB.Text), txt_Autor.Text);
                MessageBox.Show("Libro cargado exitosamente.");
                txt_ISNB_stock.Text = NuevoLibro.ISBN.ToString();
                txt_Titulo_stock.Text = NuevoLibro.Titulo;
                txt_StockActual.Text = "Stock Actual: " + NuevoLibro.Stock.ToString();
                txt_Autor_stock.Text = NuevoLibro.Autor;
            }
            catch
            {
                MessageBox.Show("Error al cargar el libro");
            }

        }
    }
}
