﻿namespace Vistas
{
    partial class Main
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
            this.cmbRol_Id = new System.Windows.Forms.ComboBox();
            this.RolIn = new System.Windows.Forms.Label();
            this.ApellidoIn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SaveUser = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.ContraIn = new System.Windows.Forms.Label();
            this.UsuarioIn = new System.Windows.Forms.Label();
            this.txtUsu_ApellidoNombre1 = new System.Windows.Forms.TextBox();
            this.dgwUsuarios = new System.Windows.Forms.DataGridView();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol_Id
            // 
            this.cmbRol_Id.FormattingEnabled = true;
            this.cmbRol_Id.Location = new System.Drawing.Point(135, 78);
            this.cmbRol_Id.Name = "cmbRol_Id";
            this.cmbRol_Id.Size = new System.Drawing.Size(121, 21);
            this.cmbRol_Id.TabIndex = 0;
            // 
            // RolIn
            // 
            this.RolIn.AutoSize = true;
            this.RolIn.Location = new System.Drawing.Point(52, 81);
            this.RolIn.Name = "RolIn";
            this.RolIn.Size = new System.Drawing.Size(23, 13);
            this.RolIn.TabIndex = 1;
            this.RolIn.Text = "Rol";
            // 
            // ApellidoIn
            // 
            this.ApellidoIn.AutoSize = true;
            this.ApellidoIn.Location = new System.Drawing.Point(22, 34);
            this.ApellidoIn.Name = "ApellidoIn";
            this.ApellidoIn.Size = new System.Drawing.Size(92, 13);
            this.ApellidoIn.TabIndex = 2;
            this.ApellidoIn.Text = "Apellido y Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.SaveUser);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.ContraIn);
            this.groupBox1.Controls.Add(this.UsuarioIn);
            this.groupBox1.Controls.Add(this.txtUsu_ApellidoNombre1);
            this.groupBox1.Controls.Add(this.ApellidoIn);
            this.groupBox1.Controls.Add(this.RolIn);
            this.groupBox1.Controls.Add(this.cmbRol_Id);
            this.groupBox1.Location = new System.Drawing.Point(523, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 335);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(25, 256);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // SaveUser
            // 
            this.SaveUser.Location = new System.Drawing.Point(193, 256);
            this.SaveUser.Name = "SaveUser";
            this.SaveUser.Size = new System.Drawing.Size(75, 23);
            this.SaveUser.TabIndex = 12;
            this.SaveUser.Text = "Guardar";
            this.SaveUser.UseVisualStyleBackColor = true;
            this.SaveUser.Click += new System.EventHandler(this.SaveUser_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(135, 187);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(135, 136);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // ContraIn
            // 
            this.ContraIn.AutoSize = true;
            this.ContraIn.Location = new System.Drawing.Point(25, 187);
            this.ContraIn.Name = "ContraIn";
            this.ContraIn.Size = new System.Drawing.Size(63, 17);
            this.ContraIn.TabIndex = 9;
            this.ContraIn.Text = "Contrasena";
            this.ContraIn.UseCompatibleTextRendering = true;
            // 
            // UsuarioIn
            // 
            this.UsuarioIn.AutoSize = true;
            this.UsuarioIn.Location = new System.Drawing.Point(34, 136);
            this.UsuarioIn.Name = "UsuarioIn";
            this.UsuarioIn.Size = new System.Drawing.Size(43, 13);
            this.UsuarioIn.TabIndex = 8;
            this.UsuarioIn.Text = "Usuario";
            // 
            // txtUsu_ApellidoNombre1
            // 
            this.txtUsu_ApellidoNombre1.Location = new System.Drawing.Point(135, 31);
            this.txtUsu_ApellidoNombre1.Name = "txtUsu_ApellidoNombre1";
            this.txtUsu_ApellidoNombre1.Size = new System.Drawing.Size(121, 20);
            this.txtUsu_ApellidoNombre1.TabIndex = 3;
            this.txtUsu_ApellidoNombre1.TabStop = false;
            this.txtUsu_ApellidoNombre1.TextChanged += new System.EventHandler(this.txtUsu_ApellidoNombre1_TextChanged);
            // 
            // dgwUsuarios
            // 
            this.dgwUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuarios.Location = new System.Drawing.Point(22, 81);
            this.dgwUsuarios.Name = "dgwUsuarios";
            this.dgwUsuarios.Size = new System.Drawing.Size(489, 303);
            this.dgwUsuarios.TabIndex = 4;
            this.dgwUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUsuarios_CellContentClick);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(22, 46);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(457, 20);
            this.txtPattern.TabIndex = 6;
            this.txtPattern.TabStop = false;
            this.txtPattern.TextChanged += new System.EventHandler(this.txtPattern_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(523, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(112, 256);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Consulta Clientes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.dgwUsuarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRol_Id;
        private System.Windows.Forms.Label RolIn;
        private System.Windows.Forms.Label ApellidoIn;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsu_ApellidoNombre1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label ContraIn;
        private System.Windows.Forms.Label UsuarioIn;
        private System.Windows.Forms.Button SaveUser;
        private System.Windows.Forms.DataGridView dgwUsuarios;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;

    }
}