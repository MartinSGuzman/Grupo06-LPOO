namespace Vistas
{
    partial class FormGestionObraSocial
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
            this.saveButton = new System.Windows.Forms.Button();
            this.obrasocialdata = new System.Windows.Forms.DataGridView();
            this.razonBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrasocialdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(666, 241);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(279, 36);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.handleSave);
            // 
            // obrasocialdata
            // 
            this.obrasocialdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.obrasocialdata.Location = new System.Drawing.Point(24, 43);
            this.obrasocialdata.Name = "obrasocialdata";
            this.obrasocialdata.RowTemplate.Height = 28;
            this.obrasocialdata.Size = new System.Drawing.Size(632, 397);
            this.obrasocialdata.TabIndex = 6;
            this.obrasocialdata.CurrentCellChanged += new System.EventHandler(this.obrasocialdata_CurrentCellChanged);
            // 
            // razonBox
            // 
            this.razonBox.Location = new System.Drawing.Point(771, 87);
            this.razonBox.Name = "razonBox";
            this.razonBox.Size = new System.Drawing.Size(174, 26);
            this.razonBox.TabIndex = 1;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(771, 128);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(174, 26);
            this.addressBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(771, 192);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(174, 26);
            this.phoneBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(771, 160);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(174, 26);
            this.numberBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(666, 303);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(279, 36);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Editar O Borrar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.handleVisibleEdit);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Salmon;
            this.removeButton.Location = new System.Drawing.Point(666, 357);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(279, 36);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Borrar";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.handleRemoveO);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Salmon;
            this.cancelButton.Location = new System.Drawing.Point(666, 408);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(279, 36);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.handleCancell);
            // 
            // FormGestionObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 477);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.razonBox);
            this.Controls.Add(this.obrasocialdata);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionObraSocial";
            this.Text = "FormGestionObraSocial";
            this.Load += new System.EventHandler(this.FormGestionObraSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obrasocialdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView obrasocialdata;
        private System.Windows.Forms.TextBox razonBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}