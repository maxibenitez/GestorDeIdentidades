namespace GestorDeIdentidades.Interfaz
{
    partial class Dummy
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
            this.label9 = new System.Windows.Forms.Label();
            this.InputAplicativos = new System.Windows.Forms.ComboBox();
            this.listaMenu = new System.Windows.Forms.ListBox();
            this.botonVolver = new System.Windows.Forms.Button();
            this.permisoMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Aplicación Dummy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Manú:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Aplicativo:";
            // 
            // InputAplicativos
            // 
            this.InputAplicativos.FormattingEnabled = true;
            this.InputAplicativos.Location = new System.Drawing.Point(115, 67);
            this.InputAplicativos.Name = "InputAplicativos";
            this.InputAplicativos.Size = new System.Drawing.Size(221, 21);
            this.InputAplicativos.TabIndex = 53;
            this.InputAplicativos.SelectedIndexChanged += new System.EventHandler(this.InputAplicativos_SelectedIndexChanged);
            // 
            // listaMenu
            // 
            this.listaMenu.FormattingEnabled = true;
            this.listaMenu.Location = new System.Drawing.Point(115, 102);
            this.listaMenu.Name = "listaMenu";
            this.listaMenu.Size = new System.Drawing.Size(221, 95);
            this.listaMenu.TabIndex = 56;
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(115, 209);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(221, 23);
            this.botonVolver.TabIndex = 57;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // permisoMessage
            // 
            this.permisoMessage.AutoSize = true;
            this.permisoMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.permisoMessage.Location = new System.Drawing.Point(81, 124);
            this.permisoMessage.Name = "permisoMessage";
            this.permisoMessage.Size = new System.Drawing.Size(272, 17);
            this.permisoMessage.TabIndex = 58;
            this.permisoMessage.Text = "Usted no tiene ningún permiso disponible!";
            // 
            // Dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 249);
            this.Controls.Add(this.permisoMessage);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.listaMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InputAplicativos);
            this.Controls.Add(this.label7);
            this.Name = "Dummy";
            this.Text = "Dummy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox InputAplicativos;
        private System.Windows.Forms.ListBox listaMenu;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label permisoMessage;
    }
}