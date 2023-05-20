namespace Vistas
{
    partial class FormGestionVentasVer
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
            this.dataVenta = new System.Windows.Forms.DataGridView();
            this.dateBox1 = new System.Windows.Forms.DateTimePicker();
            this.dateBox2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.productsBox = new System.Windows.Forms.ComboBox();
            this.clienteBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVenta
            // 
            this.dataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVenta.Location = new System.Drawing.Point(12, 80);
            this.dataVenta.Name = "dataVenta";
            this.dataVenta.RowTemplate.Height = 28;
            this.dataVenta.Size = new System.Drawing.Size(957, 494);
            this.dataVenta.TabIndex = 0;
            // 
            // dateBox1
            // 
            this.dateBox1.Location = new System.Drawing.Point(620, 37);
            this.dateBox1.Name = "dateBox1";
            this.dateBox1.Size = new System.Drawing.Size(107, 26);
            this.dateBox1.TabIndex = 1;
            // 
            // dateBox2
            // 
            this.dateBox2.Location = new System.Drawing.Point(746, 37);
            this.dateBox2.Name = "dateBox2";
            this.dateBox2.Size = new System.Drawing.Size(107, 26);
            this.dateBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Hasta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.filterByDate);
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(407, 34);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(171, 28);
            this.productsBox.TabIndex = 6;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.filterByProduct);
            // 
            // clienteBox
            // 
            this.clienteBox.FormattingEnabled = true;
            this.clienteBox.Location = new System.Drawing.Point(202, 34);
            this.clienteBox.Name = "clienteBox";
            this.clienteBox.Size = new System.Drawing.Size(171, 28);
            this.clienteBox.TabIndex = 7;
            this.clienteBox.SelectedIndexChanged += new System.EventHandler(this.filterByCustomer);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filtrar por Clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filtrar por Productos";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Limpiar Filtros";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormGestionVentasVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 570);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clienteBox);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateBox2);
            this.Controls.Add(this.dateBox1);
            this.Controls.Add(this.dataVenta);
            this.Name = "FormGestionVentasVer";
            this.Text = "FormGestionVentasCart";
            this.Load += new System.EventHandler(this.FormGestionVentasVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVenta;
        private System.Windows.Forms.DateTimePicker dateBox1;
        private System.Windows.Forms.DateTimePicker dateBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox productsBox;
        private System.Windows.Forms.ComboBox clienteBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}