using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace WindowsFormsProductos
{
    public partial class FormAdmLibros : Form
    {
        public FormAdmLibros()
        {
            InitializeComponent();
            dgvLibros.ColumnCount = 3;
            dgvLibros.Columns[0].HeaderText = "ISBN";
            dgvLibros.Columns[1].HeaderText = "Titulo";
            dgvLibros.Columns[2].HeaderText = "Autor";
            dgvLibros.Columns[0].Width = 50;
            dgvLibros.Columns[1].Width = 170;
            dgvLibros.Columns[2].Width = 100;
            LlenarDGV();
        }

        private void LlenarDGV()
        {
            dgvLibros.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegLibro.listadoLibros("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(),etc...
                    dgvLibros.Rows.Add(dr[0].ToString(), dr[1], dr[2]);
                }
            }
            else 
                label1.Text = "No hay libros cargados en el sistema";
        }
        private void FormAdmLibros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'libreriaDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.libreriaDataSet.Libros);

        }
        public Libro objEntLibro = new Libro();
        public NegLibros objNegLibro = new NegLibros();
        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            objEntLibro.ISBN = int.Parse(txtISBN.Text);
            objEntLibro.Titulo = txtTitulo.Text;
            objEntLibro.Autor = txtAutor.Text;
        }
        private void Limpiar()
        {
            txtISBN.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
        }

        private void bt_Grabar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Obj();
            nGrabados = objNegLibro.abmLibros("AgregarLibro", objEntLibro); //invoco a la capa de negocio
            if (nGrabados == -1)
            {
                label1.Text = " No pudo grabar libros en el sistema";
            }
            else
            {
                label1.Text = " Se grabó con éxito el libro.";
                LlenarDGV();
                Limpiar();
            }
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntLibro.ISBN = Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value);
            ds = objNegLibro.listadoLibros(objEntLibro.ISBN.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                bt_Grabar.Visible = false;
                label1.Text = string.Empty;
            }
        }
        private void Ds_a_TxtBox(DataSet ds)
        {
            txtISBN.Text = ds.Tables[0].Rows[0]["ISBN"].ToString();
            txtTitulo.Text = ds.Tables[0].Rows[0]["Titulo"].ToString();
            txtAutor.Text = ds.Tables[0].Rows[0]["Autor"].ToString();
            txtISBN.Enabled = false;
        }

        private void bt_Modificar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            TxtBox_a_Obj();
            nResultado = objNegLibro.abmLibros("ModificarLibro", objEntLibro); //invoco a la capa de negocio
            if (nResultado != -1)
            {
                MessageBox.Show("Aviso", "El Libro fue Modificado con éxito");
                Limpiar();
                LlenarDGV();

                txtISBN.Enabled = true;

            }
            else
            {
                MessageBox.Show("Error", "Se produjo un error al intentar modificar el Libro");
            }
        }
    }
}
