namespace WindowsFormsProductos
{
    partial class FormAdmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libreriaDataSet = new WindowsFormsProductos.LibreriaDataSet();
            this.librosTableAdapter = new WindowsFormsProductos.LibreriaDataSetTableAdapters.LibrosTableAdapter();
            this.bt_Grabar = new System.Windows.Forms.Button();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(447, 35);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(494, 386);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "Libros";
            this.librosBindingSource.DataSource = this.libreriaDataSet;
            // 
            // libreriaDataSet
            // 
            this.libreriaDataSet.DataSetName = "LibreriaDataSet";
            this.libreriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // bt_Grabar
            // 
            this.bt_Grabar.Location = new System.Drawing.Point(45, 284);
            this.bt_Grabar.Name = "bt_Grabar";
            this.bt_Grabar.Size = new System.Drawing.Size(123, 41);
            this.bt_Grabar.TabIndex = 1;
            this.bt_Grabar.Text = "Grabar";
            this.bt_Grabar.UseVisualStyleBackColor = true;
            this.bt_Grabar.Click += new System.EventHandler(this.bt_Grabar_Click);
            // 
            // bt_Modificar
            // 
            this.bt_Modificar.Location = new System.Drawing.Point(210, 284);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(123, 41);
            this.bt_Modificar.TabIndex = 2;
            this.bt_Modificar.Text = "Modificar";
            this.bt_Modificar.UseVisualStyleBackColor = true;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Título:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(101, 124);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(188, 26);
            this.txtISBN.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(101, 185);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(188, 26);
            this.txtTitulo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(101, 238);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(188, 26);
            this.txtAutor.TabIndex = 9;
            // 
            // FormAdmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.bt_Grabar);
            this.Controls.Add(this.dgvLibros);
            this.Name = "FormAdmLibros";
            this.Text = "FormAdmLibros";
            this.Load += new System.EventHandler(this.FormAdmLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libreriaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private LibreriaDataSet libreriaDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private LibreriaDataSetTableAdapters.LibrosTableAdapter librosTableAdapter;
        private System.Windows.Forms.Button bt_Grabar;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutor;
    }
}