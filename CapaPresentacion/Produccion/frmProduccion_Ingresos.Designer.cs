﻿namespace CapaPresentacion
{
    partial class frmProduccion_Ingresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DGDetalles = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.TBIdproveedor = new System.Windows.Forms.TextBox();
            this.btnExaminar_Proveedor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBComprobante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBComprobante = new System.Windows.Forms.TextBox();
            this.TBIdbodega = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExaminar_Bodega = new System.Windows.Forms.Button();
            this.DTFechaDeIngreso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBodega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalles)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 513);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Academico - Ingreso de Productos a Bodega";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::CapaPresentacion.Properties.Resources.BV_Agregar;
            this.btnAgregar.Location = new System.Drawing.Point(724, 481);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 26);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBuscar_MouseDown);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnAgregar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuscar_MouseMove);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(642, 481);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseDown);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(88, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.BV_Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(6, 481);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 26);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseDown);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseMove);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DGDetalles);
            this.groupBox4.Location = new System.Drawing.Point(6, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(794, 341);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Ingreso";
            // 
            // DGDetalles
            // 
            this.DGDetalles.AllowUserToAddRows = false;
            this.DGDetalles.AllowUserToDeleteRows = false;
            this.DGDetalles.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Unidad,
            this.Cantidades,
            this.Costo,
            this.Valor});
            this.DGDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGDetalles.Location = new System.Drawing.Point(6, 20);
            this.DGDetalles.Name = "DGDetalles";
            this.DGDetalles.RowHeadersVisible = false;
            this.DGDetalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGDetalles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDetalles.Size = new System.Drawing.Size(782, 315);
            this.DGDetalles.TabIndex = 0;
            this.DGDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalles_CellEndEdit);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBProveedor);
            this.groupBox3.Controls.Add(this.TBIdproveedor);
            this.groupBox3.Controls.Add(this.btnExaminar_Proveedor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CBComprobante);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TBComprobante);
            this.groupBox3.Controls.Add(this.TBIdbodega);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnExaminar_Bodega);
            this.groupBox3.Controls.Add(this.DTFechaDeIngreso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TBBodega);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 106);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Basicos de Ingreso";
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(71, 49);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(283, 21);
            this.TBProveedor.TabIndex = 29;
            // 
            // TBIdproveedor
            // 
            this.TBIdproveedor.Location = new System.Drawing.Point(385, 49);
            this.TBIdproveedor.Name = "TBIdproveedor";
            this.TBIdproveedor.Size = new System.Drawing.Size(90, 21);
            this.TBIdproveedor.TabIndex = 28;
            this.TBIdproveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExaminar_Proveedor
            // 
            this.btnExaminar_Proveedor.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Proveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Proveedor.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Proveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Proveedor.Location = new System.Drawing.Point(481, 49);
            this.btnExaminar_Proveedor.Name = "btnExaminar_Proveedor";
            this.btnExaminar_Proveedor.Size = new System.Drawing.Size(23, 21);
            this.btnExaminar_Proveedor.TabIndex = 27;
            this.btnExaminar_Proveedor.UseVisualStyleBackColor = true;
            this.btnExaminar_Proveedor.Click += new System.EventHandler(this.btnExaminar_Proveedor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "ID";
            // 
            // CBComprobante
            // 
            this.CBComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBComprobante.FormattingEnabled = true;
            this.CBComprobante.Items.AddRange(new object[] {
            "-",
            "Boleta",
            "Cotizacion",
            "Factura",
            "Guia de Ingreso",
            "Guia de Remision",
            "Guia de Traslado",
            "Orden de Compra",
            "Orden de Servicio"});
            this.CBComprobante.Location = new System.Drawing.Point(94, 76);
            this.CBComprobante.Name = "CBComprobante";
            this.CBComprobante.Size = new System.Drawing.Size(118, 23);
            this.CBComprobante.Sorted = true;
            this.CBComprobante.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Comprobante";
            // 
            // TBComprobante
            // 
            this.TBComprobante.Location = new System.Drawing.Point(218, 76);
            this.TBComprobante.Multiline = true;
            this.TBComprobante.Name = "TBComprobante";
            this.TBComprobante.Size = new System.Drawing.Size(136, 23);
            this.TBComprobante.TabIndex = 23;
            this.TBComprobante.Text = "000123456789";
            this.TBComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBIdbodega
            // 
            this.TBIdbodega.Location = new System.Drawing.Point(385, 22);
            this.TBIdbodega.Name = "TBIdbodega";
            this.TBIdbodega.Size = new System.Drawing.Size(90, 21);
            this.TBIdbodega.TabIndex = 22;
            this.TBIdbodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID";
            // 
            // btnExaminar_Bodega
            // 
            this.btnExaminar_Bodega.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Bodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Bodega.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Bodega.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Bodega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Bodega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Bodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Bodega.Location = new System.Drawing.Point(481, 22);
            this.btnExaminar_Bodega.Name = "btnExaminar_Bodega";
            this.btnExaminar_Bodega.Size = new System.Drawing.Size(23, 21);
            this.btnExaminar_Bodega.TabIndex = 20;
            this.btnExaminar_Bodega.UseVisualStyleBackColor = true;
            this.btnExaminar_Bodega.Click += new System.EventHandler(this.btnExaminar_Bodega_Click);
            // 
            // DTFechaDeIngreso
            // 
            this.DTFechaDeIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTFechaDeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaDeIngreso.Location = new System.Drawing.Point(404, 76);
            this.DTFechaDeIngreso.Name = "DTFechaDeIngreso";
            this.DTFechaDeIngreso.Size = new System.Drawing.Size(100, 21);
            this.DTFechaDeIngreso.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega";
            // 
            // TBBodega
            // 
            this.TBBodega.Location = new System.Drawing.Point(71, 22);
            this.TBBodega.Name = "TBBodega";
            this.TBBodega.Size = new System.Drawing.Size(283, 21);
            this.TBBodega.TabIndex = 1;
            this.TBBodega.Text = "CENTRAL DE INVERSIONES DONATO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(522, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 106);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Gastos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Codigo ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Ingresado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Articulos en Lista";
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 370;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unidad.Width = 60;
            // 
            // Cantidades
            // 
            this.Cantidades.HeaderText = "Cant.";
            this.Cantidades.Name = "Cantidades";
            this.Cantidades.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cantidades.Width = 60;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Costo.Width = 85;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Total";
            this.Valor.Name = "Valor";
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Valor.Width = 85;
            // 
            // frmProduccion_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 537);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmProduccion_Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion - Ingreso de Bodega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduccion_Bodegas_Ingreso_FormClosing);
            this.Load += new System.EventHandler(this.frmProduccion_Ingresos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduccion_Ingresos_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExaminar_Proveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBComprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBComprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExaminar_Bodega;
        private System.Windows.Forms.DateTimePicker DTFechaDeIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBIdbodega;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.TextBox TBIdproveedor;
        public System.Windows.Forms.DataGridView DGDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}