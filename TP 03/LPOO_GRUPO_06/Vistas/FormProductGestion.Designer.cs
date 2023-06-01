﻿namespace Vistas
{
    partial class FormProductGestion
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
            this.productsData = new System.Windows.Forms.DataGridView();
            this.Guardar = new System.Windows.Forms.Button();
            this.categoriesBox = new System.Windows.Forms.ComboBox();
            this.DescripcionBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.keyProductBox = new System.Windows.Forms.NumericUpDown();
            this.Codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.handleRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.handleCancell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyProductBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productsData
            // 
            this.productsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsData.Location = new System.Drawing.Point(12, 72);
            this.productsData.Name = "productsData";
            this.productsData.RowTemplate.Height = 28;
            this.productsData.Size = new System.Drawing.Size(660, 370);
            this.productsData.TabIndex = 0;
            this.productsData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsData_CellContentClick);
            this.productsData.CurrentCellChanged += new System.EventHandler(this.productsData_CurrentCellChanged);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(726, 403);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(213, 33);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.handleSaveProduct);
            // 
            // categoriesBox
            // 
            this.categoriesBox.FormattingEnabled = true;
            this.categoriesBox.Location = new System.Drawing.Point(765, 121);
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.Size = new System.Drawing.Size(199, 28);
            this.categoriesBox.TabIndex = 3;
            // 
            // DescripcionBox
            // 
            this.DescripcionBox.Location = new System.Drawing.Point(765, 176);
            this.DescripcionBox.Name = "DescripcionBox";
            this.DescripcionBox.Size = new System.Drawing.Size(199, 26);
            this.DescripcionBox.TabIndex = 4;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(765, 229);
            this.priceBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(191, 26);
            this.priceBox.TabIndex = 6;
            // 
            // keyProductBox
            // 
            this.keyProductBox.Location = new System.Drawing.Point(765, 66);
            this.keyProductBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.keyProductBox.Name = "keyProductBox";
            this.keyProductBox.Size = new System.Drawing.Size(191, 26);
            this.keyProductBox.TabIndex = 9;
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(691, 72);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(59, 20);
            this.Codigo.TabIndex = 10;
            this.Codigo.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Precio";
            // 
            // handleRemove
            // 
            this.handleRemove.Location = new System.Drawing.Point(12, 463);
            this.handleRemove.Name = "handleRemove";
            this.handleRemove.Size = new System.Drawing.Size(213, 33);
            this.handleRemove.TabIndex = 14;
            this.handleRemove.Text = "Borrar";
            this.handleRemove.UseVisualStyleBackColor = true;
            this.handleRemove.Visible = false;
            this.handleRemove.Click += new System.EventHandler(this.deleteProduct);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 33);
            this.button2.TabIndex = 15;
            this.button2.Text = "Editar O Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.handleEditVisible);
            // 
            // handleCancell
            // 
            this.handleCancell.Location = new System.Drawing.Point(479, 463);
            this.handleCancell.Name = "handleCancell";
            this.handleCancell.Size = new System.Drawing.Size(213, 33);
            this.handleCancell.TabIndex = 16;
            this.handleCancell.Text = "Cancelar";
            this.handleCancell.UseVisualStyleBackColor = true;
            this.handleCancell.Visible = false;
            this.handleCancell.Click += new System.EventHandler(this.handleRemoveVisible);
            // 
            // FormProductGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 526);
            this.Controls.Add(this.handleCancell);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.handleRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.keyProductBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.DescripcionBox);
            this.Controls.Add(this.categoriesBox);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.productsData);
            this.Controls.Add(this.label2);
            this.Name = "FormProductGestion";
            this.Text = "FormProductGestion";
            this.Load += new System.EventHandler(this.FormProductGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyProductBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsData;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.ComboBox categoriesBox;
        private System.Windows.Forms.TextBox DescripcionBox;
        private System.Windows.Forms.NumericUpDown priceBox;
        private System.Windows.Forms.NumericUpDown keyProductBox;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button handleRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button handleCancell;
    }
}