namespace GestorDeIdentidades.Interfaz
{
    partial class Gestor
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
            this.label5 = new System.Windows.Forms.Label();
            this.bAplicativos = new System.Windows.Forms.Button();
            this.bPermisos = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aplicación de Gestión";
            // 
            // bAplicativos
            // 
            this.bAplicativos.Location = new System.Drawing.Point(117, 66);
            this.bAplicativos.Name = "bAplicativos";
            this.bAplicativos.Size = new System.Drawing.Size(221, 23);
            this.bAplicativos.TabIndex = 10;
            this.bAplicativos.Text = "Gestión de Aplicativos";
            this.bAplicativos.UseVisualStyleBackColor = true;
            this.bAplicativos.Click += new System.EventHandler(this.bAplicativos_Click);
            // 
            // bPermisos
            // 
            this.bPermisos.Location = new System.Drawing.Point(117, 102);
            this.bPermisos.Name = "bPermisos";
            this.bPermisos.Size = new System.Drawing.Size(221, 23);
            this.bPermisos.TabIndex = 11;
            this.bPermisos.Text = "Gestión de Permisos";
            this.bPermisos.UseVisualStyleBackColor = true;
            this.bPermisos.Click += new System.EventHandler(this.bPermisos_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.Transparent;
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.ForeColor = System.Drawing.Color.Black;
            this.botonSalir.Location = new System.Drawing.Point(415, 1);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(47, 23);
            this.botonSalir.TabIndex = 16;
            this.botonSalir.Text = "SALIR";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 153);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.bPermisos);
            this.Controls.Add(this.bAplicativos);
            this.Controls.Add(this.label5);
            this.Name = "Gestor";
            this.Text = "Gestor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAplicativos;
        private System.Windows.Forms.Button bPermisos;
        private System.Windows.Forms.Button botonSalir;
    }
}