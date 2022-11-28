﻿namespace GestorDeIdentidades.Interfaz
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
            this.contrasenaOlvidada = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // InputUsuario
            // 
            this.InputUsuario.Location = new System.Drawing.Point(130, 64);
            this.InputUsuario.Name = "InputUsuario";
            this.InputUsuario.Size = new System.Drawing.Size(221, 20);
            this.InputUsuario.TabIndex = 0;
            // 
            // BotonLogin
            // 
            this.BotonLogin.Location = new System.Drawing.Point(130, 143);
            this.BotonLogin.Name = "BotonLogin";
            this.BotonLogin.Size = new System.Drawing.Size(221, 23);
            this.BotonLogin.TabIndex = 1;
            this.BotonLogin.Text = "Login";
            this.BotonLogin.UseVisualStyleBackColor = true;
            this.BotonLogin.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar al sistema";
            // 
            // InputContrasena
            // 
            this.InputContrasena.Location = new System.Drawing.Point(130, 99);
            this.InputContrasena.Name = "InputContrasena";
            this.InputContrasena.Size = new System.Drawing.Size(221, 20);
            this.InputContrasena.TabIndex = 0;
            // 
            // BotonRegistrarse
            // 
            this.BotonRegistrarse.AutoSize = true;
            this.BotonRegistrarse.Location = new System.Drawing.Point(208, 205);
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
            this.label2.Location = new System.Drawing.Point(78, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña:";
            // 
            // contrasenaOlvidada
            // 
            this.contrasenaOlvidada.AutoSize = true;
            this.contrasenaOlvidada.Location = new System.Drawing.Point(166, 179);
            this.contrasenaOlvidada.Name = "contrasenaOlvidada";
            this.contrasenaOlvidada.Size = new System.Drawing.Size(146, 13);
            this.contrasenaOlvidada.TabIndex = 3;
            this.contrasenaOlvidada.TabStop = true;
            this.contrasenaOlvidada.Text = "¿Ha olvidado su contraseña?";
            this.contrasenaOlvidada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contrasenaOlvidada_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contrasenaOlvidada);
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
        private System.Windows.Forms.LinkLabel contrasenaOlvidada;
    }
}