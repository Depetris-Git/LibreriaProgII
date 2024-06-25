namespace WindowsFormsProductos
{
    partial class FormProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CargarLibro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ISNB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Titulo_stock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RadBtn_Egreso = new System.Windows.Forms.RadioButton();
            this.RadBtt_Ingreso = new System.Windows.Forms.RadioButton();
            this.btn_IngresoEgreso = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ISNB_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_StockActual = new System.Windows.Forms.Label();
            this.txt_Autor_stock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // btn_CargarLibro
            // 
            this.btn_CargarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarLibro.Location = new System.Drawing.Point(496, 141);
            this.btn_CargarLibro.Name = "btn_CargarLibro";
            this.btn_CargarLibro.Size = new System.Drawing.Size(91, 40);
            this.btn_CargarLibro.TabIndex = 3;
            this.btn_CargarLibro.Text = "Cargar";
            this.btn_CargarLibro.UseVisualStyleBackColor = true;
            this.btn_CargarLibro.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 282);
            this.dataGridView1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(91, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 216);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Stock);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_Autor);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_Categoria);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_ISNB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Titulo);
            this.tabPage1.Controls.Add(this.btn_CargarLibro);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cargar libro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(130, 141);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(341, 24);
            this.txt_Stock.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock";
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(130, 81);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(341, 24);
            this.txt_Autor.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Autor";
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(130, 111);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(341, 24);
            this.txt_Categoria.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoría";
            // 
            // txt_ISNB
            // 
            this.txt_ISNB.Location = new System.Drawing.Point(130, 48);
            this.txt_ISNB.Name = "txt_ISNB";
            this.txt_ISNB.Size = new System.Drawing.Size(341, 24);
            this.txt_ISNB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISNB";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(130, 18);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(341, 24);
            this.txt_Titulo.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.CausesValidation = false;
            this.tabPage2.Controls.Add(this.txt_Autor_stock);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_StockActual);
            this.tabPage2.Controls.Add(this.txt_Titulo_stock);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.RadBtn_Egreso);
            this.tabPage2.Controls.Add(this.RadBtt_Ingreso);
            this.tabPage2.Controls.Add(this.btn_IngresoEgreso);
            this.tabPage2.Controls.Add(this.txt_Cantidad);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_ISNB_stock);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso/Egreso de libros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Titulo_stock
            // 
            this.txt_Titulo_stock.Location = new System.Drawing.Point(73, 62);
            this.txt_Titulo_stock.Name = "txt_Titulo_stock";
            this.txt_Titulo_stock.Size = new System.Drawing.Size(269, 24);
            this.txt_Titulo_stock.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Titulo";
            // 
            // RadBtn_Egreso
            // 
            this.RadBtn_Egreso.AutoSize = true;
            this.RadBtn_Egreso.Location = new System.Drawing.Point(545, 159);
            this.RadBtn_Egreso.Name = "RadBtn_Egreso";
            this.RadBtn_Egreso.Size = new System.Drawing.Size(77, 22);
            this.RadBtn_Egreso.TabIndex = 13;
            this.RadBtn_Egreso.TabStop = true;
            this.RadBtn_Egreso.Text = "Egreso";
            this.RadBtn_Egreso.UseVisualStyleBackColor = true;
            // 
            // RadBtt_Ingreso
            // 
            this.RadBtt_Ingreso.AutoSize = true;
            this.RadBtt_Ingreso.Location = new System.Drawing.Point(545, 131);
            this.RadBtt_Ingreso.Name = "RadBtt_Ingreso";
            this.RadBtt_Ingreso.Size = new System.Drawing.Size(78, 22);
            this.RadBtt_Ingreso.TabIndex = 12;
            this.RadBtt_Ingreso.TabStop = true;
            this.RadBtt_Ingreso.Text = "Ingreso";
            this.RadBtt_Ingreso.UseVisualStyleBackColor = true;
            // 
            // btn_IngresoEgreso
            // 
            this.btn_IngresoEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IngresoEgreso.Location = new System.Drawing.Point(654, 150);
            this.btn_IngresoEgreso.Name = "btn_IngresoEgreso";
            this.btn_IngresoEgreso.Size = new System.Drawing.Size(91, 31);
            this.btn_IngresoEgreso.TabIndex = 11;
            this.btn_IngresoEgreso.Text = "Aceptar";
            this.btn_IngresoEgreso.UseVisualStyleBackColor = true;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(442, 150);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(78, 24);
            this.txt_Cantidad.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(352, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad";
            // 
            // txt_ISNB_stock
            // 
            this.txt_ISNB_stock.Location = new System.Drawing.Point(73, 32);
            this.txt_ISNB_stock.Name = "txt_ISNB_stock";
            this.txt_ISNB_stock.Size = new System.Drawing.Size(269, 24);
            this.txt_ISNB_stock.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "ISNB";
            // 
            // txt_StockActual
            // 
            this.txt_StockActual.AutoSize = true;
            this.txt_StockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StockActual.Location = new System.Drawing.Point(11, 92);
            this.txt_StockActual.Name = "txt_StockActual";
            this.txt_StockActual.Size = new System.Drawing.Size(113, 24);
            this.txt_StockActual.TabIndex = 16;
            this.txt_StockActual.Text = "Stock Actual";
            // 
            // txt_Autor_stock
            // 
            this.txt_Autor_stock.Location = new System.Drawing.Point(446, 32);
            this.txt_Autor_stock.Name = "txt_Autor_stock";
            this.txt_Autor_stock.Size = new System.Drawing.Size(269, 24);
            this.txt_Autor_stock.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Autor";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CargarLibro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ISNB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.RadioButton RadBtt_Ingreso;
        private System.Windows.Forms.Button btn_IngresoEgreso;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ISNB_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RadBtn_Egreso;
        private System.Windows.Forms.TextBox txt_Titulo_stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_StockActual;
        private System.Windows.Forms.TextBox txt_Autor_stock;
        private System.Windows.Forms.Label label9;
    }
}