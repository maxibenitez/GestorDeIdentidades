namespace GestorDeIdentidades.Interfaz
{
    partial class GestorPermisos
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
            this.label1 = new System.Windows.Forms.Label();
            this.tablaPermisos = new System.Windows.Forms.DataGridView();
            this.bTodos = new System.Windows.Forms.Button();
            this.bActivos = new System.Windows.Forms.Button();
            this.bDenegados = new System.Windows.Forms.Button();
            this.bPendientes = new System.Windows.Forms.Button();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestor de Permisos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tablaPermisos
            // 
            this.tablaPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPermisos.Location = new System.Drawing.Point(40, 138);
            this.tablaPermisos.Name = "tablaPermisos";
            this.tablaPermisos.Size = new System.Drawing.Size(426, 239);
            this.tablaPermisos.TabIndex = 1;
            // 
            // bTodos
            // 
            this.bTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTodos.Location = new System.Drawing.Point(40, 84);
            this.bTodos.Name = "bTodos";
            this.bTodos.Size = new System.Drawing.Size(94, 23);
            this.bTodos.TabIndex = 2;
            this.bTodos.Text = "Todos";
            this.bTodos.UseVisualStyleBackColor = true;
            this.bTodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bActivos
            // 
            this.bActivos.Location = new System.Drawing.Point(150, 84);
            this.bActivos.Name = "bActivos";
            this.bActivos.Size = new System.Drawing.Size(94, 23);
            this.bActivos.TabIndex = 3;
            this.bActivos.Text = "Activos";
            this.bActivos.UseVisualStyleBackColor = true;
            this.bActivos.Click += new System.EventHandler(this.button2_Click);
            // 
            // bDenegados
            // 
            this.bDenegados.Location = new System.Drawing.Point(260, 84);
            this.bDenegados.Name = "bDenegados";
            this.bDenegados.Size = new System.Drawing.Size(94, 23);
            this.bDenegados.TabIndex = 4;
            this.bDenegados.Text = "Denegados";
            this.bDenegados.UseVisualStyleBackColor = true;
            // 
            // bPendientes
            // 
            this.bPendientes.Location = new System.Drawing.Point(372, 84);
            this.bPendientes.Name = "bPendientes";
            this.bPendientes.Size = new System.Drawing.Size(94, 23);
            this.bPendientes.TabIndex = 5;
            this.bPendientes.Text = "Pendientes";
            this.bPendientes.UseVisualStyleBackColor = true;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(483, 314);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(283, 31);
            this.bConfirmar.TabIndex = 6;
            this.bConfirmar.Text = "Confirmar cambios";
            this.bConfirmar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(480, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(480, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aplicativo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(480, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rol de negocio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(480, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Persona:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(605, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(605, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(605, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(605, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(605, 242);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(480, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha de solicitud:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // GestorPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.bPendientes);
            this.Controls.Add(this.bDenegados);
            this.Controls.Add(this.bActivos);
            this.Controls.Add(this.bTodos);
            this.Controls.Add(this.tablaPermisos);
            this.Controls.Add(this.label1);
            this.Name = "GestorPermisos";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaPermisos;
        private System.Windows.Forms.Button bTodos;
        private System.Windows.Forms.Button bActivos;
        private System.Windows.Forms.Button bDenegados;
        private System.Windows.Forms.Button bPendientes;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
    }
}