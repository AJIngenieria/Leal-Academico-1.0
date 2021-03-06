﻿namespace CapaPresentacion
{
    partial class frmProduccion_Cliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPDatosBasicos = new System.Windows.Forms.TabPage();
            this.DTFechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.TBDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBMovil = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TPDatosDeEnvio = new System.Windows.Forms.TabPage();
            this.TBCodigoPostal = new System.Windows.Forms.TextBox();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.TBPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBDireccion01 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBDireccion02 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TPFinanciera = new System.Windows.Forms.TabPage();
            this.TBNumeroCuenta02 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CBTipoDeCuenta01 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CBTipoDeCuenta02 = new System.Windows.Forms.ComboBox();
            this.CBBancoSecundario = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CBBancoPrincipal = new System.Windows.Forms.ComboBox();
            this.TBNumeroCuenta01 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultado = new System.Windows.Forms.DataGridView();
            this.CHEliminar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TPDatosBasicos.SuspendLayout();
            this.TPDatosDeEnvio.SuspendLayout();
            this.TPFinanciera.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Academico - Registro de Clientes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPDatosBasicos);
            this.tabControl1.Controls.Add(this.TPDatosDeEnvio);
            this.tabControl1.Controls.Add(this.TPFinanciera);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 204);
            this.tabControl1.TabIndex = 14;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.DTFechaDeInicio);
            this.TPDatosBasicos.Controls.Add(this.label14);
            this.TPDatosBasicos.Controls.Add(this.CBTipo);
            this.TPDatosBasicos.Controls.Add(this.label13);
            this.TPDatosBasicos.Controls.Add(this.label2);
            this.TPDatosBasicos.Controls.Add(this.TBCliente);
            this.TPDatosBasicos.Controls.Add(this.TBDocumento);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.label8);
            this.TPDatosBasicos.Controls.Add(this.label9);
            this.TPDatosBasicos.Controls.Add(this.TBEmail);
            this.TPDatosBasicos.Controls.Add(this.label10);
            this.TPDatosBasicos.Controls.Add(this.TBMovil);
            this.TPDatosBasicos.Controls.Add(this.TBTelefono);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(328, 176);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // DTFechaDeInicio
            // 
            this.DTFechaDeInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTFechaDeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaDeInicio.Location = new System.Drawing.Point(222, 6);
            this.DTFechaDeInicio.Name = "DTFechaDeInicio";
            this.DTFechaDeInicio.Size = new System.Drawing.Size(100, 21);
            this.DTFechaDeInicio.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Inicio";
            // 
            // CBTipo
            // 
            this.CBTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Items.AddRange(new object[] {
            "-",
            "Internacional",
            "Juridico",
            "Natural"});
            this.CBTipo.Location = new System.Drawing.Point(72, 6);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(100, 23);
            this.CBTipo.Sorted = true;
            this.CBTipo.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente";
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(72, 35);
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(250, 21);
            this.TBCliente.TabIndex = 1;
            this.TBCliente.Text = "ALEXANDER JAVIER GUERRERO CUELLO";
            // 
            // TBDocumento
            // 
            this.TBDocumento.Location = new System.Drawing.Point(83, 62);
            this.TBDocumento.Name = "TBDocumento";
            this.TBDocumento.Size = new System.Drawing.Size(239, 21);
            this.TBDocumento.TabIndex = 2;
            this.TBDocumento.Text = "9004904686";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Movil";
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(72, 143);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(250, 21);
            this.TBEmail.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email";
            // 
            // TBMovil
            // 
            this.TBMovil.Location = new System.Drawing.Point(72, 116);
            this.TBMovil.Name = "TBMovil";
            this.TBMovil.Size = new System.Drawing.Size(250, 21);
            this.TBMovil.TabIndex = 19;
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(72, 89);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(250, 21);
            this.TBTelefono.TabIndex = 18;
            // 
            // TPDatosDeEnvio
            // 
            this.TPDatosDeEnvio.Controls.Add(this.TBCodigoPostal);
            this.TPDatosDeEnvio.Controls.Add(this.TBCiudad);
            this.TPDatosDeEnvio.Controls.Add(this.TBPais);
            this.TPDatosDeEnvio.Controls.Add(this.label1);
            this.TPDatosDeEnvio.Controls.Add(this.label5);
            this.TPDatosDeEnvio.Controls.Add(this.label12);
            this.TPDatosDeEnvio.Controls.Add(this.label7);
            this.TPDatosDeEnvio.Controls.Add(this.TBDireccion01);
            this.TPDatosDeEnvio.Controls.Add(this.label6);
            this.TPDatosDeEnvio.Controls.Add(this.TBDireccion02);
            this.TPDatosDeEnvio.Controls.Add(this.label11);
            this.TPDatosDeEnvio.Location = new System.Drawing.Point(4, 24);
            this.TPDatosDeEnvio.Name = "TPDatosDeEnvio";
            this.TPDatosDeEnvio.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosDeEnvio.Size = new System.Drawing.Size(328, 176);
            this.TPDatosDeEnvio.TabIndex = 1;
            this.TPDatosDeEnvio.Text = "Datos de Envio";
            this.TPDatosDeEnvio.UseVisualStyleBackColor = true;
            // 
            // TBCodigoPostal
            // 
            this.TBCodigoPostal.Location = new System.Drawing.Point(95, 6);
            this.TBCodigoPostal.Name = "TBCodigoPostal";
            this.TBCodigoPostal.Size = new System.Drawing.Size(227, 21);
            this.TBCodigoPostal.TabIndex = 33;
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(72, 60);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(250, 21);
            this.TBCiudad.TabIndex = 32;
            // 
            // TBPais
            // 
            this.TBPais.Location = new System.Drawing.Point(72, 33);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(250, 21);
            this.TBPais.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Codigo Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "label7";
            // 
            // TBDireccion01
            // 
            this.TBDireccion01.Location = new System.Drawing.Point(72, 87);
            this.TBDireccion01.Name = "TBDireccion01";
            this.TBDireccion01.Size = new System.Drawing.Size(250, 21);
            this.TBDireccion01.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Direccion1";
            // 
            // TBDireccion02
            // 
            this.TBDireccion02.Location = new System.Drawing.Point(72, 114);
            this.TBDireccion02.Name = "TBDireccion02";
            this.TBDireccion02.Size = new System.Drawing.Size(250, 21);
            this.TBDireccion02.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Direccion2";
            // 
            // TPFinanciera
            // 
            this.TPFinanciera.Controls.Add(this.TBNumeroCuenta02);
            this.TPFinanciera.Controls.Add(this.label20);
            this.TPFinanciera.Controls.Add(this.CBTipoDeCuenta01);
            this.TPFinanciera.Controls.Add(this.label17);
            this.TPFinanciera.Controls.Add(this.label19);
            this.TPFinanciera.Controls.Add(this.CBTipoDeCuenta02);
            this.TPFinanciera.Controls.Add(this.CBBancoSecundario);
            this.TPFinanciera.Controls.Add(this.label18);
            this.TPFinanciera.Controls.Add(this.label16);
            this.TPFinanciera.Controls.Add(this.CBBancoPrincipal);
            this.TPFinanciera.Controls.Add(this.TBNumeroCuenta01);
            this.TPFinanciera.Controls.Add(this.label15);
            this.TPFinanciera.Location = new System.Drawing.Point(4, 24);
            this.TPFinanciera.Name = "TPFinanciera";
            this.TPFinanciera.Size = new System.Drawing.Size(328, 176);
            this.TPFinanciera.TabIndex = 2;
            this.TPFinanciera.Text = "Datos Financieros";
            this.TPFinanciera.UseVisualStyleBackColor = true;
            // 
            // TBNumeroCuenta02
            // 
            this.TBNumeroCuenta02.Location = new System.Drawing.Point(89, 149);
            this.TBNumeroCuenta02.Name = "TBNumeroCuenta02";
            this.TBNumeroCuenta02.Size = new System.Drawing.Size(233, 21);
            this.TBNumeroCuenta02.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Nu. de Cuenta";
            // 
            // CBTipoDeCuenta01
            // 
            this.CBTipoDeCuenta01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTipoDeCuenta01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoDeCuenta01.FormattingEnabled = true;
            this.CBTipoDeCuenta01.Items.AddRange(new object[] {
            "-",
            "Ahorro",
            "Corriente",
            "Internacional"});
            this.CBTipoDeCuenta01.Location = new System.Drawing.Point(150, 35);
            this.CBTipoDeCuenta01.Name = "CBTipoDeCuenta01";
            this.CBTipoDeCuenta01.Size = new System.Drawing.Size(172, 23);
            this.CBTipoDeCuenta01.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Tipo de Cuenta Principal";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 15);
            this.label19.TabIndex = 9;
            this.label19.Text = "Nu. de Cuenta";
            // 
            // CBTipoDeCuenta02
            // 
            this.CBTipoDeCuenta02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTipoDeCuenta02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoDeCuenta02.FormattingEnabled = true;
            this.CBTipoDeCuenta02.Items.AddRange(new object[] {
            "-",
            "Ahorro",
            "Corriente",
            "Internacional"});
            this.CBTipoDeCuenta02.Location = new System.Drawing.Point(165, 120);
            this.CBTipoDeCuenta02.Name = "CBTipoDeCuenta02";
            this.CBTipoDeCuenta02.Size = new System.Drawing.Size(157, 23);
            this.CBTipoDeCuenta02.TabIndex = 8;
            // 
            // CBBancoSecundario
            // 
            this.CBBancoSecundario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBancoSecundario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBancoSecundario.FormattingEnabled = true;
            this.CBBancoSecundario.Location = new System.Drawing.Point(89, 91);
            this.CBBancoSecundario.Name = "CBBancoSecundario";
            this.CBBancoSecundario.Size = new System.Drawing.Size(233, 23);
            this.CBBancoSecundario.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Tipo de Cuenta Secundaria";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "Banco Secu.";
            // 
            // CBBancoPrincipal
            // 
            this.CBBancoPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBBancoPrincipal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBancoPrincipal.FormattingEnabled = true;
            this.CBBancoPrincipal.Location = new System.Drawing.Point(89, 6);
            this.CBBancoPrincipal.Name = "CBBancoPrincipal";
            this.CBBancoPrincipal.Size = new System.Drawing.Size(233, 23);
            this.CBBancoPrincipal.TabIndex = 2;
            // 
            // TBNumeroCuenta01
            // 
            this.TBNumeroCuenta01.Location = new System.Drawing.Point(89, 64);
            this.TBNumeroCuenta01.Name = "TBNumeroCuenta01";
            this.TBNumeroCuenta01.Size = new System.Drawing.Size(233, 21);
            this.TBNumeroCuenta01.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Banco Princ.";
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
            this.btnEliminar.Location = new System.Drawing.Point(262, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(88, 230);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 24;
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
            this.btnEditar.Location = new System.Drawing.Point(180, 230);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 26);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(6, 230);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 26);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseDown);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.DGResultado);
            this.groupBox2.Controls.Add(this.CHEliminar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TBBuscar);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leal Academico - Consulta de Clientes";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 15);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "---------------------";
            // 
            // DGResultado
            // 
            this.DGResultado.AllowUserToAddRows = false;
            this.DGResultado.AllowUserToDeleteRows = false;
            this.DGResultado.BackgroundColor = System.Drawing.Color.White;
            this.DGResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultado.Location = new System.Drawing.Point(6, 62);
            this.DGResultado.Name = "DGResultado";
            this.DGResultado.ReadOnly = true;
            this.DGResultado.Size = new System.Drawing.Size(500, 196);
            this.DGResultado.TabIndex = 12;
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
            this.CHEliminar.Location = new System.Drawing.Point(437, 21);
            this.CHEliminar.Name = "CHEliminar";
            this.CHEliminar.Size = new System.Drawing.Size(69, 19);
            this.CHEliminar.TabIndex = 9;
            this.CHEliminar.Text = "Eliminar";
            this.CHEliminar.UseVisualStyleBackColor = true;
            this.CHEliminar.CheckedChanged += new System.EventHandler(this.CHEliminar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cliente a Consultar";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(122, 20);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(309, 21);
            this.TBBuscar.TabIndex = 7;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // frmProduccion_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 284);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmProduccion_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion - Cliente Datos Basicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduccion_Cliente_FormClosing);
            this.Load += new System.EventHandler(this.frmProduccion_Cliente_DatosBasicos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TPDatosBasicos.ResumeLayout(false);
            this.TPDatosBasicos.PerformLayout();
            this.TPDatosDeEnvio.ResumeLayout(false);
            this.TPDatosDeEnvio.PerformLayout();
            this.TPFinanciera.ResumeLayout(false);
            this.TPFinanciera.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBDocumento;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBDireccion02;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBMovil;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGResultado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.CheckBox CHEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPDatosBasicos;
        private System.Windows.Forms.TabPage TPDatosDeEnvio;
        private System.Windows.Forms.TabPage TPFinanciera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBDireccion01;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker DTFechaDeInicio;
        private System.Windows.Forms.TextBox TBCodigoPostal;
        private System.Windows.Forms.ComboBox CBBancoPrincipal;
        private System.Windows.Forms.TextBox TBNumeroCuenta01;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CBTipoDeCuenta02;
        private System.Windows.Forms.ComboBox CBBancoSecundario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox CBTipoDeCuenta01;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TBNumeroCuenta02;
    }
}