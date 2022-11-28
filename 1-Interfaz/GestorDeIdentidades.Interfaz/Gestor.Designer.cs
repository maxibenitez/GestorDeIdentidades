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
            // 
            // bPermisos
            // 
            this.bPermisos.Location = new System.Drawing.Point(117, 102);
            this.bPermisos.Name = "bPermisos";
            this.bPermisos.Size = new System.Drawing.Size(221, 23);
            this.bPermisos.TabIndex = 11;
            this.bPermisos.Text = "Gestión de Permisos";
            this.bPermisos.UseVisualStyleBackColor = true;
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 153);
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
    }
}