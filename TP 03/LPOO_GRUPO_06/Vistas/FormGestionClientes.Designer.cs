namespace Vistas
{
    partial class FormGestionClientes
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
            this.dni = new System.Windows.Forms.Label();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.os_cuitBox = new System.Windows.Forms.TextBox();
            this.carnet_numberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.lastnamerBox = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.osBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.removeBox = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(679, 122);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(30, 20);
            this.dni.TabIndex = 0;
            this.dni.Text = "dni";
            this.dni.Click += new System.EventHandler(this.dni_Click);
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(715, 119);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(217, 26);
            this.dniBox.TabIndex = 0;
            this.dniBox.TextChanged += new System.EventHandler(this.dniBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(715, 151);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(217, 26);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(715, 183);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(217, 26);
            this.lastnameBox.TabIndex = 2;
            this.lastnameBox.TextChanged += new System.EventHandler(this.lastnameBox_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(715, 213);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(217, 26);
            this.addressBox.TabIndex = 3;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // os_cuitBox
            // 
            this.os_cuitBox.Location = new System.Drawing.Point(716, 245);
            this.os_cuitBox.Name = "os_cuitBox";
            this.os_cuitBox.Size = new System.Drawing.Size(217, 26);
            this.os_cuitBox.TabIndex = 4;
            this.os_cuitBox.TextChanged += new System.EventHandler(this.os_cuitBox_TextChanged);
            // 
            // carnet_numberBox
            // 
            this.carnet_numberBox.Location = new System.Drawing.Point(716, 279);
            this.carnet_numberBox.Name = "carnet_numberBox";
            this.carnet_numberBox.Size = new System.Drawing.Size(217, 26);
            this.carnet_numberBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "cuit de obra social";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "numero de carnet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_user);
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(12, 60);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.RowTemplate.Height = 28;
            this.customerDataGrid.Size = new System.Drawing.Size(517, 330);
            this.customerDataGrid.TabIndex = 9;
            this.customerDataGrid.CurrentCellChanged += new System.EventHandler(this.customerDataGrid_CurrentCellChanged);
            // 
            // lastnamerBox
            // 
            this.lastnamerBox.AutoSize = true;
            this.lastnamerBox.Location = new System.Drawing.Point(135, 12);
            this.lastnamerBox.Name = "lastnamerBox";
            this.lastnamerBox.Size = new System.Drawing.Size(179, 24);
            this.lastnamerBox.TabIndex = 8;
            this.lastnamerBox.Text = "Ordenar por Apellido";
            this.lastnamerBox.UseVisualStyleBackColor = true;
            this.lastnamerBox.Click += new System.EventHandler(this.orderbylastname);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "Limpiar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.FormGestionClientes_Load);
            // 
            // osBox
            // 
            this.osBox.FormattingEnabled = true;
            this.osBox.Location = new System.Drawing.Point(715, 82);
            this.osBox.Name = "osBox";
            this.osBox.Size = new System.Drawing.Size(213, 28);
            this.osBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Obra Social";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Editar O Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.handleEditVisible);
            // 
            // removeBox
            // 
            this.removeBox.BackColor = System.Drawing.Color.LightCoral;
            this.removeBox.Location = new System.Drawing.Point(255, 396);
            this.removeBox.Name = "removeBox";
            this.removeBox.Size = new System.Drawing.Size(219, 34);
            this.removeBox.TabIndex = 15;
            this.removeBox.Text = "Borrar";
            this.removeBox.UseVisualStyleBackColor = false;
            this.removeBox.Visible = false;
            this.removeBox.Click += new System.EventHandler(this.handleRemoveC);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(490, 396);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(219, 34);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.handleCancell);
            // 
            // FormGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 478);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.osBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lastnamerBox);
            this.Controls.Add(this.customerDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carnet_numberBox);
            this.Controls.Add(this.os_cuitBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.dni);
            this.Name = "FormGestionClientes";
            this.Text = "FormGestionClientes";
            this.Load += new System.EventHandler(this.FormGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox os_cuitBox;
        private System.Windows.Forms.TextBox carnet_numberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView customerDataGrid;
        private System.Windows.Forms.RadioButton lastnamerBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox osBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removeBox;
        private System.Windows.Forms.Button cancelButton;
    }
}