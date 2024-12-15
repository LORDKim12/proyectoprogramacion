namespace Proyecto_veterinaria
{
    partial class inventario
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
            this.Cerrar = new System.Windows.Forms.Button();
            this.volvermenu = new System.Windows.Forms.Button();
            this.dataGridViewInve = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInve)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.ForeColor = System.Drawing.Color.Red;
            this.Cerrar.Location = new System.Drawing.Point(757, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(31, 23);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.Text = "X";
            this.Cerrar.UseVisualStyleBackColor = true;
            // 
            // volvermenu
            // 
            this.volvermenu.ForeColor = System.Drawing.Color.Black;
            this.volvermenu.Location = new System.Drawing.Point(689, 305);
            this.volvermenu.Name = "volvermenu";
            this.volvermenu.Size = new System.Drawing.Size(99, 23);
            this.volvermenu.TabIndex = 1;
            this.volvermenu.Text = "Volver";
            this.volvermenu.UseVisualStyleBackColor = true;
            this.volvermenu.Click += new System.EventHandler(this.volvermenu_Click_1);
            // 
            // dataGridViewInve
            // 
            this.dataGridViewInve.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewInve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInve.GridColor = System.Drawing.Color.Black;
            this.dataGridViewInve.Location = new System.Drawing.Point(-2, 3);
            this.dataGridViewInve.Name = "dataGridViewInve";
            this.dataGridViewInve.Size = new System.Drawing.Size(675, 325);
            this.dataGridViewInve.TabIndex = 2;
            this.dataGridViewInve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInve_CellContentClick_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(689, 84);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar al inventario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVentas
            // 
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(689, 34);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(99, 45);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ir a ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(689, 133);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(99, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Proyecto_veterinaria.Properties.Resources.guau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewInve);
            this.Controls.Add(this.volvermenu);
            this.Controls.Add(this.Cerrar);
            this.ForeColor = System.Drawing.Color.Brown;
            this.Name = "inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventario";
            this.Load += new System.EventHandler(this.inventario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button volvermenu;
        private System.Windows.Forms.DataGridView dataGridViewInve;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnActualizar;
    }
}