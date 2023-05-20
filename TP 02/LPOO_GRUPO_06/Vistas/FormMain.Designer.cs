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
            this.gestionVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gestionClientesToolStripMenuItem.Name = "gestionClientesToolStripMenuItem";
            this.gestionClientesToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.gestionClientesToolStripMenuItem.Text = "Gestion Clientes";
            this.gestionClientesToolStripMenuItem.Click += new System.EventHandler(this.formGestion);
            // 
            // gestionProductosToolStripMenuItem
            // 
            this.gestionProductosToolStripMenuItem.Name = "gestionProductosToolStripMenuItem";
            this.gestionProductosToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.gestionProductosToolStripMenuItem.Text = "Gestion Productos";
            this.gestionProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionProductosToolStripMenuItem_Click);
            // 
            // gestionVentasToolStripMenuItem
            // 
            this.gestionVentasToolStripMenuItem.Name = "gestionVentasToolStripMenuItem";
            this.gestionVentasToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.gestionVentasToolStripMenuItem.Text = "Gestion Ventas";
            this.gestionVentasToolStripMenuItem.Click += new System.EventHandler(this.gestionVentasToolStripMenuItem_Click);
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
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.verVentasToolStripMenuItem.Text = "Ver Ventas";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 453);
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
    }
}