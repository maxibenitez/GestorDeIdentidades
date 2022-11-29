namespace GestorDeIdentidades.Interfaz
{
    partial class GestorAplicativos
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
            this.label7 = new System.Windows.Forms.Label();
            this.InputRolesAplicativos = new System.Windows.Forms.CheckedListBox();
            this.InputRolesNegocio = new System.Windows.Forms.ComboBox();
            this.InputAplicativos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.actualizarAplicativos = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Gestor de Aplicativos";
            // 
            // InputRolesAplicativos
            // 
            this.InputRolesAplicativos.FormattingEnabled = true;
            this.InputRolesAplicativos.Location = new System.Drawing.Point(117, 141);
            this.InputRolesAplicativos.Name = "InputRolesAplicativos";
            this.InputRolesAplicativos.Size = new System.Drawing.Size(221, 94);
            this.InputRolesAplicativos.TabIndex = 20;
            // 
            // InputRolesNegocio
            // 
            this.InputRolesNegocio.FormattingEnabled = true;
            this.InputRolesNegocio.Location = new System.Drawing.Point(117, 71);
            this.InputRolesNegocio.Name = "InputRolesNegocio";
            this.InputRolesNegocio.Size = new System.Drawing.Size(221, 21);
            this.InputRolesNegocio.TabIndex = 46;
            // 
            // InputAplicativos
            // 
            this.InputAplicativos.FormattingEnabled = true;
            this.InputAplicativos.Location = new System.Drawing.Point(117, 106);
            this.InputAplicativos.Name = "InputAplicativos";
            this.InputAplicativos.Size = new System.Drawing.Size(221, 21);
            this.InputAplicativos.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Rol de negocio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Aplicativo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Roles aplicativo:";
            // 
            // actualizarAplicativos
            // 
            this.actualizarAplicativos.Location = new System.Drawing.Point(117, 257);
            this.actualizarAplicativos.Name = "actualizarAplicativos";
            this.actualizarAplicativos.Size = new System.Drawing.Size(221, 23);
            this.actualizarAplicativos.TabIndex = 52;
            this.actualizarAplicativos.Text = "Confirmar cambios";
            this.actualizarAplicativos.UseVisualStyleBackColor = true;
            this.actualizarAplicativos.Click += new System.EventHandler(this.actualizarAplicativos_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(117, 294);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(221, 23);
            this.botonVolver.TabIndex = 52;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // GestorAplicativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 334);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.actualizarAplicativos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.InputAplicativos);
            this.Controls.Add(this.InputRolesNegocio);
            this.Controls.Add(this.InputRolesAplicativos);
            this.Controls.Add(this.label7);
            this.Name = "GestorAplicativos";
            this.Text = "GestorAplicativos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox InputRolesAplicativos;
        private System.Windows.Forms.ComboBox InputRolesNegocio;
        private System.Windows.Forms.ComboBox InputAplicativos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actualizarAplicativos;
        private System.Windows.Forms.Button botonVolver;
    }
}