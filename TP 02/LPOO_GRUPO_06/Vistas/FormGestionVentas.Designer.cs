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
            this.ventaDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obra Social";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 493);
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
            this.obraSocialBox.Location = new System.Drawing.Point(730, 99);
            this.obraSocialBox.Name = "obraSocialBox";
            this.obraSocialBox.Size = new System.Drawing.Size(226, 28);
            this.obraSocialBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha";
            // 
            // codigoBox
            // 
            this.codigoBox.Location = new System.Drawing.Point(730, 230);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(226, 26);
            this.codigoBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "cantidad";
            // 
            // clienteBox
            // 
            this.clienteBox.FormattingEnabled = true;
            this.clienteBox.Location = new System.Drawing.Point(730, 144);
            this.clienteBox.Name = "clienteBox";
            this.clienteBox.Size = new System.Drawing.Size(226, 28);
            this.clienteBox.TabIndex = 15;
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(730, 183);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(226, 28);
            this.productsBox.TabIndex = 16;
            this.productsBox.SelectedIndexChanged += new System.EventHandler(this.handle_selectedProduct);
            // 
            // cantBox
            // 
            this.cantBox.Location = new System.Drawing.Point(730, 322);
            this.cantBox.Name = "cantBox";
            this.cantBox.Size = new System.Drawing.Size(120, 26);
            this.cantBox.TabIndex = 17;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(730, 367);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 26);
            this.dateBox.TabIndex = 18;
            // 
            // ventaDataGridView
            // 
            this.ventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDataGridView.Location = new System.Drawing.Point(9, 63);
            this.ventaDataGridView.Name = "ventaDataGridView";
            this.ventaDataGridView.RowTemplate.Height = 28;
            this.ventaDataGridView.Size = new System.Drawing.Size(611, 459);
            this.ventaDataGridView.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(314, 29);
            this.button3.TabIndex = 27;
            this.button3.Text = "Añadir al carrito";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.add_cart);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "CARRITO DE COMPRAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(726, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "TOTAL:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.totalLabel.Location = new System.Drawing.Point(729, 29);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 20);
            this.totalLabel.TabIndex = 30;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(729, 282);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(18, 20);
            this.priceLabel.TabIndex = 31;
            this.priceLabel.Text = "0";
            // 
            // FormGestionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 534);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ventaDataGridView);
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
        private System.Windows.Forms.DataGridView ventaDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label priceLabel;
    }
}