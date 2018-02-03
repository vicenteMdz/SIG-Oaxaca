namespace Sistema_de_Informacion_Geografico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_User = new System.Windows.Forms.TextBox();
            this.text_Passw = new System.Windows.Forms.TextBox();
            this.btn_Iniciar_Sesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_User
            // 
            this.text_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_User.Location = new System.Drawing.Point(172, 194);
            this.text_User.Name = "text_User";
            this.text_User.Size = new System.Drawing.Size(179, 22);
            this.text_User.TabIndex = 2;
            // 
            // text_Passw
            // 
            this.text_Passw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Passw.Location = new System.Drawing.Point(172, 222);
            this.text_Passw.Name = "text_Passw";
            this.text_Passw.PasswordChar = '*';
            this.text_Passw.Size = new System.Drawing.Size(179, 22);
            this.text_Passw.TabIndex = 3;
            // 
            // btn_Iniciar_Sesion
            // 
            this.btn_Iniciar_Sesion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Iniciar_Sesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Iniciar_Sesion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Iniciar_Sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Iniciar_Sesion.Location = new System.Drawing.Point(127, 286);
            this.btn_Iniciar_Sesion.Name = "btn_Iniciar_Sesion";
            this.btn_Iniciar_Sesion.Size = new System.Drawing.Size(113, 32);
            this.btn_Iniciar_Sesion.TabIndex = 4;
            this.btn_Iniciar_Sesion.Text = "Iniciar Sesión";
            this.btn_Iniciar_Sesion.UseVisualStyleBackColor = false;
            this.btn_Iniciar_Sesion.Click += new System.EventHandler(this.btn_Iniciar_Sesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Informacion_Geografico.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 369);
            this.Controls.Add(this.text_Passw);
            this.Controls.Add(this.text_User);
            this.Controls.Add(this.btn_Iniciar_Sesion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox text_User;
        private System.Windows.Forms.TextBox text_Passw;
        private System.Windows.Forms.Button btn_Iniciar_Sesion;
    }
}

