namespace GestorDeIdentidades.Interfaz
{
    partial class EditarPermiso
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
            this.label1 = new System.Windows.Forms.Label();
            this.actualizarPermiso = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.aplicativo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rolNegocio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.estados = new System.Windows.Forms.ComboBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Editar Permiso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Persona:";
            // 
            // actualizarPermiso
            // 
            this.actualizarPermiso.Location = new System.Drawing.Point(125, 243);
            this.actualizarPermiso.Name = "actualizarPermiso";
            this.actualizarPermiso.Size = new System.Drawing.Size(221, 23);
            this.actualizarPermiso.TabIndex = 32;
            this.actualizarPermiso.Text = "Confirmar cambios";
            this.actualizarPermiso.UseVisualStyleBackColor = true;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nombre.Location = new System.Drawing.Point(128, 65);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(0, 15);
            this.nombre.TabIndex = 33;
            // 
            // aplicativo
            // 
            this.aplicativo.AutoSize = true;
            this.aplicativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aplicativo.Location = new System.Drawing.Point(128, 99);
            this.aplicativo.Name = "aplicativo";
            this.aplicativo.Size = new System.Drawing.Size(0, 15);
            this.aplicativo.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Aplicativo:";
            // 
            // rolNegocio
            // 
            this.rolNegocio.AutoSize = true;
            this.rolNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rolNegocio.Location = new System.Drawing.Point(128, 132);
            this.rolNegocio.Name = "rolNegocio";
            this.rolNegocio.Size = new System.Drawing.Size(0, 15);
            this.rolNegocio.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Rol de negocio:";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fecha.Location = new System.Drawing.Point(128, 167);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 15);
            this.fecha.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Fecha de solicitud:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Estado:";
            // 
            // estados
            // 
            this.estados.FormattingEnabled = true;
            this.estados.Location = new System.Drawing.Point(125, 199);
            this.estados.Name = "estados";
            this.estados.Size = new System.Drawing.Size(221, 21);
            this.estados.TabIndex = 45;
            this.estados.SelectedIndexChanged += new System.EventHandler(this.estados_SelectedIndexChanged);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(173, 282);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 46;
            // 
            // EditarPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 312);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.estados);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rolNegocio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.aplicativo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.actualizarPermiso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "EditarPermiso";
            this.Text = "EditarPermiso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actualizarPermiso;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label aplicativo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label rolNegocio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox estados;
        private System.Windows.Forms.Label errorMessage;
    }
}