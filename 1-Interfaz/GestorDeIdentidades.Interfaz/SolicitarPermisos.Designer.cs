namespace GestorDeIdentidades.Interfaz
{
    partial class SolicitarPermisos
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
            this.InputRol = new System.Windows.Forms.ComboBox();
            this.InputAplicativo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.botonSolicitar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.errorCampos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputRol
            // 
            this.InputRol.FormattingEnabled = true;
            this.InputRol.Location = new System.Drawing.Point(127, 105);
            this.InputRol.Name = "InputRol";
            this.InputRol.Size = new System.Drawing.Size(221, 21);
            this.InputRol.TabIndex = 19;
            // 
            // InputAplicativo
            // 
            this.InputAplicativo.FormattingEnabled = true;
            this.InputAplicativo.Location = new System.Drawing.Point(127, 70);
            this.InputAplicativo.Name = "InputAplicativo";
            this.InputAplicativo.Size = new System.Drawing.Size(221, 21);
            this.InputAplicativo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rol de negocio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Aplicativo:";
            // 
            // botonSolicitar
            // 
            this.botonSolicitar.Location = new System.Drawing.Point(127, 158);
            this.botonSolicitar.Name = "botonSolicitar";
            this.botonSolicitar.Size = new System.Drawing.Size(221, 23);
            this.botonSolicitar.TabIndex = 20;
            this.botonSolicitar.Text = "Solicitar";
            this.botonSolicitar.UseVisualStyleBackColor = true;
            this.botonSolicitar.Click += new System.EventHandler(this.botonSolicitar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Solicitar Permisos";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(127, 193);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(221, 23);
            this.botonVolver.TabIndex = 20;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // errorCampos
            // 
            this.errorCampos.AutoSize = true;
            this.errorCampos.ForeColor = System.Drawing.Color.Red;
            this.errorCampos.Location = new System.Drawing.Point(156, 135);
            this.errorCampos.Name = "errorCampos";
            this.errorCampos.Size = new System.Drawing.Size(170, 13);
            this.errorCampos.TabIndex = 57;
            this.errorCampos.Text = "Debe completar todos los campos!";
            // 
            // SolicitarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 238);
            this.Controls.Add(this.errorCampos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonSolicitar);
            this.Controls.Add(this.InputRol);
            this.Controls.Add(this.InputAplicativo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "SolicitarPermisos";
            this.Text = "Solicitar Permisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox InputRol;
        private System.Windows.Forms.ComboBox InputAplicativo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button botonSolicitar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label errorCampos;
    }
}