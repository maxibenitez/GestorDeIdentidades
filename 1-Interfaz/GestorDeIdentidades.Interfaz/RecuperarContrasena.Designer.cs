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
            this.comboPreguntas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.respuestaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contraInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.usuarioInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInput)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(187, 114);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 0;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // comboPreguntas
            // 
            this.comboPreguntas.FormattingEnabled = true;
            this.comboPreguntas.Location = new System.Drawing.Point(89, 75);
            this.comboPreguntas.Name = "comboPreguntas";
            this.comboPreguntas.Size = new System.Drawing.Size(121, 21);
            this.comboPreguntas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // respuestaInput
            // 
            this.respuestaInput.Location = new System.Drawing.Point(295, 75);
            this.respuestaInput.Name = "respuestaInput";
            this.respuestaInput.Size = new System.Drawing.Size(100, 20);
            this.respuestaInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pregunta\r\nde seguridad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Respuesta:";
            // 
            // contraInput
            // 
            this.contraInput.Location = new System.Drawing.Point(144, 151);
            this.contraInput.Name = "contraInput";
            this.contraInput.Size = new System.Drawing.Size(126, 20);
            this.contraInput.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Location = new System.Drawing.Point(276, 149);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(145, 23);
            this.buttonCambiar.TabIndex = 4;
            this.buttonCambiar.Text = "Cambiar Contraseña";
            this.buttonCambiar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Recuperar Contraseña";
            // 
            // usuarioInput
            // 
            this.usuarioInput.Location = new System.Drawing.Point(183, 49);
            this.usuarioInput.Name = "usuarioInput";
            this.usuarioInput.Size = new System.Drawing.Size(120, 20);
            this.usuarioInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // RecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 197);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usuarioInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCambiar);
            this.Controls.Add(this.contraInput);
            this.Controls.Add(this.respuestaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPreguntas);
            this.Controls.Add(this.buttonConfirmar);
            this.Name = "RecuperarContrasena";
            this.Text = "Recuperar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.ComboBox comboPreguntas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox respuestaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown usuarioInput;
        private System.Windows.Forms.Label label6;
    }
}