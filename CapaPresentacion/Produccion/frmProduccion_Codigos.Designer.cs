﻿namespace CapaPresentacion
{
    partial class frmProduccion_Codigos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBIdproducto = new System.Windows.Forms.TextBox();
            this.TBReferencia = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.TBCodigoDeBarra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.CHEliminar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGResultado = new System.Windows.Forms.DataGridView();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBIdproducto);
            this.groupBox3.Controls.Add(this.TBReferencia);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.TBCodigoDeBarra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TBMarca);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TBProducto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 241);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // TBIdproducto
            // 
            this.TBIdproducto.Location = new System.Drawing.Point(9, 131);
            this.TBIdproducto.Name = "TBIdproducto";
            this.TBIdproducto.Size = new System.Drawing.Size(64, 21);
            this.TBIdproducto.TabIndex = 21;
            // 
            // TBReferencia
            // 
            this.TBReferencia.Location = new System.Drawing.Point(89, 74);
            this.TBReferencia.Name = "TBReferencia";
            this.TBReferencia.Size = new System.Drawing.Size(250, 21);
            this.TBReferencia.TabIndex = 18;
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
            this.btnEliminar.Location = new System.Drawing.Point(263, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 20;
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
            this.btnGuardar.Location = new System.Drawing.Point(88, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.BV_Editar;
            this.btnEditar.Location = new System.Drawing.Point(181, 209);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 26);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEditar_MouseDown);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            this.btnEditar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEditar_MouseMove);
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
            this.btnNuevo.Location = new System.Drawing.Point(6, 209);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 26);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseDown);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseMove);
            // 
            // TBCodigoDeBarra
            // 
            this.TBCodigoDeBarra.Location = new System.Drawing.Point(101, 101);
            this.TBCodigoDeBarra.Multiline = true;
            this.TBCodigoDeBarra.Name = "TBCodigoDeBarra";
            this.TBCodigoDeBarra.Size = new System.Drawing.Size(238, 103);
            this.TBCodigoDeBarra.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Codigo de Barra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Marca";
            // 
            // TBMarca
            // 
            this.TBMarca.Location = new System.Drawing.Point(89, 47);
            this.TBMarca.Name = "TBMarca";
            this.TBMarca.Size = new System.Drawing.Size(250, 21);
            this.TBMarca.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Referencia";
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(89, 20);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(250, 21);
            this.TBProducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.CHEliminar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DGResultado);
            this.groupBox2.Controls.Add(this.TBBuscar);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 241);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 15);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "---------------";
            // 
            // CHEliminar
            // 
            this.CHEliminar.AutoSize = true;
            this.CHEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CHEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CHEliminar.FlatAppearance.BorderSize = 0;
            this.CHEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CHEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CHEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHEliminar.Location = new System.Drawing.Point(421, 24);
            this.CHEliminar.Name = "CHEliminar";
            this.CHEliminar.Size = new System.Drawing.Size(69, 19);
            this.CHEliminar.TabIndex = 6;
            this.CHEliminar.Text = "Eliminar";
            this.CHEliminar.UseVisualStyleBackColor = true;
            this.CHEliminar.CheckedChanged += new System.EventHandler(this.CHEliminar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Producto a Consultar";
            // 
            // DGResultado
            // 
            this.DGResultado.AllowUserToAddRows = false;
            this.DGResultado.AllowUserToDeleteRows = false;
            this.DGResultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGResultado.BackgroundColor = System.Drawing.Color.White;
            this.DGResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultado.Location = new System.Drawing.Point(6, 64);
            this.DGResultado.Name = "DGResultado";
            this.DGResultado.ReadOnly = true;
            this.DGResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultado.Size = new System.Drawing.Size(484, 171);
            this.DGResultado.TabIndex = 4;
            this.DGResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultado_CellContentClick);
            this.DGResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultado_CellDoubleClick);
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(133, 22);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(250, 21);
            this.TBBuscar.TabIndex = 1;
            this.TBBuscar.Text = "ALEXANDER JAVIER GUERRERO CUELLO";
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // frmProduccion_Codigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 265);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmProduccion_Codigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduccion_CodigosDeBarra";
            this.Load += new System.EventHandler(this.frmProduccion_CodigosDeBarra_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox TBCodigoDeBarra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGResultado;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.TextBox TBReferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CHEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TBIdproducto;
    }
}