namespace Vistas
{
    partial class FormGestionUsuarios
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
            this.rolBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.userbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datagridusers = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.borraruser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridusers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rolBox
            // 
            this.rolBox.FormattingEnabled = true;
            this.rolBox.Location = new System.Drawing.Point(656, 88);
            this.rolBox.Name = "rolBox";
            this.rolBox.Size = new System.Drawing.Size(226, 28);
            this.rolBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(654, 189);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(227, 26);
            this.username_box.TabIndex = 3;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(656, 249);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(227, 26);
            this.password_box.TabIndex = 4;
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(654, 134);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(227, 26);
            this.userbox.TabIndex = 5;
            this.userbox.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handleSaveUser);
            // 
            // datagridusers
            // 
            this.datagridusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridusers.Location = new System.Drawing.Point(22, 37);
            this.datagridusers.Name = "datagridusers";
            this.datagridusers.RowTemplate.Height = 28;
            this.datagridusers.Size = new System.Drawing.Size(496, 307);
            this.datagridusers.TabIndex = 10;
            this.datagridusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridusers_CellContentClick);
            this.datagridusers.CurrentCellChanged += new System.EventHandler(this.datagridusers_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "HOLA!";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Salmon;
            this.username.Location = new System.Drawing.Point(713, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 20);
            this.username.TabIndex = 12;
            // 
            // borraruser
            // 
            this.borraruser.Location = new System.Drawing.Point(22, 350);
            this.borraruser.Name = "borraruser";
            this.borraruser.Size = new System.Drawing.Size(307, 34);
            this.borraruser.TabIndex = 13;
            this.borraruser.Text = "Borrar";
            this.borraruser.UseVisualStyleBackColor = true;
            this.borraruser.Click += new System.EventHandler(this.removeUser);
            // 
            // FormGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 390);
            this.Controls.Add(this.borraruser);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datagridusers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolBox);
            this.Name = "FormGestionUsuarios";
            this.Text = "FormGestionUsuarios";
            this.Load += new System.EventHandler(this.FormGestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rolBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datagridusers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button borraruser;
    }
}