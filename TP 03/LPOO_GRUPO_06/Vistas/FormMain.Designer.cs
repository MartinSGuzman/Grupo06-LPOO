namespace Vistas
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gestionUsuarioMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.nameUser = new System.Windows.Forms.Label();
            this.gestionClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionObraSocialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProductosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(330, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUsuarioMenuStrip,
            this.gestionClientesToolStripMenuItem,
            this.gestionProductosToolStripMenuItem,
            this.gestionVentasToolStripMenuItem,
            this.verVentasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(989, 33);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gestionUsuarioMenuStrip
            // 
            this.gestionUsuarioMenuStrip.Name = "gestionUsuarioMenuStrip";
            this.gestionUsuarioMenuStrip.Size = new System.Drawing.Size(180, 29);
            this.gestionUsuarioMenuStrip.Text = "Gestion de usuarios";
            this.gestionUsuarioMenuStrip.Click += new System.EventHandler(this.gestionToolStripMenuItem_Click);
            // 
            // gestionClientesToolStripMenuItem
            // 
            this.gestionClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientesToolStripMenuItem1,
            this.gestionObraSocialToolStripMenuItem1});
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.gestionClientesToolStripMenuItem.Text = "Gestion Clientes";
            // 
            // gestionProductosToolStripMenuItem
            // 
            this.gestionProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionCategoriasToolStripMenuItem,
            this.gestionProductosToolStripMenuItem1});
            this.gestionProductosToolStripMenuItem.Name = "gestionProductosToolStripMenuItem";
            this.gestionProductosToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.gestionProductosToolStripMenuItem.Text = "Gestion Productos";
            // 
            // gestionCategoriasToolStripMenuItem
            // 
            this.gestionCategoriasToolStripMenuItem.Name = "gestionCategoriasToolStripMenuItem";
            this.gestionCategoriasToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.gestionCategoriasToolStripMenuItem.Text = "Gestion Categorias";
            this.gestionCategoriasToolStripMenuItem.Click += new System.EventHandler(this.gestionCategoriasToolStripMenuItem_Click);
            // 
            // gestionVentasToolStripMenuItem
            // 
            this.gestionVentasToolStripMenuItem.Name = "gestionVentasToolStripMenuItem";
            this.gestionVentasToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.gestionVentasToolStripMenuItem.Text = "Gestion Ventas";
            this.gestionVentasToolStripMenuItem.Click += new System.EventHandler(this.gestionVentasToolStripMenuItem_Click);
            // 
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.verVentasToolStripMenuItem.Text = "Ver Ventas";
            this.verVentasToolStripMenuItem.Click += new System.EventHandler(this.verVentasToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handle_singout);
            // 
            // nameUser
            // 
            this.nameUser.AutoSize = true;
            this.nameUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameUser.ForeColor = System.Drawing.Color.Brown;
            this.nameUser.Location = new System.Drawing.Point(330, 84);
            this.nameUser.Name = "nameUser";
            this.nameUser.Size = new System.Drawing.Size(2, 22);
            this.nameUser.TabIndex = 4;
            // 
            // gestionClientesToolStripMenuItem1
            // 
            this.gestionClientesToolStripMenuItem1.Name = "gestionClientesToolStripMenuItem1";
            this.gestionClientesToolStripMenuItem1.Size = new System.Drawing.Size(235, 30);
            this.gestionClientesToolStripMenuItem1.Text = "Gestion Clientes";
            this.gestionClientesToolStripMenuItem1.Click += new System.EventHandler(this.formGestion);
            // 
            // gestionObraSocialToolStripMenuItem1
            // 
            this.gestionObraSocialToolStripMenuItem1.Name = "gestionObraSocialToolStripMenuItem1";
            this.gestionObraSocialToolStripMenuItem1.Size = new System.Drawing.Size(235, 30);
            this.gestionObraSocialToolStripMenuItem1.Text = "Gestion ObraSocial";
            this.gestionObraSocialToolStripMenuItem1.Click += new System.EventHandler(this.gestionObraSocialToolStripMenuItem_Click);
            // 
            // gestionProductosToolStripMenuItem1
            // 
            this.gestionProductosToolStripMenuItem1.Name = "gestionProductosToolStripMenuItem1";
            this.gestionProductosToolStripMenuItem1.Size = new System.Drawing.Size(233, 30);
            this.gestionProductosToolStripMenuItem1.Text = "Gestion Productos";
            this.gestionProductosToolStripMenuItem1.Click += new System.EventHandler(this.gestionProductosToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 453);
            this.Controls.Add(this.nameUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Click += new System.EventHandler(this.handle_singout);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuarioMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVentasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem verVentasToolStripMenuItem;
        private System.Windows.Forms.Label nameUser;
        private System.Windows.Forms.ToolStripMenuItem gestionCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionObraSocialToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionProductosToolStripMenuItem1;
    }
}