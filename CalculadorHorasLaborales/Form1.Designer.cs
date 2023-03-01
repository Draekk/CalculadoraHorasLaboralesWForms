namespace CalculadorHorasLaborales
{
    partial class iPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iPrincipal));
            this.dtpHoraInicial1 = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinal1 = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpHoraInicial1
            // 
            this.dtpHoraInicial1.CustomFormat = "HH:mm";
            this.dtpHoraInicial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicial1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicial1.Location = new System.Drawing.Point(4, 28);
            this.dtpHoraInicial1.Name = "dtpHoraInicial1";
            this.dtpHoraInicial1.ShowUpDown = true;
            this.dtpHoraInicial1.Size = new System.Drawing.Size(92, 38);
            this.dtpHoraInicial1.TabIndex = 0;
            this.dtpHoraInicial1.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // dtpHoraFinal1
            // 
            this.dtpHoraFinal1.CustomFormat = "HH:mm";
            this.dtpHoraFinal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFinal1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFinal1.Location = new System.Drawing.Point(112, 28);
            this.dtpHoraFinal1.Name = "dtpHoraFinal1";
            this.dtpHoraFinal1.ShowUpDown = true;
            this.dtpHoraFinal1.Size = new System.Drawing.Size(92, 38);
            this.dtpHoraFinal1.TabIndex = 1;
            this.dtpHoraFinal1.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDias.Location = new System.Drawing.Point(220, 28);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(40, 38);
            this.txtCantidadDias.TabIndex = 2;
            this.txtCantidadDias.Text = "1";
            this.txtCantidadDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(278, 28);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 38);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Lime;
            this.lblResultado.Location = new System.Drawing.Point(216, 84);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(109, 43);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hora Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Días";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DrakkCorp";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(40, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total horas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(6, 67);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(20, 20);
            this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // iPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(375, 152);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidadDias);
            this.Controls.Add(this.dtpHoraFinal1);
            this.Controls.Add(this.dtpHoraInicial1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "iPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Horas Laborales";
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraInicial1;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal1;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnLimpiar;
    }
}

