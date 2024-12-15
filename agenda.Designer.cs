using System;

namespace Proyecto_veterinaria
{
    partial class agenda
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
            this.cerrar = new System.Windows.Forms.Button();
            this.Volvermenu = new System.Windows.Forms.Button();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtNombreDe = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textRaza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textMas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cerrar
            // 
            this.cerrar.ForeColor = System.Drawing.Color.Red;
            this.cerrar.Location = new System.Drawing.Point(757, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(31, 26);
            this.cerrar.TabIndex = 0;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Volvermenu
            // 
            this.Volvermenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Volvermenu.Location = new System.Drawing.Point(570, 420);
            this.Volvermenu.Name = "Volvermenu";
            this.Volvermenu.Size = new System.Drawing.Size(108, 25);
            this.Volvermenu.TabIndex = 1;
            this.Volvermenu.Text = "Volver";
            this.Volvermenu.UseVisualStyleBackColor = true;
            this.Volvermenu.Click += new System.EventHandler(this.Volvermenu_Click);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(86, 40);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(278, 20);
            this.txtDia.TabIndex = 2;
            // 
            // txtNombreDe
            // 
            this.txtNombreDe.Location = new System.Drawing.Point(86, 108);
            this.txtNombreDe.Name = "txtNombreDe";
            this.txtNombreDe.Size = new System.Drawing.Size(278, 20);
            this.txtNombreDe.TabIndex = 3;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(86, 72);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(278, 20);
            this.txtHora.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(570, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(159)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(159)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(159)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(159)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(86, 143);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(278, 20);
            this.txtClave.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Color:";
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(86, 421);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(278, 20);
            this.textColor.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Peso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Edad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Raza:";
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(86, 350);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(278, 20);
            this.textEdad.TabIndex = 13;
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(86, 386);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(278, 20);
            this.textPeso.TabIndex = 12;
            // 
            // textRaza
            // 
            this.textRaza.Location = new System.Drawing.Point(86, 311);
            this.textRaza.Name = "textRaza";
            this.textRaza.Size = new System.Drawing.Size(278, 20);
            this.textRaza.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(6, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Telefono:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(86, 210);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(278, 20);
            this.textTelefono.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Direccion:";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(86, 176);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(278, 20);
            this.textDireccion.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(166)))), ((int)(((byte)(159)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(83, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "INFORMACION DEL DUEÑO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(83, 240);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "INFORMACION DE LA MASCOTA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(3, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 18);
            this.label13.TabIndex = 30;
            this.label13.Text = "Nombre:";
            // 
            // textMas
            // 
            this.textMas.Location = new System.Drawing.Point(86, 282);
            this.textMas.Name = "textMas";
            this.textMas.Size = new System.Drawing.Size(278, 20);
            this.textMas.TabIndex = 29;
            // 
            // agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Proyecto_veterinaria.Properties.Resources.gogogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textMas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.textRaza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtNombreDe);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.Volvermenu);
            this.Controls.Add(this.cerrar);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.agenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button Volvermenu;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtNombreDe;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textRaza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textMas;
    }
}