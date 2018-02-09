namespace Sistema_de_Informacion_Geografico
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.busquedaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCapasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFenomenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entretenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprendeConVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuariopdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaGeneralToolStripMenuItem,
            this.mostrarCapasToolStripMenuItem,
            this.registrarFenomenosToolStripMenuItem,
            this.entretenimientoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // busquedaGeneralToolStripMenuItem
            // 
            this.busquedaGeneralToolStripMenuItem.Name = "busquedaGeneralToolStripMenuItem";
            this.busquedaGeneralToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.busquedaGeneralToolStripMenuItem.Text = "Home";
            this.busquedaGeneralToolStripMenuItem.Click += new System.EventHandler(this.busquedaGeneralToolStripMenuItem_Click);
            // 
            // mostrarCapasToolStripMenuItem
            // 
            this.mostrarCapasToolStripMenuItem.Name = "mostrarCapasToolStripMenuItem";
            this.mostrarCapasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mostrarCapasToolStripMenuItem.Text = "Mostrar Capas";
            this.mostrarCapasToolStripMenuItem.Click += new System.EventHandler(this.mostrarCapasToolStripMenuItem_Click);
            // 
            // registrarFenomenosToolStripMenuItem
            // 
            this.registrarFenomenosToolStripMenuItem.Name = "registrarFenomenosToolStripMenuItem";
            this.registrarFenomenosToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.registrarFenomenosToolStripMenuItem.Text = "Registrar fenomenos";
            this.registrarFenomenosToolStripMenuItem.Click += new System.EventHandler(this.registrarFenomenosToolStripMenuItem_Click);
            // 
            // entretenimientoToolStripMenuItem
            // 
            this.entretenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aprendeConVideosToolStripMenuItem,
            this.manualDeUsuariopdfToolStripMenuItem});
            this.entretenimientoToolStripMenuItem.Name = "entretenimientoToolStripMenuItem";
            this.entretenimientoToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.entretenimientoToolStripMenuItem.Text = "¿Cómo funciona?";
            this.entretenimientoToolStripMenuItem.Click += new System.EventHandler(this.entretenimientoToolStripMenuItem_Click);
            // 
            // aprendeConVideosToolStripMenuItem
            // 
            this.aprendeConVideosToolStripMenuItem.Name = "aprendeConVideosToolStripMenuItem";
            this.aprendeConVideosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.aprendeConVideosToolStripMenuItem.Text = "Aprende con videos";
            this.aprendeConVideosToolStripMenuItem.Click += new System.EventHandler(this.aprendeConVideosToolStripMenuItem_Click);
            // 
            // manualDeUsuariopdfToolStripMenuItem
            // 
            this.manualDeUsuariopdfToolStripMenuItem.Name = "manualDeUsuariopdfToolStripMenuItem";
            this.manualDeUsuariopdfToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.manualDeUsuariopdfToolStripMenuItem.Text = "Manual de usuario (pdf)";
            this.manualDeUsuariopdfToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuariopdfToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ayudaToolStripMenuItem.Text = "Acerca de";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 398);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem busquedaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCapasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarFenomenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entretenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprendeConVideosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuariopdfToolStripMenuItem;
    }
}