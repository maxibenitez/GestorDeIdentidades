namespace GestorDeIdentidades.Interfaz
{
    partial class NuevaContrasena
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
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.contraInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nueva Contraseña";
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Location = new System.Drawing.Point(127, 110);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(221, 23);
            this.buttonCambiar.TabIndex = 9;
            this.buttonCambiar.Text = "Cambiar Contraseña";
            this.buttonCambiar.UseVisualStyleBackColor = true;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // contraInput
            // 
            this.contraInput.Location = new System.Drawing.Point(127, 65);
            this.contraInput.Name = "contraInput";
            this.contraInput.Size = new System.Drawing.Size(221, 20);
            this.contraInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nueva contraseña:";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(124, 147);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 10;
            // 
            // NuevaContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 178);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.buttonCambiar);
            this.Controls.Add(this.contraInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "NuevaContrasena";
            this.Text = "NuevaContrasena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.TextBox contraInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorMessage;
    }
}