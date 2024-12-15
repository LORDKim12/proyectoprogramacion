namespace Proyecto_veterinaria
{
    partial class menu
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
            this.Bagenda = new System.Windows.Forms.Button();
            this.Bextra1 = new System.Windows.Forms.Button();
            this.Binventario = new System.Windows.Forms.Button();
            this.Bextra = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bagenda
            // 
            this.Bagenda.Location = new System.Drawing.Point(122, 120);
            this.Bagenda.Name = "Bagenda";
            this.Bagenda.Size = new System.Drawing.Size(139, 38);
            this.Bagenda.TabIndex = 0;
            this.Bagenda.Text = "CITAS";
            this.Bagenda.UseVisualStyleBackColor = true;
            this.Bagenda.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bextra1
            // 
            this.Bextra1.Location = new System.Drawing.Point(122, 164);
            this.Bextra1.Name = "Bextra1";
            this.Bextra1.Size = new System.Drawing.Size(139, 38);
            this.Bextra1.TabIndex = 1;
            this.Bextra1.Text = "VENTAS";
            this.Bextra1.UseVisualStyleBackColor = true;
            this.Bextra1.Click += new System.EventHandler(this.Bextra1_Click);
            // 
            // Binventario
            // 
            this.Binventario.Location = new System.Drawing.Point(122, 208);
            this.Binventario.Name = "Binventario";
            this.Binventario.Size = new System.Drawing.Size(139, 38);
            this.Binventario.TabIndex = 2;
            this.Binventario.Text = "INVENTARIO";
            this.Binventario.UseVisualStyleBackColor = true;
            this.Binventario.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bextra
            // 
            this.Bextra.Location = new System.Drawing.Point(122, 252);
            this.Bextra.Name = "Bextra";
            this.Bextra.Size = new System.Drawing.Size(139, 38);
            this.Bextra.TabIndex = 3;
            this.Bextra.Text = "PERSONAL";
            this.Bextra.UseVisualStyleBackColor = true;
            this.Bextra.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(748, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_veterinaria.Properties.Resources.U;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Bextra);
            this.Controls.Add(this.Binventario);
            this.Controls.Add(this.Bextra1);
            this.Controls.Add(this.Bagenda);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bagenda;
        private System.Windows.Forms.Button Bextra1;
        private System.Windows.Forms.Button Binventario;
        private System.Windows.Forms.Button Bextra;
        private System.Windows.Forms.Button button5;
    }
}

