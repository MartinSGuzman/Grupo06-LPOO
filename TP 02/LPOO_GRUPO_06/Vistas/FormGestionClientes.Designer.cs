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
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(641, 36);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(30, 20);
            this.dni.TabIndex = 0;
            this.dni.Text = "dni";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(677, 33);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(217, 26);
            this.dniBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(677, 82);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(217, 26);
            this.nameBox.TabIndex = 2;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(677, 138);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(217, 26);
            this.lastnameBox.TabIndex = 3;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(677, 190);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(217, 26);
            this.addressBox.TabIndex = 4;
            // 
            // os_cuitBox
            // 
            this.os_cuitBox.Location = new System.Drawing.Point(677, 244);
            this.os_cuitBox.Name = "os_cuitBox";
            this.os_cuitBox.Size = new System.Drawing.Size(217, 26);
            this.os_cuitBox.TabIndex = 5;
            // 
            // carnet_numberBox
            // 
            this.carnet_numberBox.Location = new System.Drawing.Point(677, 305);
            this.carnet_numberBox.Name = "carnet_numberBox";
            this.carnet_numberBox.Size = new System.Drawing.Size(217, 26);
            this.carnet_numberBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "cuit de obra social";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "numero de carnet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_user);
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Location = new System.Drawing.Point(12, 33);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.RowTemplate.Height = 28;
            this.customerDataGrid.Size = new System.Drawing.Size(517, 357);
            this.customerDataGrid.TabIndex = 13;
            // 
            // FormGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 406);
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
    }
}