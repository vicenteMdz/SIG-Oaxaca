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
            this.toolCursor = new System.Windows.Forms.ToolStripButton();
            this.toolZoomExtent = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomInt = new System.Windows.Forms.ToolStripButton();
            this.toolMove = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.aireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.residuosPeligrososToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mareasDeTormentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sequíasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precipitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riesgosMetereológicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sismosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erupcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisionesVolcánicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsunamisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inestabilidadDeLaderasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hundimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agritamientosDeTerrenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.fondo;
            this.splitContainer1.Panel1.Controls.Add(this.cmbFilter);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMap1);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 445);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(277, 22);
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
            this.button1.Location = new System.Drawing.Point(185, 122);
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
            this.txtSearch.Size = new System.Drawing.Size(265, 29);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.menuStrip4);
            this.groupBox1.Controls.Add(this.menuStrip3);
            this.groupBox1.Controls.Add(this.menuStrip2);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorías";
            // 
            // menuStrip4
            // 
            this.menuStrip4.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.menuStrip4.Location = new System.Drawing.Point(12, 101);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(205, 25);
            this.menuStrip4.TabIndex = 4;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(197, 21);
            this.toolStripMenuItem11.Text = "Riesgos Sanitarios-Ecológicos";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem12.Text = "Epidemias o Plagas";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aireToolStripMenuItem,
            this.sueloToolStripMenuItem,
            this.aguaToolStripMenuItem,
            this.alimentosToolStripMenuItem});
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem13.Text = "Contaminación";
            // 
            // aireToolStripMenuItem
            // 
            this.aireToolStripMenuItem.Name = "aireToolStripMenuItem";
            this.aireToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aireToolStripMenuItem.Text = "Aire";
            // 
            // sueloToolStripMenuItem
            // 
            this.sueloToolStripMenuItem.Name = "sueloToolStripMenuItem";
            this.sueloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sueloToolStripMenuItem.Text = "Suelo";
            // 
            // aguaToolStripMenuItem
            // 
            this.aguaToolStripMenuItem.Name = "aguaToolStripMenuItem";
            this.aguaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aguaToolStripMenuItem.Text = "Agua";
            // 
            // alimentosToolStripMenuItem
            // 
            this.alimentosToolStripMenuItem.Name = "alimentosToolStripMenuItem";
            this.alimentosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alimentosToolStripMenuItem.Text = "Alimentos";
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.menuStrip3.Location = new System.Drawing.Point(12, 76);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(217, 25);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem16,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.residuosPeligrososToolStripMenuItem});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(209, 21);
            this.toolStripMenuItem6.Text = "Riesgos Químicos-Tecnológicos";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem7.Text = "Derrames";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem8.Text = "Explosiones";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem16.Text = "Radiaciones";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem9.Text = "Fugas Tóxicas";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem10.Text = "Incendios";
            // 
            // residuosPeligrososToolStripMenuItem
            // 
            this.residuosPeligrososToolStripMenuItem.Name = "residuosPeligrososToolStripMenuItem";
            this.residuosPeligrososToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.residuosPeligrososToolStripMenuItem.Text = "Residuos Peligrosos";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(12, 51);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(205, 25);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.mareasDeTormentasToolStripMenuItem,
            this.vientosToolStripMenuItem,
            this.sequíasToolStripMenuItem,
            this.erosiónToolStripMenuItem,
            this.precipitaciónToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 21);
            this.toolStripMenuItem1.Text = "Riesgos Hidrometereológicos";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem2.Text = "Huracanes";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem3.Text = "Inundaciones";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem4.Text = "Tormentas de Granizo";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(210, 22);
            this.toolStripMenuItem5.Text = "Heladas y nevadas";
            // 
            // mareasDeTormentasToolStripMenuItem
            // 
            this.mareasDeTormentasToolStripMenuItem.Name = "mareasDeTormentasToolStripMenuItem";
            this.mareasDeTormentasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mareasDeTormentasToolStripMenuItem.Text = "Mareas de tormentas";
            // 
            // vientosToolStripMenuItem
            // 
            this.vientosToolStripMenuItem.Name = "vientosToolStripMenuItem";
            this.vientosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.vientosToolStripMenuItem.Text = "Vientos";
            // 
            // sequíasToolStripMenuItem
            // 
            this.sequíasToolStripMenuItem.Name = "sequíasToolStripMenuItem";
            this.sequíasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sequíasToolStripMenuItem.Text = "Sequías";
            // 
            // erosiónToolStripMenuItem
            // 
            this.erosiónToolStripMenuItem.Name = "erosiónToolStripMenuItem";
            this.erosiónToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.erosiónToolStripMenuItem.Text = "Erosión";
            // 
            // precipitaciónToolStripMenuItem
            // 
            this.precipitaciónToolStripMenuItem.Name = "precipitaciónToolStripMenuItem";
            this.precipitaciónToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.precipitaciónToolStripMenuItem.Text = "Precipitación";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riesgosMetereológicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(144, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riesgosMetereológicosToolStripMenuItem
            // 
            this.riesgosMetereológicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sismosToolStripMenuItem,
            this.erupcionesToolStripMenuItem,
            this.emisionesVolcánicasToolStripMenuItem,
            this.tsunamisToolStripMenuItem,
            this.inestabilidadDeLaderasToolStripMenuItem,
            this.hundimientosToolStripMenuItem,
            this.agritamientosDeTerrenoToolStripMenuItem});
            this.riesgosMetereológicosToolStripMenuItem.Name = "riesgosMetereológicosToolStripMenuItem";
            this.riesgosMetereológicosToolStripMenuItem.Size = new System.Drawing.Size(136, 21);
            this.riesgosMetereológicosToolStripMenuItem.Text = "Riesgos Geológicos";
            // 
            // sismosToolStripMenuItem
            // 
            this.sismosToolStripMenuItem.Name = "sismosToolStripMenuItem";
            this.sismosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.sismosToolStripMenuItem.Text = "Sismos";
            // 
            // erupcionesToolStripMenuItem
            // 
            this.erupcionesToolStripMenuItem.Name = "erupcionesToolStripMenuItem";
            this.erupcionesToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.erupcionesToolStripMenuItem.Text = "Erupciones";
            // 
            // emisionesVolcánicasToolStripMenuItem
            // 
            this.emisionesVolcánicasToolStripMenuItem.Name = "emisionesVolcánicasToolStripMenuItem";
            this.emisionesVolcánicasToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.emisionesVolcánicasToolStripMenuItem.Text = "Emisiones Volcánicas";
            // 
            // tsunamisToolStripMenuItem
            // 
            this.tsunamisToolStripMenuItem.Name = "tsunamisToolStripMenuItem";
            this.tsunamisToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.tsunamisToolStripMenuItem.Text = "Tsunamis";
            // 
            // inestabilidadDeLaderasToolStripMenuItem
            // 
            this.inestabilidadDeLaderasToolStripMenuItem.Name = "inestabilidadDeLaderasToolStripMenuItem";
            this.inestabilidadDeLaderasToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.inestabilidadDeLaderasToolStripMenuItem.Text = "Inestabilidad de Laderas";
            // 
            // hundimientosToolStripMenuItem
            // 
            this.hundimientosToolStripMenuItem.Name = "hundimientosToolStripMenuItem";
            this.hundimientosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.hundimientosToolStripMenuItem.Text = "Hundimientos";
            // 
            // agritamientosDeTerrenoToolStripMenuItem
            // 
            this.agritamientosDeTerrenoToolStripMenuItem.Name = "agritamientosDeTerrenoToolStripMenuItem";
            this.agritamientosDeTerrenoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.agritamientosDeTerrenoToolStripMenuItem.Text = "Agritamientos de terreno";
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 0);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(839, 445);
            this.axMap1.TabIndex = 0;
            this.axMap1.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.axMap1_MouseDownEvent);
            this.axMap1.MouseMoveEvent += new AxMapWinGIS._DMapEvents_MouseMoveEventHandler(this.axMap1_MouseMoveEvent);
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
            this.cmbFilter.Size = new System.Drawing.Size(191, 24);
            this.cmbFilter.TabIndex = 6;
            // 
            // General
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1120, 470);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riesgosMetereológicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sismosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erupcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emisionesVolcánicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsunamisToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem aireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aguaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem residuosPeligrososToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mareasDeTormentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sequíasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precipitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inestabilidadDeLaderasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hundimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agritamientosDeTerrenoToolStripMenuItem;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label2;

    }
}

