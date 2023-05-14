namespace Vistas
{
    partial class Productos
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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.dgwProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cat = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.codigoProducto = new System.Windows.Forms.TextBox();
            this.categoriaProducto = new System.Windows.Forms.TextBox();
            this.descripcionProducto = new System.Windows.Forms.TextBox();
            this.precioProducto = new System.Windows.Forms.TextBox();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(189, 4);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(75, 34);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "Filtrar por Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(376, 2);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(75, 38);
            this.btnDescripcion.TabIndex = 1;
            this.btnDescripcion.Text = "Filtrar por Descripcion";
            this.btnDescripcion.UseVisualStyleBackColor = true;
            // 
            // dgwProductos
            // 
            this.dgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductos.Location = new System.Drawing.Point(25, 46);
            this.dgwProductos.Name = "dgwProductos";
            this.dgwProductos.Size = new System.Drawing.Size(479, 326);
            this.dgwProductos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Productos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(270, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardarProducto);
            this.panel1.Controls.Add(this.precioProducto);
            this.panel1.Controls.Add(this.descripcionProducto);
            this.panel1.Controls.Add(this.categoriaProducto);
            this.panel1.Controls.Add(this.codigoProducto);
            this.panel1.Controls.Add(this.Precio);
            this.panel1.Controls.Add(this.Desc);
            this.panel1.Controls.Add(this.cat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.regis);
            this.panel1.Location = new System.Drawing.Point(524, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 326);
            this.panel1.TabIndex = 6;
            // 
            // regis
            // 
            this.regis.AutoSize = true;
            this.regis.Location = new System.Drawing.Point(75, 12);
            this.regis.Name = "regis";
            this.regis.Size = new System.Drawing.Size(95, 13);
            this.regis.TabIndex = 0;
            this.regis.Text = "Registrar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Producto";
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Location = new System.Drawing.Point(25, 95);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(115, 13);
            this.cat.TabIndex = 2;
            this.cat.Text = "Categoria del Producto";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(25, 143);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(63, 13);
            this.Desc.TabIndex = 3;
            this.Desc.Text = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(25, 243);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(37, 13);
            this.Precio.TabIndex = 4;
            this.Precio.Text = "Precio";
            // 
            // codigoProducto
            // 
            this.codigoProducto.Location = new System.Drawing.Point(28, 63);
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.Size = new System.Drawing.Size(100, 20);
            this.codigoProducto.TabIndex = 5;
            // 
            // categoriaProducto
            // 
            this.categoriaProducto.Location = new System.Drawing.Point(28, 111);
            this.categoriaProducto.Name = "categoriaProducto";
            this.categoriaProducto.Size = new System.Drawing.Size(100, 20);
            this.categoriaProducto.TabIndex = 6;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.Location = new System.Drawing.Point(28, 159);
            this.descripcionProducto.Multiline = true;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.Size = new System.Drawing.Size(197, 81);
            this.descripcionProducto.TabIndex = 7;
            // 
            // precioProducto
            // 
            this.precioProducto.Location = new System.Drawing.Point(28, 268);
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.Size = new System.Drawing.Size(100, 20);
            this.precioProducto.TabIndex = 8;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Location = new System.Drawing.Point(150, 268);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProducto.TabIndex = 9;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwProductos);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.btnCategoria);
            this.Name = "Productos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnDescripcion;
        private System.Windows.Forms.DataGridView dgwProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label regis;
        private System.Windows.Forms.TextBox precioProducto;
        private System.Windows.Forms.TextBox descripcionProducto;
        private System.Windows.Forms.TextBox categoriaProducto;
        private System.Windows.Forms.TextBox codigoProducto;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Label cat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarProducto;
    }
}

