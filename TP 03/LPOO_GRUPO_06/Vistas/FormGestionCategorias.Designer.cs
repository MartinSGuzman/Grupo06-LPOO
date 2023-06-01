namespace Vistas
{
    partial class FormGestionCategorias
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.categoryData = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancellButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handleSave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(659, 110);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(218, 26);
            this.descriptionBox.TabIndex = 2;
            // 
            // categoryData
            // 
            this.categoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryData.Location = new System.Drawing.Point(12, 86);
            this.categoryData.Name = "categoryData";
            this.categoryData.RowTemplate.Height = 28;
            this.categoryData.Size = new System.Drawing.Size(570, 398);
            this.categoryData.TabIndex = 3;
            this.categoryData.CurrentCellChanged += new System.EventHandler(this.categoryData_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Editar O Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.handleEditVisible);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(592, 319);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(285, 46);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Borrar";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.handleRemoveC);
            // 
            // cancellButton
            // 
            this.cancellButton.Location = new System.Drawing.Point(592, 391);
            this.cancellButton.Name = "cancellButton";
            this.cancellButton.Size = new System.Drawing.Size(285, 46);
            this.cancellButton.TabIndex = 6;
            this.cancellButton.Text = "CANCELAR";
            this.cancellButton.UseVisualStyleBackColor = true;
            this.cancellButton.Visible = false;
            this.cancellButton.Click += new System.EventHandler(this.handleCancell);
            // 
            // FormGestionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 515);
            this.Controls.Add(this.cancellButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.categoryData);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormGestionCategorias";
            this.Text = "FormGestionCategorias";
            this.Load += new System.EventHandler(this.FormGestionCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.DataGridView categoryData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancellButton;
    }
}