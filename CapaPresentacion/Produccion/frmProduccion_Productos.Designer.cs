namespace CapaPresentacion
{
    partial class frmProduccion_Productos
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
            this.TPDatos = new System.Windows.Forms.TabPage();
            this.TBMarca = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBProducto = new System.Windows.Forms.TextBox();
            this.TBReferencia = new System.Windows.Forms.TextBox();
            this.TBCodigoID = new System.Windows.Forms.TextBox();
            this.CBGrupo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CBImportado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBEmpacado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CBVence = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CBOfertable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TPCostos = new System.Windows.Forms.TabPage();
            this.TBCantidadMaxima = new System.Windows.Forms.TextBox();
            this.TBCantidadMinima = new System.Windows.Forms.TextBox();
            this.TBValorOferta = new System.Windows.Forms.TextBox();
            this.TBValorVenta03 = new System.Windows.Forms.TextBox();
            this.TBValorVenta02 = new System.Windows.Forms.TextBox();
            this.TBValorVenta01 = new System.Windows.Forms.TextBox();
            this.TBValorCompra = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.CBVentaPublico = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.TPImpuestos = new System.Windows.Forms.TabPage();
            this.TBIdmarca = new System.Windows.Forms.TextBox();
            this.TBIdimpuesto = new System.Windows.Forms.TextBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TBIdbodega = new System.Windows.Forms.TextBox();
            this.TBObservacion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TBUbicacion = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.CBUnidad = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TBIdproveedor = new System.Windows.Forms.TextBox();
            this.TBBodega = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TBImpuesto = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.CHEliminar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.btnExaminar_Marca = new System.Windows.Forms.Button();
            this.btnExaminar_Proveedor = new System.Windows.Forms.Button();
            this.btnExaminar_Bodega = new System.Windows.Forms.Button();
            this.btnExaminar_Impuesto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TPDatos.SuspendLayout();
            this.TPCostos.SuspendLayout();
            this.TPImpuestos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Academico - Registro de Productos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPDatos);
            this.tabControl1.Controls.Add(this.TPCostos);
            this.tabControl1.Controls.Add(this.TPImpuestos);
            this.tabControl1.Location = new System.Drawing.Point(8, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 256);
            this.tabControl1.TabIndex = 3;
            // 
            // TPDatos
            // 
            this.TPDatos.Controls.Add(this.btnExaminar_Marca);
            this.TPDatos.Controls.Add(this.TBMarca);
            this.TPDatos.Controls.Add(this.TBDescripcion);
            this.TPDatos.Controls.Add(this.TBProducto);
            this.TPDatos.Controls.Add(this.TBReferencia);
            this.TPDatos.Controls.Add(this.TBCodigoID);
            this.TPDatos.Controls.Add(this.CBGrupo);
            this.TPDatos.Controls.Add(this.label1);
            this.TPDatos.Controls.Add(this.label12);
            this.TPDatos.Controls.Add(this.label13);
            this.TPDatos.Controls.Add(this.CBImportado);
            this.TPDatos.Controls.Add(this.label5);
            this.TPDatos.Controls.Add(this.CBEmpacado);
            this.TPDatos.Controls.Add(this.label14);
            this.TPDatos.Controls.Add(this.label7);
            this.TPDatos.Controls.Add(this.CBTipo);
            this.TPDatos.Controls.Add(this.label6);
            this.TPDatos.Controls.Add(this.label8);
            this.TPDatos.Controls.Add(this.CBVence);
            this.TPDatos.Controls.Add(this.label3);
            this.TPDatos.Controls.Add(this.label17);
            this.TPDatos.Controls.Add(this.CBOfertable);
            this.TPDatos.Controls.Add(this.label2);
            this.TPDatos.Location = new System.Drawing.Point(4, 24);
            this.TPDatos.Name = "TPDatos";
            this.TPDatos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatos.Size = new System.Drawing.Size(340, 228);
            this.TPDatos.TabIndex = 0;
            this.TPDatos.Text = "Datos Basicos";
            this.TPDatos.UseVisualStyleBackColor = true;
            // 
            // TBMarca
            // 
            this.TBMarca.Location = new System.Drawing.Point(83, 114);
            this.TBMarca.Name = "TBMarca";
            this.TBMarca.Size = new System.Drawing.Size(219, 21);
            this.TBMarca.TabIndex = 49;
            this.TBMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(83, 87);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(250, 21);
            this.TBDescripcion.TabIndex = 10;
            // 
            // TBProducto
            // 
            this.TBProducto.Location = new System.Drawing.Point(83, 33);
            this.TBProducto.Name = "TBProducto";
            this.TBProducto.Size = new System.Drawing.Size(250, 21);
            this.TBProducto.TabIndex = 9;
            // 
            // TBReferencia
            // 
            this.TBReferencia.Location = new System.Drawing.Point(83, 60);
            this.TBReferencia.Name = "TBReferencia";
            this.TBReferencia.Size = new System.Drawing.Size(250, 21);
            this.TBReferencia.TabIndex = 13;
            // 
            // TBCodigoID
            // 
            this.TBCodigoID.Location = new System.Drawing.Point(83, 6);
            this.TBCodigoID.Name = "TBCodigoID";
            this.TBCodigoID.Size = new System.Drawing.Size(250, 21);
            this.TBCodigoID.TabIndex = 8;
            this.TBCodigoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBGrupo
            // 
            this.CBGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGrupo.FormattingEnabled = true;
            this.CBGrupo.Items.AddRange(new object[] {
            "-",
            "Inventario",
            "Servicio",
            "Gastos"});
            this.CBGrupo.Location = new System.Drawing.Point(83, 199);
            this.CBGrupo.Name = "CBGrupo";
            this.CBGrupo.Size = new System.Drawing.Size(100, 23);
            this.CBGrupo.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "Grupo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "Vence";
            // 
            // CBImportado
            // 
            this.CBImportado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBImportado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBImportado.FormattingEnabled = true;
            this.CBImportado.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBImportado.Location = new System.Drawing.Point(256, 141);
            this.CBImportado.Name = "CBImportado";
            this.CBImportado.Size = new System.Drawing.Size(77, 23);
            this.CBImportado.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca";
            // 
            // CBEmpacado
            // 
            this.CBEmpacado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEmpacado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEmpacado.FormattingEnabled = true;
            this.CBEmpacado.Items.AddRange(new object[] {
            "-",
            "Aluminio",
            "Carton",
            "No Aplicable",
            "Plastico"});
            this.CBEmpacado.Location = new System.Drawing.Point(83, 170);
            this.CBEmpacado.Name = "CBEmpacado";
            this.CBEmpacado.Size = new System.Drawing.Size(100, 23);
            this.CBEmpacado.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(187, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Empacado";
            // 
            // CBTipo
            // 
            this.CBTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Items.AddRange(new object[] {
            "-",
            "Casero",
            "Comercial",
            "Comestible",
            "Descechable",
            "Natural",
            "Quimico"});
            this.CBTipo.Location = new System.Drawing.Point(233, 170);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(100, 23);
            this.CBTipo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Referencia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Importado";
            // 
            // CBVence
            // 
            this.CBVence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBVence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVence.FormattingEnabled = true;
            this.CBVence.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBVence.Location = new System.Drawing.Point(233, 199);
            this.CBVence.Name = "CBVence";
            this.CBVence.Size = new System.Drawing.Size(100, 23);
            this.CBVence.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 15);
            this.label17.TabIndex = 29;
            this.label17.Text = "Ofertable";
            // 
            // CBOfertable
            // 
            this.CBOfertable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBOfertable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOfertable.FormattingEnabled = true;
            this.CBOfertable.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBOfertable.Location = new System.Drawing.Point(83, 141);
            this.CBOfertable.Name = "CBOfertable";
            this.CBOfertable.Size = new System.Drawing.Size(100, 23);
            this.CBOfertable.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto";
            // 
            // TPCostos
            // 
            this.TPCostos.Controls.Add(this.TBCantidadMaxima);
            this.TPCostos.Controls.Add(this.TBCantidadMinima);
            this.TPCostos.Controls.Add(this.TBValorOferta);
            this.TPCostos.Controls.Add(this.TBValorVenta03);
            this.TPCostos.Controls.Add(this.TBValorVenta02);
            this.TPCostos.Controls.Add(this.TBValorVenta01);
            this.TPCostos.Controls.Add(this.TBValorCompra);
            this.TPCostos.Controls.Add(this.label23);
            this.TPCostos.Controls.Add(this.label22);
            this.TPCostos.Controls.Add(this.CBVentaPublico);
            this.TPCostos.Controls.Add(this.label15);
            this.TPCostos.Controls.Add(this.label10);
            this.TPCostos.Controls.Add(this.label16);
            this.TPCostos.Controls.Add(this.label9);
            this.TPCostos.Controls.Add(this.label20);
            this.TPCostos.Controls.Add(this.label34);
            this.TPCostos.Location = new System.Drawing.Point(4, 24);
            this.TPCostos.Name = "TPCostos";
            this.TPCostos.Size = new System.Drawing.Size(340, 228);
            this.TPCostos.TabIndex = 3;
            this.TPCostos.Text = "Costos y Precios";
            this.TPCostos.UseVisualStyleBackColor = true;
            // 
            // TBCantidadMaxima
            // 
            this.TBCantidadMaxima.Location = new System.Drawing.Point(177, 197);
            this.TBCantidadMaxima.Name = "TBCantidadMaxima";
            this.TBCantidadMaxima.Size = new System.Drawing.Size(156, 21);
            this.TBCantidadMaxima.TabIndex = 209;
            // 
            // TBCantidadMinima
            // 
            this.TBCantidadMinima.Location = new System.Drawing.Point(177, 170);
            this.TBCantidadMinima.Name = "TBCantidadMinima";
            this.TBCantidadMinima.Size = new System.Drawing.Size(156, 21);
            this.TBCantidadMinima.TabIndex = 208;
            // 
            // TBValorOferta
            // 
            this.TBValorOferta.Location = new System.Drawing.Point(108, 114);
            this.TBValorOferta.Name = "TBValorOferta";
            this.TBValorOferta.Size = new System.Drawing.Size(225, 21);
            this.TBValorOferta.TabIndex = 200;
            // 
            // TBValorVenta03
            // 
            this.TBValorVenta03.Location = new System.Drawing.Point(108, 87);
            this.TBValorVenta03.Name = "TBValorVenta03";
            this.TBValorVenta03.Size = new System.Drawing.Size(225, 21);
            this.TBValorVenta03.TabIndex = 189;
            // 
            // TBValorVenta02
            // 
            this.TBValorVenta02.Location = new System.Drawing.Point(108, 60);
            this.TBValorVenta02.Name = "TBValorVenta02";
            this.TBValorVenta02.Size = new System.Drawing.Size(225, 21);
            this.TBValorVenta02.TabIndex = 188;
            // 
            // TBValorVenta01
            // 
            this.TBValorVenta01.Location = new System.Drawing.Point(108, 33);
            this.TBValorVenta01.Name = "TBValorVenta01";
            this.TBValorVenta01.Size = new System.Drawing.Size(225, 21);
            this.TBValorVenta01.TabIndex = 187;
            // 
            // TBValorCompra
            // 
            this.TBValorCompra.Location = new System.Drawing.Point(108, 6);
            this.TBValorCompra.Name = "TBValorCompra";
            this.TBValorCompra.Size = new System.Drawing.Size(225, 21);
            this.TBValorCompra.TabIndex = 160;
            this.TBValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 199);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(166, 15);
            this.label23.TabIndex = 204;
            this.label23.Text = "Cantidad Maxima por Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(163, 15);
            this.label22.TabIndex = 203;
            this.label22.Text = "Cantidad Minima por Cliente";
            // 
            // CBVentaPublico
            // 
            this.CBVentaPublico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBVentaPublico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVentaPublico.FormattingEnabled = true;
            this.CBVentaPublico.Items.AddRange(new object[] {
            "-",
            "Valor 1",
            "Valor 2",
            "Valor 3",
            "Oferta"});
            this.CBVentaPublico.Location = new System.Drawing.Point(154, 141);
            this.CBVentaPublico.Name = "CBVentaPublico";
            this.CBVentaPublico.Size = new System.Drawing.Size(179, 23);
            this.CBVentaPublico.TabIndex = 197;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 15);
            this.label15.TabIndex = 196;
            this.label15.Text = "Valor de Venta al Publico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 192;
            this.label10.Text = "Valor de Oferta";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 15);
            this.label16.TabIndex = 191;
            this.label16.Text = "Valor de Venta 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 190;
            this.label9.Text = "Valor de Venta 2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 15);
            this.label20.TabIndex = 186;
            this.label20.Text = "Valor de Venta 1";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 6);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 15);
            this.label34.TabIndex = 157;
            this.label34.Text = "Valor de Compra";
            // 
            // TPImpuestos
            // 
            this.TPImpuestos.Controls.Add(this.TBIdmarca);
            this.TPImpuestos.Controls.Add(this.TBIdimpuesto);
            this.TPImpuestos.Controls.Add(this.TBProveedor);
            this.TPImpuestos.Controls.Add(this.label11);
            this.TPImpuestos.Controls.Add(this.TBIdbodega);
            this.TPImpuestos.Controls.Add(this.TBObservacion);
            this.TPImpuestos.Controls.Add(this.label19);
            this.TPImpuestos.Controls.Add(this.TBUbicacion);
            this.TPImpuestos.Controls.Add(this.label26);
            this.TPImpuestos.Controls.Add(this.CBUnidad);
            this.TPImpuestos.Controls.Add(this.label21);
            this.TPImpuestos.Controls.Add(this.TBIdproveedor);
            this.TPImpuestos.Controls.Add(this.TBBodega);
            this.TPImpuestos.Controls.Add(this.label24);
            this.TPImpuestos.Controls.Add(this.TBImpuesto);
            this.TPImpuestos.Controls.Add(this.label25);
            this.TPImpuestos.Controls.Add(this.btnExaminar_Proveedor);
            this.TPImpuestos.Controls.Add(this.btnExaminar_Bodega);
            this.TPImpuestos.Controls.Add(this.btnExaminar_Impuesto);
            this.TPImpuestos.Location = new System.Drawing.Point(4, 24);
            this.TPImpuestos.Name = "TPImpuestos";
            this.TPImpuestos.Padding = new System.Windows.Forms.Padding(3);
            this.TPImpuestos.Size = new System.Drawing.Size(340, 228);
            this.TPImpuestos.TabIndex = 4;
            this.TPImpuestos.Text = "Impuestos - Otros Datos";
            this.TPImpuestos.UseVisualStyleBackColor = true;
            // 
            // TBIdmarca
            // 
            this.TBIdmarca.Location = new System.Drawing.Point(29, 202);
            this.TBIdmarca.Name = "TBIdmarca";
            this.TBIdmarca.Size = new System.Drawing.Size(27, 21);
            this.TBIdmarca.TabIndex = 7;
            // 
            // TBIdimpuesto
            // 
            this.TBIdimpuesto.Location = new System.Drawing.Point(9, 202);
            this.TBIdimpuesto.Name = "TBIdimpuesto";
            this.TBIdimpuesto.Size = new System.Drawing.Size(14, 21);
            this.TBIdimpuesto.TabIndex = 7;
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(70, 87);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(233, 21);
            this.TBProveedor.TabIndex = 215;
            this.TBProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 214;
            this.label11.Text = "Proveedor";
            // 
            // TBIdbodega
            // 
            this.TBIdbodega.Location = new System.Drawing.Point(29, 175);
            this.TBIdbodega.Name = "TBIdbodega";
            this.TBIdbodega.Size = new System.Drawing.Size(14, 21);
            this.TBIdbodega.TabIndex = 46;
            // 
            // TBObservacion
            // 
            this.TBObservacion.Location = new System.Drawing.Point(87, 143);
            this.TBObservacion.Multiline = true;
            this.TBObservacion.Name = "TBObservacion";
            this.TBObservacion.Size = new System.Drawing.Size(247, 79);
            this.TBObservacion.TabIndex = 213;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 15);
            this.label19.TabIndex = 212;
            this.label19.Text = "Observacion";
            // 
            // TBUbicacion
            // 
            this.TBUbicacion.Location = new System.Drawing.Point(115, 60);
            this.TBUbicacion.Name = "TBUbicacion";
            this.TBUbicacion.Size = new System.Drawing.Size(219, 21);
            this.TBUbicacion.TabIndex = 211;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 63);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 15);
            this.label26.TabIndex = 210;
            this.label26.Text = "Ubicacion Interna";
            // 
            // CBUnidad
            // 
            this.CBUnidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUnidad.FormattingEnabled = true;
            this.CBUnidad.Items.AddRange(new object[] {
            "-",
            "GRA",
            "KG",
            "LIB",
            "LIT",
            "UNI"});
            this.CBUnidad.Location = new System.Drawing.Point(178, 114);
            this.CBUnidad.Name = "CBUnidad";
            this.CBUnidad.Size = new System.Drawing.Size(156, 23);
            this.CBUnidad.Sorted = true;
            this.CBUnidad.TabIndex = 209;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 117);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(155, 15);
            this.label21.TabIndex = 208;
            this.label21.Text = "Unidad de Venta al Publico";
            // 
            // TBIdproveedor
            // 
            this.TBIdproveedor.Location = new System.Drawing.Point(9, 176);
            this.TBIdproveedor.Name = "TBIdproveedor";
            this.TBIdproveedor.Size = new System.Drawing.Size(14, 21);
            this.TBIdproveedor.TabIndex = 45;
            // 
            // TBBodega
            // 
            this.TBBodega.Location = new System.Drawing.Point(70, 33);
            this.TBBodega.Name = "TBBodega";
            this.TBBodega.Size = new System.Drawing.Size(233, 21);
            this.TBBodega.TabIndex = 196;
            this.TBBodega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 15);
            this.label24.TabIndex = 195;
            this.label24.Text = "Bodega";
            // 
            // TBImpuesto
            // 
            this.TBImpuesto.Location = new System.Drawing.Point(70, 6);
            this.TBImpuesto.Name = "TBImpuesto";
            this.TBImpuesto.Size = new System.Drawing.Size(233, 21);
            this.TBImpuesto.TabIndex = 1;
            this.TBImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 15);
            this.label25.TabIndex = 0;
            this.label25.Text = "Impuesto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.DGResultados);
            this.groupBox2.Controls.Add(this.CHEliminar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TBBuscar);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 316);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leal Academico - Consulta de Productos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 44);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 15);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "---------------------";
            // 
            // DGResultados
            // 
            this.DGResultados.AllowUserToAddRows = false;
            this.DGResultados.AllowUserToDeleteRows = false;
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 62);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(500, 248);
            this.DGResultados.TabIndex = 5;
            this.DGResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellContentClick);
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
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
            this.CHEliminar.Location = new System.Drawing.Point(389, 20);
            this.CHEliminar.Name = "CHEliminar";
            this.CHEliminar.Size = new System.Drawing.Size(69, 19);
            this.CHEliminar.TabIndex = 2;
            this.CHEliminar.Text = "Eliminar";
            this.CHEliminar.UseVisualStyleBackColor = true;
            this.CHEliminar.CheckedChanged += new System.EventHandler(this.CHEliminar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producto a Consultar";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(133, 20);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(250, 21);
            this.TBBuscar.TabIndex = 0;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // btnExaminar_Marca
            // 
            this.btnExaminar_Marca.BackColor = System.Drawing.Color.White;
            this.btnExaminar_Marca.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Marca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Marca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Marca.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Marca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Marca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Marca.Location = new System.Drawing.Point(308, 114);
            this.btnExaminar_Marca.Name = "btnExaminar_Marca";
            this.btnExaminar_Marca.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Marca.TabIndex = 195;
            this.btnExaminar_Marca.UseVisualStyleBackColor = false;
            this.btnExaminar_Marca.Click += new System.EventHandler(this.btnExaminar_Marca_Click);
            // 
            // btnExaminar_Proveedor
            // 
            this.btnExaminar_Proveedor.BackColor = System.Drawing.Color.White;
            this.btnExaminar_Proveedor.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Proveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Proveedor.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Proveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Proveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Proveedor.Location = new System.Drawing.Point(309, 87);
            this.btnExaminar_Proveedor.Name = "btnExaminar_Proveedor";
            this.btnExaminar_Proveedor.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Proveedor.TabIndex = 216;
            this.btnExaminar_Proveedor.UseVisualStyleBackColor = false;
            this.btnExaminar_Proveedor.Click += new System.EventHandler(this.btnExaminar_Proveedor_Click);
            // 
            // btnExaminar_Bodega
            // 
            this.btnExaminar_Bodega.BackColor = System.Drawing.Color.White;
            this.btnExaminar_Bodega.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Bodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Bodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Bodega.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Bodega.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Bodega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Bodega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Bodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Bodega.Location = new System.Drawing.Point(309, 33);
            this.btnExaminar_Bodega.Name = "btnExaminar_Bodega";
            this.btnExaminar_Bodega.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Bodega.TabIndex = 197;
            this.btnExaminar_Bodega.UseVisualStyleBackColor = false;
            this.btnExaminar_Bodega.Click += new System.EventHandler(this.btnExaminar_Bodega_Click);
            // 
            // btnExaminar_Impuesto
            // 
            this.btnExaminar_Impuesto.BackColor = System.Drawing.Color.White;
            this.btnExaminar_Impuesto.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar_Impuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar_Impuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar_Impuesto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar_Impuesto.FlatAppearance.BorderSize = 0;
            this.btnExaminar_Impuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar_Impuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar_Impuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar_Impuesto.Location = new System.Drawing.Point(309, 6);
            this.btnExaminar_Impuesto.Name = "btnExaminar_Impuesto";
            this.btnExaminar_Impuesto.Size = new System.Drawing.Size(25, 21);
            this.btnExaminar_Impuesto.TabIndex = 194;
            this.btnExaminar_Impuesto.UseVisualStyleBackColor = false;
            this.btnExaminar_Impuesto.Click += new System.EventHandler(this.btnExaminar_Impuesto_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(278, 284);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseDown);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
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
            this.btnEditar.Location = new System.Drawing.Point(196, 284);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 26);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEditar_MouseDown);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            this.btnEditar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEditar_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(90, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.BV_Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(8, 284);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 26);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseDown);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.btnNuevo_MouseLeave);
            this.btnNuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseMove);
            // 
            // frmProduccion_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmProduccion_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produccion - Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduccion_Productos_FormClosing);
            this.Load += new System.EventHandler(this.frmAlmacen_Productos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TPDatos.ResumeLayout(false);
            this.TPDatos.PerformLayout();
            this.TPCostos.ResumeLayout(false);
            this.TPCostos.PerformLayout();
            this.TPImpuestos.ResumeLayout(false);
            this.TPImpuestos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CHEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.TextBox TBIdproveedor;
        private System.Windows.Forms.TextBox TBIdbodega;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPDatos;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBProducto;
        private System.Windows.Forms.TextBox TBReferencia;
        private System.Windows.Forms.TextBox TBCodigoID;
        private System.Windows.Forms.ComboBox CBGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBImportado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBEmpacado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBVence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CBOfertable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TPCostos;
        private System.Windows.Forms.TextBox TBCantidadMaxima;
        private System.Windows.Forms.TextBox TBCantidadMinima;
        private System.Windows.Forms.TextBox TBValorOferta;
        private System.Windows.Forms.TextBox TBValorVenta03;
        private System.Windows.Forms.TextBox TBValorVenta02;
        private System.Windows.Forms.TextBox TBValorVenta01;
        private System.Windows.Forms.TextBox TBValorCompra;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox CBVentaPublico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage TPImpuestos;
        private System.Windows.Forms.ComboBox CBUnidad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnExaminar_Bodega;
        private System.Windows.Forms.TextBox TBBodega;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TBUbicacion;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TBObservacion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnExaminar_Proveedor;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBIdimpuesto;
        private System.Windows.Forms.Button btnExaminar_Impuesto;
        private System.Windows.Forms.TextBox TBImpuesto;
        private System.Windows.Forms.Button btnExaminar_Marca;
        private System.Windows.Forms.TextBox TBMarca;
        private System.Windows.Forms.TextBox TBIdmarca;
    }
}