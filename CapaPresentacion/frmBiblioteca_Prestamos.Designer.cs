namespace CapaPresentacion
{
    partial class frmBiblioteca_Prestamos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IDSolicitante = new System.Windows.Forms.TextBox();
            this.IDArticulo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnExaminar_Articulo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DVDetalles = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBDocumento = new System.Windows.Forms.TextBox();
            this.btnExaminar_Solicitante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DTFechadedevolucion = new System.Windows.Forms.DateTimePicker();
            this.TBSolicitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTFechadeprestamo_Alumnos = new System.Windows.Forms.DateTimePicker();
            this.TBIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVDetalles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AJ Academico - Prestamos de Libros y Equipos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IDSolicitante);
            this.groupBox3.Controls.Add(this.IDArticulo);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnExaminar_Articulo);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.TBArticulo);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.DVDetalles);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(672, 365);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de la Solicitud";
            // 
            // IDSolicitante
            // 
            this.IDSolicitante.Location = new System.Drawing.Point(483, 22);
            this.IDSolicitante.Name = "IDSolicitante";
            this.IDSolicitante.Size = new System.Drawing.Size(65, 23);
            this.IDSolicitante.TabIndex = 24;
            // 
            // IDArticulo
            // 
            this.IDArticulo.Location = new System.Drawing.Point(412, 22);
            this.IDArticulo.Name = "IDArticulo";
            this.IDArticulo.Size = new System.Drawing.Size(65, 23);
            this.IDArticulo.TabIndex = 23;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::CapaPresentacion.Properties.Resources.BV_Nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(6, 334);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Alumnos_Click);
            // 
            // btnExaminar_Articulo
            // 
            this.btnExaminar_Articulo.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Articulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Articulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Articulo.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Articulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Articulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Articulo.Location = new System.Drawing.Point(302, 22);
            this.btnExaminar_Articulo.Name = "btnExaminar_Articulo";
            this.btnExaminar_Articulo.Size = new System.Drawing.Size(21, 23);
            this.btnExaminar_Articulo.TabIndex = 10;
            this.btnExaminar_Articulo.UseVisualStyleBackColor = true;
            this.btnExaminar_Articulo.Click += new System.EventHandler(this.btnExaminar_Articulo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.BV_Agregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(591, 334);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 25);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TBArticulo
            // 
            this.TBArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBArticulo.Location = new System.Drawing.Point(73, 22);
            this.TBArticulo.Name = "TBArticulo";
            this.TBArticulo.Size = new System.Drawing.Size(223, 23);
            this.TBArticulo.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(510, 334);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Articulo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(87, 334);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DVDetalles
            // 
            this.DVDetalles.AllowUserToAddRows = false;
            this.DVDetalles.AllowUserToDeleteRows = false;
            this.DVDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DVDetalles.BackgroundColor = System.Drawing.Color.White;
            this.DVDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DVDetalles.Location = new System.Drawing.Point(6, 51);
            this.DVDetalles.Name = "DVDetalles";
            this.DVDetalles.ReadOnly = true;
            this.DVDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVDetalles.Size = new System.Drawing.Size(657, 277);
            this.DVDetalles.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBDocumento);
            this.groupBox2.Controls.Add(this.btnExaminar_Solicitante);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DTFechadedevolucion);
            this.groupBox2.Controls.Add(this.TBSolicitante);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DTFechadeprestamo_Alumnos);
            this.groupBox2.Controls.Add(this.TBIdentificacion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 84);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Basicos - Solicitud";
            // 
            // TBDocumento
            // 
            this.TBDocumento.Location = new System.Drawing.Point(412, 22);
            this.TBDocumento.Name = "TBDocumento";
            this.TBDocumento.Size = new System.Drawing.Size(65, 23);
            this.TBDocumento.TabIndex = 9;
            this.TBDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExaminar_Solicitante
            // 
            this.btnExaminar_Solicitante.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Solicitante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Solicitante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Solicitante.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Solicitante.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Solicitante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Solicitante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Solicitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Solicitante.Location = new System.Drawing.Point(302, 22);
            this.btnExaminar_Solicitante.Name = "btnExaminar_Solicitante";
            this.btnExaminar_Solicitante.Size = new System.Drawing.Size(21, 23);
            this.btnExaminar_Solicitante.TabIndex = 0;
            this.btnExaminar_Solicitante.UseVisualStyleBackColor = true;
            this.btnExaminar_Solicitante.Click += new System.EventHandler(this.btnExaminar_Solicitante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitante";
            // 
            // DTFechadedevolucion
            // 
            this.DTFechadedevolucion.Location = new System.Drawing.Point(412, 51);
            this.DTFechadedevolucion.Name = "DTFechadedevolucion";
            this.DTFechadedevolucion.Size = new System.Drawing.Size(250, 23);
            this.DTFechadedevolucion.TabIndex = 8;
            // 
            // TBSolicitante
            // 
            this.TBSolicitante.Location = new System.Drawing.Point(73, 22);
            this.TBSolicitante.Name = "TBSolicitante";
            this.TBSolicitante.Size = new System.Drawing.Size(223, 23);
            this.TBSolicitante.TabIndex = 1;
            this.TBSolicitante.Text = "ALEXANDER JAVIER GUERRERO CUELLO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "F. Devolucion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion";
            // 
            // DTFechadeprestamo_Alumnos
            // 
            this.DTFechadeprestamo_Alumnos.Location = new System.Drawing.Point(73, 51);
            this.DTFechadeprestamo_Alumnos.Name = "DTFechadeprestamo_Alumnos";
            this.DTFechadeprestamo_Alumnos.Size = new System.Drawing.Size(250, 23);
            this.DTFechadeprestamo_Alumnos.TabIndex = 6;
            // 
            // TBIdentificacion
            // 
            this.TBIdentificacion.Location = new System.Drawing.Point(483, 22);
            this.TBIdentificacion.Name = "TBIdentificacion";
            this.TBIdentificacion.Size = new System.Drawing.Size(179, 23);
            this.TBIdentificacion.TabIndex = 3;
            this.TBIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "F. Prestamo";
            // 
            // frmBiblioteca_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 504);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBiblioteca_Prestamos";
            this.Text = "Biblioteca  - Prestamos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBiblioteca_Prestamos_FormClosing);
            this.Load += new System.EventHandler(this.frmBiblioteca_Prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DVDetalles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBDocumento;
        private System.Windows.Forms.Button btnExaminar_Solicitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTFechadedevolucion;
        private System.Windows.Forms.TextBox TBSolicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTFechadeprestamo_Alumnos;
        private System.Windows.Forms.TextBox TBIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExaminar_Articulo;
        private System.Windows.Forms.TextBox TBArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DVDetalles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDArticulo;
        private System.Windows.Forms.TextBox IDSolicitante;
    }
}