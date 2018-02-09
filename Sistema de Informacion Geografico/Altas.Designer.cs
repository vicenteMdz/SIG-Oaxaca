namespace Sistema_de_Informacion_Geografico
{
    partial class Altas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Altas));
            this.Pobla = new System.Windows.Forms.ComboBox();
            this.Municip = new System.Windows.Forms.ComboBox();
            this.Distri = new System.Windows.Forms.ComboBox();
            this.Region = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolCursor = new System.Windows.Forms.ToolStripButton();
            this.toolZoomExtent = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomInt = new System.Windows.Forms.ToolStripButton();
            this.toolMove = new System.Windows.Forms.ToolStripButton();
            this.axMap1 = new AxMapWinGIS.AxMap();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pobla
            // 
            this.Pobla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pobla.FormattingEnabled = true;
            this.Pobla.Location = new System.Drawing.Point(121, 255);
            this.Pobla.Name = "Pobla";
            this.Pobla.Size = new System.Drawing.Size(279, 24);
            this.Pobla.TabIndex = 27;
            this.Pobla.SelectedIndexChanged += new System.EventHandler(this.Pobla_SelectedIndexChanged);
            // 
            // Municip
            // 
            this.Municip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Municip.FormattingEnabled = true;
            this.Municip.Location = new System.Drawing.Point(121, 225);
            this.Municip.Name = "Municip";
            this.Municip.Size = new System.Drawing.Size(279, 24);
            this.Municip.TabIndex = 26;
            this.Municip.SelectedIndexChanged += new System.EventHandler(this.Municip_SelectedIndexChanged);
            // 
            // Distri
            // 
            this.Distri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distri.FormattingEnabled = true;
            this.Distri.Location = new System.Drawing.Point(121, 187);
            this.Distri.Name = "Distri";
            this.Distri.Size = new System.Drawing.Size(279, 24);
            this.Distri.TabIndex = 25;
            this.Distri.SelectedIndexChanged += new System.EventHandler(this.Distri_SelectedIndexChanged);
            // 
            // Region
            // 
            this.Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Region.FormattingEnabled = true;
            this.Region.Location = new System.Drawing.Point(121, 152);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(279, 24);
            this.Region.TabIndex = 24;
            this.Region.SelectedIndexChanged += new System.EventHandler(this.Region_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "CP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Población:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Municipio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Distrito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Región:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categoria:";
            // 
            // Categoria
            // 
            this.Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Location = new System.Drawing.Point(121, 122);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(279, 24);
            this.Categoria.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(121, 292);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(279, 22);
            this.Codigo.TabIndex = 28;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(121, 326);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(279, 22);
            this.Fecha.TabIndex = 30;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(191, 492);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(89, 28);
            this.Guardar.TabIndex = 31;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Descripción";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(121, 354);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(279, 132);
            this.descripcion.TabIndex = 33;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.Pobla);
            this.splitContainer1.Panel1.Controls.Add(this.descripcion);
            this.splitContainer1.Panel1.Controls.Add(this.Categoria);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Guardar);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Fecha);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.Municip);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.Distri);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.Region);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMap1);
            this.splitContainer1.Size = new System.Drawing.Size(1332, 704);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 34;
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
            this.toolStrip1.Size = new System.Drawing.Size(345, 25);
            this.toolStrip1.TabIndex = 34;
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
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 0);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(983, 704);
            this.axMap1.TabIndex = 0;
            // 
            // Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 704);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Altas";
            this.Text = "Altas de fenomenos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Altas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Pobla;
        private System.Windows.Forms.ComboBox Municip;
        private System.Windows.Forms.ComboBox Distri;
        private System.Windows.Forms.ComboBox Region;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolCursor;
        private System.Windows.Forms.ToolStripButton toolZoomExtent;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripButton toolZoomInt;
        private System.Windows.Forms.ToolStripButton toolMove;
    }
}