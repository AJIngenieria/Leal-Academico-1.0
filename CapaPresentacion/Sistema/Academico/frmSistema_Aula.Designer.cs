namespace CapaPresentacion
{
    partial class frmSistemaAcademico_Aula
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
            this.CBCurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBCapacidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBAuto = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAño = new System.Windows.Forms.TextBox();
            this.TBAula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CBCurso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TBCapacidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBAuto);
            this.groupBox1.Controls.Add(this.CBEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBAño);
            this.groupBox1.Controls.Add(this.TBAula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A&&J Academico - Registro de Cursos de Academicos";
            // 
            // CBCurso
            // 
            this.CBCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurso.FormattingEnabled = true;
            this.CBCurso.Location = new System.Drawing.Point(222, 80);
            this.CBCurso.Name = "CBCurso";
            this.CBCurso.Size = new System.Drawing.Size(111, 23);
            this.CBCurso.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Curso";
            // 
            // TBCapacidad
            // 
            this.TBCapacidad.Location = new System.Drawing.Point(82, 80);
            this.TBCapacidad.Name = "TBCapacidad";
            this.TBCapacidad.Size = new System.Drawing.Size(86, 23);
            this.TBCapacidad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Capacidad";
            // 
            // TBAuto
            // 
            this.TBAuto.Location = new System.Drawing.Point(116, 109);
            this.TBAuto.Name = "TBAuto";
            this.TBAuto.Size = new System.Drawing.Size(52, 23);
            this.TBAuto.TabIndex = 10;
            this.TBAuto.Text = "0";
            // 
            // CBEstado
            // 
            this.CBEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.CBEstado.Location = new System.Drawing.Point(222, 51);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(111, 23);
            this.CBEstado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // TBAño
            // 
            this.TBAño.Location = new System.Drawing.Point(82, 51);
            this.TBAño.Name = "TBAño";
            this.TBAño.Size = new System.Drawing.Size(86, 23);
            this.TBAño.TabIndex = 5;
            this.TBAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBAula
            // 
            this.TBAula.Location = new System.Drawing.Point(82, 22);
            this.TBAula.Name = "TBAula";
            this.TBAula.Size = new System.Drawing.Size(251, 23);
            this.TBAula.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año Electivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(258, 109);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.BV_Nuevo;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(9, 109);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseDown);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseMove);
            // 
            // frmSistemaAcademico_Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 168);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmSistemaAcademico_Aula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema - Aula";
            this.Load += new System.EventHandler(this.frmSistemaAcademico_Aula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBAuto;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBAño;
        private System.Windows.Forms.TextBox TBAula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox TBCapacidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBCurso;
    }
}