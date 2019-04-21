namespace CapaPresentacion
{
    partial class frmAcademico_Asistencia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CBJornada = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.CBCurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Asistencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBJornada);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.DGResultados);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.CBCurso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A&&J Academico - Registro de Asistencias Academicas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(529, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Jornada";
            // 
            // CBJornada
            // 
            this.CBJornada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBJornada.FormattingEnabled = true;
            this.CBJornada.Location = new System.Drawing.Point(339, 22);
            this.CBJornada.Name = "CBJornada";
            this.CBJornada.Size = new System.Drawing.Size(82, 23);
            this.CBJornada.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 48);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(22, 15);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "---";
            // 
            // DGResultados
            // 
            this.DGResultados.AllowUserToAddRows = false;
            this.DGResultados.AllowUserToDeleteRows = false;
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Asistencia});
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 66);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(598, 342);
            this.DGResultados.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.BV_Agregar;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(448, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CBCurso
            // 
            this.CBCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurso.FormattingEnabled = true;
            this.CBCurso.Location = new System.Drawing.Point(196, 22);
            this.CBCurso.Name = "CBCurso";
            this.CBCurso.Size = new System.Drawing.Size(82, 23);
            this.CBCurso.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Curso";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha";
            // 
            // Asistencia
            // 
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            this.Asistencia.Width = 66;
            // 
            // frmAcademico_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 438);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmAcademico_Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academico - Asistencias";
            this.Load += new System.EventHandler(this.frmAcademico_Asistencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBJornada;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewComboBoxColumn Asistencia;
    }
}