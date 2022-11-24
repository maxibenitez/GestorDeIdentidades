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
            this.bAplicativos = new System.Windows.Forms.Button();
            this.bPermisos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAplicativos
            // 
            this.bAplicativos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAplicativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bAplicativos.Location = new System.Drawing.Point(130, 198);
            this.bAplicativos.Name = "bAplicativos";
            this.bAplicativos.Size = new System.Drawing.Size(217, 42);
            this.bAplicativos.TabIndex = 0;
            this.bAplicativos.Text = "Gestión de Aplicativos";
            this.bAplicativos.UseVisualStyleBackColor = true;
            // 
            // bPermisos
            // 
            this.bPermisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bPermisos.Location = new System.Drawing.Point(421, 198);
            this.bPermisos.Name = "bPermisos";
            this.bPermisos.Size = new System.Drawing.Size(217, 42);
            this.bPermisos.TabIndex = 1;
            this.bPermisos.Text = "Gestión de Permisos";
            this.bPermisos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(263, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicación de Gestión";
            // 
            // Gestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPermisos);
            this.Controls.Add(this.bAplicativos);
            this.Name = "Gestor";
            this.Text = "Gestor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAplicativos;
        private System.Windows.Forms.Button bPermisos;
        private System.Windows.Forms.Label label1;
    }
}