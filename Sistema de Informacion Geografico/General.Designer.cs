namespace Sistema_de_Informacion_Geografico
{
    partial class General
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.netBarControl1 = new NetBarControl.NetBarControl();
            this.RG = new NetBarControl.NetBarGroup();
            this.netBarItem2 = new NetBarControl.NetBarItem();
            this.netBarItem3 = new NetBarControl.NetBarItem();
            this.netBarItem4 = new NetBarControl.NetBarItem();
            this.netBarItem5 = new NetBarControl.NetBarItem();
            this.netBarItem6 = new NetBarControl.NetBarItem();
            this.netBarItem7 = new NetBarControl.NetBarItem();
            this.RH = new NetBarControl.NetBarGroup();
            this.netBarItem8 = new NetBarControl.NetBarItem();
            this.netBarItem9 = new NetBarControl.NetBarItem();
            this.netBarItem10 = new NetBarControl.NetBarItem();
            this.netBarItem11 = new NetBarControl.NetBarItem();
            this.netBarItem12 = new NetBarControl.NetBarItem();
            this.netBarItem13 = new NetBarControl.NetBarItem();
            this.netBarItem14 = new NetBarControl.NetBarItem();
            this.netBarItem15 = new NetBarControl.NetBarItem();
            this.netBarItem16 = new NetBarControl.NetBarItem();
            this.RQT = new NetBarControl.NetBarGroup();
            this.netBarItem17 = new NetBarControl.NetBarItem();
            this.netBarItem18 = new NetBarControl.NetBarItem();
            this.netBarItem19 = new NetBarControl.NetBarItem();
            this.netBarItem20 = new NetBarControl.NetBarItem();
            this.netBarItem21 = new NetBarControl.NetBarItem();
            this.netBarItem22 = new NetBarControl.NetBarItem();
            this.RSE = new NetBarControl.NetBarGroup();
            this.netBarItem23 = new NetBarControl.NetBarItem();
            this.netBarItem24 = new NetBarControl.NetBarItem();
            this.netBarItem25 = new NetBarControl.NetBarItem();
            this.netBarItem26 = new NetBarControl.NetBarItem();
            this.netBarItem27 = new NetBarControl.NetBarItem();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.netBarItem1 = new NetBarControl.NetBarItem();
            this.toolCursor = new System.Windows.Forms.ToolStripButton();
            this.toolZoomExtent = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomInt = new System.Windows.Forms.ToolStripButton();
            this.toolMove = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCursor,
            this.toolZoomExtent,
            this.toolZoomOut,
            this.toolZoomInt,
            this.toolMove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1120, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.fondo;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.netBarControl1);
            this.splitContainer1.Panel1.Controls.Add(this.cmbFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMap1);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 670);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categorías";
            // 
            // netBarControl1
            // 
            this.netBarControl1.ActiveGroup = this.RG;
            this.netBarControl1.BackColor = System.Drawing.SystemColors.Control;
            this.netBarControl1.Groups.AddRange(new NetBarControl.NetBarGroup[] {
            this.RG,
            this.RH,
            this.RQT,
            this.RSE});
            this.netBarControl1.Location = new System.Drawing.Point(20, 197);
            this.netBarControl1.Name = "netBarControl1";
            this.netBarControl1.Size = new System.Drawing.Size(283, 448);
            this.netBarControl1.TabIndex = 7;
            this.netBarControl1.Text = "netBarControl1";
            this.netBarControl1.ActiveGroupChanged += new System.EventHandler(this.netBarControl1_ActiveGroupChanged);
            // 
            // RG
            // 
            this.RG.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.netBarItem1,
            this.netBarItem2,
            this.netBarItem3,
            this.netBarItem4,
            this.netBarItem5,
            this.netBarItem6,
            this.netBarItem7});
            this.RG.Name = "RG";
            this.RG.Text = "Riesgos Geológicos";
            // 
            // netBarItem2
            // 
            this.netBarItem2.Name = "netBarItem2";
            this.netBarItem2.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_emisionesvolcanicas;
            this.netBarItem2.Text = "Emisiones volcánicas";
            this.netBarItem2.ItemClick += new System.EventHandler(this.netBarItem2_ItemClick);
            // 
            // netBarItem3
            // 
            this.netBarItem3.Name = "netBarItem3";
            this.netBarItem3.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_tsunamis;
            this.netBarItem3.Text = "Tsunamis";
            this.netBarItem3.ItemClick += new System.EventHandler(this.netBarItem3_ItemClick);
            // 
            // netBarItem4
            // 
            this.netBarItem4.Name = "netBarItem4";
            this.netBarItem4.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_inestabilidaddeladeras;
            this.netBarItem4.Text = "Inestabilidad de laderas";
            this.netBarItem4.ItemClick += new System.EventHandler(this.netBarItem4_ItemClick);
            // 
            // netBarItem5
            // 
            this.netBarItem5.Name = "netBarItem5";
            this.netBarItem5.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_hundimientos;
            this.netBarItem5.Text = "Hundimientos";
            this.netBarItem5.ItemClick += new System.EventHandler(this.netBarItem5_ItemClick);
            // 
            // netBarItem6
            // 
            this.netBarItem6.Name = "netBarItem6";
            this.netBarItem6.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_erupsiones;
            this.netBarItem6.Text = "Erupciones";
            this.netBarItem6.ItemClick += new System.EventHandler(this.netBarItem6_ItemClick);
            // 
            // netBarItem7
            // 
            this.netBarItem7.Name = "netBarItem7";
            this.netBarItem7.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_agrietamientos;
            this.netBarItem7.Text = "Agrietamientos de terreno";
            this.netBarItem7.ItemClick += new System.EventHandler(this.netBarItem7_ItemClick);
            // 
            // RH
            // 
            this.RH.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.netBarItem8,
            this.netBarItem9,
            this.netBarItem10,
            this.netBarItem11,
            this.netBarItem12,
            this.netBarItem13,
            this.netBarItem14,
            this.netBarItem15,
            this.netBarItem16});
            this.RH.Name = "RH";
            this.RH.Text = "Riesgos Hidrometereológicos";
            // 
            // netBarItem8
            // 
            this.netBarItem8.Name = "netBarItem8";
            this.netBarItem8.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_huracanes;
            this.netBarItem8.Text = "Huracanes";
            this.netBarItem8.ItemClick += new System.EventHandler(this.netBarItem8_ItemClick);
            // 
            // netBarItem9
            // 
            this.netBarItem9.Name = "netBarItem9";
            this.netBarItem9.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_inundaciones;
            this.netBarItem9.Text = "Inundaciones";
            this.netBarItem9.ItemClick += new System.EventHandler(this.netBarItem9_ItemClick);
            // 
            // netBarItem10
            // 
            this.netBarItem10.Name = "netBarItem10";
            this.netBarItem10.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_tormentasdegranizo;
            this.netBarItem10.Text = "Tormentas de granizo";
            this.netBarItem10.ItemClick += new System.EventHandler(this.netBarItem10_ItemClick);
            // 
            // netBarItem11
            // 
            this.netBarItem11.Name = "netBarItem11";
            this.netBarItem11.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_heladasynevadas;
            this.netBarItem11.Text = "Heladas y nevadas";
            this.netBarItem11.ItemClick += new System.EventHandler(this.netBarItem11_ItemClick);
            // 
            // netBarItem12
            // 
            this.netBarItem12.Name = "netBarItem12";
            this.netBarItem12.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_mareasdetormentas;
            this.netBarItem12.Text = "Mareas de tormentas";
            this.netBarItem12.ItemClick += new System.EventHandler(this.netBarItem12_ItemClick);
            // 
            // netBarItem13
            // 
            this.netBarItem13.Name = "netBarItem13";
            this.netBarItem13.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_vientos;
            this.netBarItem13.Text = "Vientos";
            this.netBarItem13.ItemClick += new System.EventHandler(this.netBarItem13_ItemClick);
            // 
            // netBarItem14
            // 
            this.netBarItem14.Name = "netBarItem14";
            this.netBarItem14.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_sequias;
            this.netBarItem14.Text = "Sequías";
            this.netBarItem14.ItemClick += new System.EventHandler(this.netBarItem14_ItemClick);
            // 
            // netBarItem15
            // 
            this.netBarItem15.Name = "netBarItem15";
            this.netBarItem15.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_erosion;
            this.netBarItem15.Text = "Erosión";
            this.netBarItem15.ItemClick += new System.EventHandler(this.netBarItem15_ItemClick);
            // 
            // netBarItem16
            // 
            this.netBarItem16.Name = "netBarItem16";
            this.netBarItem16.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_precipitacion;
            this.netBarItem16.Text = "Precipitación";
            this.netBarItem16.ItemClick += new System.EventHandler(this.netBarItem16_ItemClick);
            // 
            // RQT
            // 
            this.RQT.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.netBarItem17,
            this.netBarItem18,
            this.netBarItem19,
            this.netBarItem20,
            this.netBarItem21,
            this.netBarItem22});
            this.RQT.Name = "RQT";
            this.RQT.Text = "Riesgos Químicos-Tecnológicos";
            // 
            // netBarItem17
            // 
            this.netBarItem17.Name = "netBarItem17";
            this.netBarItem17.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_derrames;
            this.netBarItem17.Text = "Derrames";
            this.netBarItem17.ItemClick += new System.EventHandler(this.netBarItem17_ItemClick);
            // 
            // netBarItem18
            // 
            this.netBarItem18.Name = "netBarItem18";
            this.netBarItem18.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_exposiones;
            this.netBarItem18.Text = "Explosiones";
            this.netBarItem18.ItemClick += new System.EventHandler(this.netBarItem18_ItemClick);
            // 
            // netBarItem19
            // 
            this.netBarItem19.Name = "netBarItem19";
            this.netBarItem19.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_radiaciones;
            this.netBarItem19.Text = "Radiaciones";
            this.netBarItem19.ItemClick += new System.EventHandler(this.netBarItem19_ItemClick);
            // 
            // netBarItem20
            // 
            this.netBarItem20.Name = "netBarItem20";
            this.netBarItem20.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_incendios;
            this.netBarItem20.Text = "Incendios";
            this.netBarItem20.ItemClick += new System.EventHandler(this.netBarItem20_ItemClick);
            // 
            // netBarItem21
            // 
            this.netBarItem21.Name = "netBarItem21";
            this.netBarItem21.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_fugastoxicas;
            this.netBarItem21.Text = "Fugas tóxicas";
            this.netBarItem21.ItemClick += new System.EventHandler(this.netBarItem21_ItemClick);
            // 
            // netBarItem22
            // 
            this.netBarItem22.Name = "netBarItem22";
            this.netBarItem22.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_residuospeligrosos;
            this.netBarItem22.Text = "Residuos peligrosos";
            this.netBarItem22.ItemClick += new System.EventHandler(this.netBarItem22_ItemClick);
            // 
            // RSE
            // 
            this.RSE.Items.AddRange(new NetBarControl.NetBarItem[] {
            this.netBarItem23,
            this.netBarItem24,
            this.netBarItem25,
            this.netBarItem26,
            this.netBarItem27});
            this.RSE.Name = "RSE";
            this.RSE.Text = "Riesgos Sanitarios-Ecológicos";
            // 
            // netBarItem23
            // 
            this.netBarItem23.Name = "netBarItem23";
            this.netBarItem23.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_epidemiasoplagas;
            this.netBarItem23.Text = "Epidemias o plagas";
            this.netBarItem23.ItemClick += new System.EventHandler(this.netBarItem23_ItemClick);
            // 
            // netBarItem24
            // 
            this.netBarItem24.Name = "netBarItem24";
            this.netBarItem24.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_contaminaciondeaire;
            this.netBarItem24.Text = "Contaminación de aire";
            this.netBarItem24.ItemClick += new System.EventHandler(this.netBarItem24_ItemClick);
            // 
            // netBarItem25
            // 
            this.netBarItem25.Name = "netBarItem25";
            this.netBarItem25.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_contaminaciondesuelo;
            this.netBarItem25.Text = "Contaminación de suelo";
            this.netBarItem25.ItemClick += new System.EventHandler(this.netBarItem25_ItemClick);
            // 
            // netBarItem26
            // 
            this.netBarItem26.Name = "netBarItem26";
            this.netBarItem26.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_contaminaciondeagua;
            this.netBarItem26.Text = "Contaminación de agua";
            this.netBarItem26.ItemClick += new System.EventHandler(this.netBarItem26_ItemClick);
            // 
            // netBarItem27
            // 
            this.netBarItem27.Name = "netBarItem27";
            this.netBarItem27.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_contaminaciondealimentos;
            this.netBarItem27.Text = "Contaminación de alimentos";
            this.netBarItem27.ItemClick += new System.EventHandler(this.netBarItem27_ItemClick);
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Categoria y tipos de riesgo",
            "Poblaciones",
            "Municipios",
            "Distritos",
            "Regiones",
            "Estados"});
            this.cmbFilter.Location = new System.Drawing.Point(86, 92);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(217, 24);
            this.cmbFilter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar por:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(316, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda General";
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 0);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(800, 670);
            this.axMap1.TabIndex = 0;
            this.axMap1.MouseMoveEvent += new AxMapWinGIS._DMapEvents_MouseMoveEventHandler(this.axMap1_MouseMoveEvent);
            // 
            // netBarItem1
            // 
            this.netBarItem1.Name = "netBarItem1";
            this.netBarItem1.SmallImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.marker_sismos;
            this.netBarItem1.Text = "Sismos";
            this.netBarItem1.ItemClick += new System.EventHandler(this.netBarItem1_ItemClick);
            // 
            // toolCursor
            // 
            this.toolCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCursor.Image = ((System.Drawing.Image)(resources.GetObject("toolCursor.Image")));
            this.toolCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCursor.Name = "toolCursor";
            this.toolCursor.Size = new System.Drawing.Size(23, 22);
            this.toolCursor.Text = "toolControl";
            this.toolCursor.Click += new System.EventHandler(this.toolCursor_Click);
            // 
            // toolZoomExtent
            // 
            this.toolZoomExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomExtent.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomExtent.Image")));
            this.toolZoomExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomExtent.Name = "toolZoomExtent";
            this.toolZoomExtent.Size = new System.Drawing.Size(23, 22);
            this.toolZoomExtent.Click += new System.EventHandler(this.toolZoomExtent_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomOut.Image")));
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolZoomOut.Text = "toolStripButton2";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolZoomInt
            // 
            this.toolZoomInt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomInt.Image = ((System.Drawing.Image)(resources.GetObject("toolZoomInt.Image")));
            this.toolZoomInt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomInt.Name = "toolZoomInt";
            this.toolZoomInt.Size = new System.Drawing.Size(23, 22);
            this.toolZoomInt.Text = "toolZoomInt";
            this.toolZoomInt.Click += new System.EventHandler(this.toolZoomInt_Click);
            // 
            // toolMove
            // 
            this.toolMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMove.Image = ((System.Drawing.Image)(resources.GetObject("toolMove.Image")));
            this.toolMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMove.Name = "toolMove";
            this.toolMove.Size = new System.Drawing.Size(23, 22);
            this.toolMove.Text = "toolStripButton2";
            this.toolMove.Click += new System.EventHandler(this.toolMove_Click);
            // 
            // General
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1120, 695);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "General";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolCursor;
        private System.Windows.Forms.ToolStripButton toolZoomExtent;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripButton toolZoomInt;
        private System.Windows.Forms.ToolStripButton toolMove;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label2;
        private NetBarControl.NetBarControl netBarControl1;
        private NetBarControl.NetBarGroup RH;
        private NetBarControl.NetBarGroup RQT;
        private NetBarControl.NetBarGroup RSE;
        private NetBarControl.NetBarItem netBarItem1;
        private NetBarControl.NetBarItem netBarItem2;
        private NetBarControl.NetBarItem netBarItem3;
        private NetBarControl.NetBarItem netBarItem4;
        private NetBarControl.NetBarItem netBarItem5;
        private NetBarControl.NetBarItem netBarItem6;
        private NetBarControl.NetBarItem netBarItem7;
        private NetBarControl.NetBarItem netBarItem8;
        private NetBarControl.NetBarItem netBarItem9;
        private NetBarControl.NetBarItem netBarItem10;
        private NetBarControl.NetBarItem netBarItem11;
        private NetBarControl.NetBarItem netBarItem12;
        private NetBarControl.NetBarItem netBarItem13;
        private NetBarControl.NetBarItem netBarItem14;
        private NetBarControl.NetBarItem netBarItem15;
        private NetBarControl.NetBarItem netBarItem16;
        private NetBarControl.NetBarItem netBarItem17;
        private NetBarControl.NetBarItem netBarItem18;
        private NetBarControl.NetBarItem netBarItem19;
        private NetBarControl.NetBarItem netBarItem20;
        private NetBarControl.NetBarItem netBarItem21;
        private NetBarControl.NetBarItem netBarItem22;
        private NetBarControl.NetBarItem netBarItem23;
        private NetBarControl.NetBarItem netBarItem24;
        private NetBarControl.NetBarItem netBarItem25;
        private NetBarControl.NetBarItem netBarItem26;
        private NetBarControl.NetBarItem netBarItem27;
        private System.Windows.Forms.Label label3;
        private NetBarControl.NetBarGroup RG;

    }
}

