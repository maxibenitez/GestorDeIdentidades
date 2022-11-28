namespace GestorDeIdentidades.Interfaz
{
    partial class RecuperarContrasena
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
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.InputPregunta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.respuestaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.usuarioInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(126, 172);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(221, 23);
            this.buttonConfirmar.TabIndex = 0;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // InputPregunta
            // 
            this.InputPregunta.FormattingEnabled = true;
            this.InputPregunta.Location = new System.Drawing.Point(126, 92);
            this.InputPregunta.Name = "InputPregunta";
            this.InputPregunta.Size = new System.Drawing.Size(221, 21);
            this.InputPregunta.TabIndex = 1;
            //this.InputPregunta.SelectedIndexChanged += new System.EventHandler(this.comboPreguntas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // respuestaInput
            // 
            this.respuestaInput.Location = new System.Drawing.Point(126, 128);
            this.respuestaInput.Name = "respuestaInput";
            this.respuestaInput.Size = new System.Drawing.Size(221, 20);
            this.respuestaInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pregunta\r\nde seguridad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Respuesta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Recuperar Contraseña";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(171, 209);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 13);
            this.errorMessage.TabIndex = 7;
            // 
            // usuarioInput
            // 
            this.usuarioInput.Location = new System.Drawing.Point(126, 58);
            this.usuarioInput.Name = "usuarioInput";
            this.usuarioInput.Size = new System.Drawing.Size(221, 20);
            this.usuarioInput.TabIndex = 8;
            // 
            // RecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 237);
            this.Controls.Add(this.usuarioInput);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.respuestaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputPregunta);
            this.Controls.Add(this.buttonConfirmar);
            this.Name = "RecuperarContrasena";
            this.Text = "Recuperar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.ComboBox InputPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox respuestaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.TextBox usuarioInput;
    }
}