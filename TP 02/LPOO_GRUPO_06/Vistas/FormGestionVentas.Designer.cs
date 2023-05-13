namespace Vistas
{
    partial class FormGestionVentas
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
            this.button1 = new System.Windows.Forms.Button();
            this.obraSocialBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.codigoBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clienteBox = new System.Windows.Forms.ComboBox();
            this.productsBox = new System.Windows.Forms.ComboBox();
            this.cantBox = new System.Windows.Forms.NumericUpDown();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.ventaDataGridView = new System.Windows.Forms.DataGridView();
            this.filterCustomerBox = new System.Windows.Forms.ComboBox();
            this.dateBox1 = new System.Windows.Forms.DateTimePicker();
            this.dateBox2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obra Social";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "VENDER!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handle_sell);
            // 
            // obraSocialBox
            // 
            this.obraSocialBox.FormattingEnabled = true;
            this.obraSocialBox.Location = new System.Drawing.Point(714, 50);
            this.obraSocialBox.Name = "obraSocialBox";
            this.obraSocialBox.Size = new System.Drawing.Size(226, 28);
            this.obraSocialBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(650, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha";
            // 
            // codigoBox
            // 
            this.codigoBox.Location = new System.Drawing.Point(714, 181);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(226, 26);
            this.codigoBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(633, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "cantidad";
            // 
            // clienteBox
            // 
            this.clienteBox.FormattingEnabled = true;
            this.clienteBox.Location = new System.Drawing.Point(714, 95);
            this.clienteBox.Name = "clienteBox";
            this.clienteBox.Size = new System.Drawing.Size(226, 28);
            this.clienteBox.TabIndex = 15;
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(714, 134);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(226, 28);
            this.productsBox.TabIndex = 16;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.handle_selectedProduct);
            // 
            // cantBox
            // 
            this.cantBox.Location = new System.Drawing.Point(714, 273);
            this.cantBox.Name = "cantBox";
            this.cantBox.Size = new System.Drawing.Size(120, 26);
            this.cantBox.TabIndex = 17;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(714, 318);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 26);
            this.dateBox.TabIndex = 18;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(714, 227);
            this.priceBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(120, 26);
            this.priceBox.TabIndex = 20;
            // 
            // ventaDataGridView
            // 
            this.ventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDataGridView.Location = new System.Drawing.Point(9, 103);
            this.ventaDataGridView.Name = "ventaDataGridView";
            this.ventaDataGridView.RowTemplate.Height = 28;
            this.ventaDataGridView.Size = new System.Drawing.Size(603, 314);
            this.ventaDataGridView.TabIndex = 21;
            // 
            // filterCustomerBox
            // 
            this.filterCustomerBox.FormattingEnabled = true;
            this.filterCustomerBox.Location = new System.Drawing.Point(9, 50);
            this.filterCustomerBox.Name = "filterCustomerBox";
            this.filterCustomerBox.Size = new System.Drawing.Size(226, 28);
            this.filterCustomerBox.TabIndex = 22;
            this.filterCustomerBox.SelectedIndexChanged += new System.EventHandler(this.filterByCustomer);
            // 
            // dateBox1
            // 
            this.dateBox1.Location = new System.Drawing.Point(372, 50);
            this.dateBox1.Name = "dateBox1";
            this.dateBox1.Size = new System.Drawing.Size(92, 26);
            this.dateBox1.TabIndex = 23;
            this.dateBox1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateBox2
            // 
            this.dateBox2.Location = new System.Drawing.Point(470, 50);
            this.dateBox2.Name = "dateBox2";
            this.dateBox2.Size = new System.Drawing.Size(92, 26);
            this.dateBox2.TabIndex = 24;
            this.dateBox2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Filtrar por Cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 29);
            this.button2.TabIndex = 26;
            this.button2.Text = "Filtrar por fecha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.filterByDate);
            // 
            // FormGestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateBox2);
            this.Controls.Add(this.dateBox1);
            this.Controls.Add(this.filterCustomerBox);
            this.Controls.Add(this.ventaDataGridView);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.cantBox);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.clienteBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.obraSocialBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionVentas";
            this.Text = "FormGestionVentas";
            this.Load += new System.EventHandler(this.FormGestionVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox obraSocialBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox clienteBox;
        private System.Windows.Forms.ComboBox productsBox;
        private System.Windows.Forms.NumericUpDown cantBox;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.DataGridView ventaDataGridView;
        private System.Windows.Forms.ComboBox filterCustomerBox;
        private System.Windows.Forms.DateTimePicker dateBox1;
        private System.Windows.Forms.DateTimePicker dateBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}