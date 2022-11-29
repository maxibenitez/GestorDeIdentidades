namespace GestorDeIdentidades.Interfaz
{
    partial class UserMenu
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
            this.botonPermisos = new System.Windows.Forms.Button();
            this.botonAplicativos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.botonCambiarContra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonPermisos
            // 
            this.botonPermisos.Location = new System.Drawing.Point(124, 111);
            this.botonPermisos.Name = "botonPermisos";
            this.botonPermisos.Size = new System.Drawing.Size(221, 23);
            this.botonPermisos.TabIndex = 14;
            this.botonPermisos.Text = "Solicitar permisos";
            this.botonPermisos.UseVisualStyleBackColor = true;
            this.botonPermisos.Click += new System.EventHandler(this.botonPermisos_Click);
            // 
            // botonAplicativos
            // 
            this.botonAplicativos.Location = new System.Drawing.Point(124, 75);
            this.botonAplicativos.Name = "botonAplicativos";
            this.botonAplicativos.Size = new System.Drawing.Size(221, 23);
            this.botonAplicativos.TabIndex = 13;
            this.botonAplicativos.Text = "Aplicativos";
            this.botonAplicativos.UseVisualStyleBackColor = true;
            this.botonAplicativos.Click += new System.EventHandler(this.botonAplicativos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Menu de usuario";
            // 
            // botonCambiarContra
            // 
            this.botonCambiarContra.Location = new System.Drawing.Point(124, 150);
            this.botonCambiarContra.Name = "botonCambiarContra";
            this.botonCambiarContra.Size = new System.Drawing.Size(221, 23);
            this.botonCambiarContra.TabIndex = 14;
            this.botonCambiarContra.Text = "Cambiar contraseña";
            this.botonCambiarContra.UseVisualStyleBackColor = true;
            this.botonCambiarContra.Click += new System.EventHandler(this.botonCambiarContra_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 210);
            this.Controls.Add(this.botonCambiarContra);
            this.Controls.Add(this.botonPermisos);
            this.Controls.Add(this.botonAplicativos);
            this.Controls.Add(this.label5);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonPermisos;
        private System.Windows.Forms.Button botonAplicativos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonCambiarContra;
    }
}