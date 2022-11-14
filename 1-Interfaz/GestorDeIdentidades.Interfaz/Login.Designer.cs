namespace GestorDeIdentidades.Interfaz
{
    partial class Login
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
            this.InputUsuario = new System.Windows.Forms.TextBox();
            this.BotonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputContrasena = new System.Windows.Forms.TextBox();
            this.BotonRegistrarse = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputUsuario
            // 
            this.InputUsuario.Location = new System.Drawing.Point(148, 83);
            this.InputUsuario.Name = "InputUsuario";
            this.InputUsuario.Size = new System.Drawing.Size(100, 20);
            this.InputUsuario.TabIndex = 0;
            // 
            // BotonLogin
            // 
            this.BotonLogin.Location = new System.Drawing.Point(133, 168);
            this.BotonLogin.Name = "BotonLogin";
            this.BotonLogin.Size = new System.Drawing.Size(75, 23);
            this.BotonLogin.TabIndex = 1;
            this.BotonLogin.Text = "Login";
            this.BotonLogin.UseVisualStyleBackColor = true;
            this.BotonLogin.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar al sistema";
            // 
            // InputContrasena
            // 
            this.InputContrasena.Location = new System.Drawing.Point(148, 126);
            this.InputContrasena.Name = "InputContrasena";
            this.InputContrasena.Size = new System.Drawing.Size(100, 20);
            this.InputContrasena.TabIndex = 0;
            // 
            // BotonRegistrarse
            // 
            this.BotonRegistrarse.AutoSize = true;
            this.BotonRegistrarse.Location = new System.Drawing.Point(145, 207);
            this.BotonRegistrarse.Name = "BotonRegistrarse";
            this.BotonRegistrarse.Size = new System.Drawing.Size(60, 13);
            this.BotonRegistrarse.TabIndex = 3;
            this.BotonRegistrarse.TabStop = true;
            this.BotonRegistrarse.Text = "Registrarse";
            this.BotonRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonRegistrarse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonLogin);
            this.Controls.Add(this.InputContrasena);
            this.Controls.Add(this.InputUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputUsuario;
        private System.Windows.Forms.Button BotonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputContrasena;
        private System.Windows.Forms.LinkLabel BotonRegistrarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}