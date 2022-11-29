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
            this.tablaPermisos = new System.Windows.Forms.DataGridView();
            this.bTodos = new System.Windows.Forms.Button();
            this.bActivos = new System.Windows.Forms.Button();
            this.bDenegados = new System.Windows.Forms.Button();
            this.bPendientes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPermisos
            // 
            this.tablaPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tablaPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPermisos.Location = new System.Drawing.Point(12, 113);
            this.tablaPermisos.Name = "tablaPermisos";
            this.tablaPermisos.Size = new System.Drawing.Size(967, 239);
            this.tablaPermisos.TabIndex = 1;
            this.tablaPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPermisos_CellClick);
            // 
            // bTodos
            // 
            this.bTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bTodos.Location = new System.Drawing.Point(252, 68);
            this.bTodos.Name = "bTodos";
            this.bTodos.Size = new System.Drawing.Size(94, 23);
            this.bTodos.TabIndex = 2;
            this.bTodos.Text = "Todos";
            this.bTodos.UseVisualStyleBackColor = true;
            this.bTodos.Click += new System.EventHandler(this.bTodos_Click);
            // 
            // bActivos
            // 
            this.bActivos.Location = new System.Drawing.Point(376, 68);
            this.bActivos.Name = "bActivos";
            this.bActivos.Size = new System.Drawing.Size(94, 23);
            this.bActivos.TabIndex = 3;
            this.bActivos.Text = "Activos";
            this.bActivos.UseVisualStyleBackColor = true;
            this.bActivos.Click += new System.EventHandler(this.bActivos_Click);
            // 
            // bDenegados
            // 
            this.bDenegados.Location = new System.Drawing.Point(494, 68);
            this.bDenegados.Name = "bDenegados";
            this.bDenegados.Size = new System.Drawing.Size(94, 23);
            this.bDenegados.TabIndex = 4;
            this.bDenegados.Text = "Denegados";
            this.bDenegados.UseVisualStyleBackColor = true;
            this.bDenegados.Click += new System.EventHandler(this.bDenegados_Click);
            // 
            // bPendientes
            // 
            this.bPendientes.Location = new System.Drawing.Point(612, 68);
            this.bPendientes.Name = "bPendientes";
            this.bPendientes.Size = new System.Drawing.Size(94, 23);
            this.bPendientes.TabIndex = 5;
            this.bPendientes.Text = "Pendientes";
            this.bPendientes.UseVisualStyleBackColor = true;
            this.bPendientes.Click += new System.EventHandler(this.bPendientes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gestor de Permisos";
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(376, 366);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(199, 23);
            this.botonVolver.TabIndex = 19;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // GestorPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 401);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bPendientes);
            this.Controls.Add(this.bDenegados);
            this.Controls.Add(this.bActivos);
            this.Controls.Add(this.bTodos);
            this.Controls.Add(this.tablaPermisos);
            this.Name = "GestorPermisos";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaPermisos;
        private System.Windows.Forms.Button bTodos;
        private System.Windows.Forms.Button bActivos;
        private System.Windows.Forms.Button bDenegados;
        private System.Windows.Forms.Button bPendientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botonVolver;
    }
}